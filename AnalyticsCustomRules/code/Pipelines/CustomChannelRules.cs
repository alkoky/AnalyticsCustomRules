using Foundation.Analytics.ChannelRules.Rules;
using Sitecore.Analytics.OmniChannel.Pipelines.DetermineInteractionChannel;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Rules;
using Sitecore.SecurityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foundation.Analytics.ChannelRules.Pipelines
{
    public class CustomChannelRules  : DetermineChannelProcessorBase
    {
        ///sitecore/system/Marketing Control Panel/Taxonomies/Channel Rules
        public string RootId = "{D7139CE4-C47C-4816-B9B7-1C710936A01A}";


        public override void Process(DetermineChannelProcessorArgs args)
        {
            Assert.ArgumentNotNull(args, "args");
            // Define context

            var ruleContext = new ChannelRulesContext()
            {
                ChannelId = null,
                Item = Sitecore.Context.Item
            };

            Item ChannelRulesRoot;

            // Set root
            using (new SecurityDisabler())
            {
                var db = Sitecore.Context.ContentDatabase??Sitecore.Context.Database;

                ChannelRulesRoot = db?.GetItem(RootId);

                if (ChannelRulesRoot == null)
                    return; // no root, exit
            }


           

            RuleList<ChannelRulesContext> rules = RuleFactory.GetRules<ChannelRulesContext>(ChannelRulesRoot, "Rule");//"Rule" is the field name

            if (rules != null)
            { // Run rules
                rules.Run(ruleContext);
            }



            if (ruleContext.ChannelId != (ID)null)
            {
                args.ChannelId = ruleContext.ChannelId;

                args.AbortPipeline();
              }
        }
    }
}
