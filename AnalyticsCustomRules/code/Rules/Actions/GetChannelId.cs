using Sitecore.Diagnostics;
using Sitecore.Rules.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foundation.Analytics.ChannelRules.Rules.Actions
{
 
    public class GetChannelId<T> : RuleAction<T> where T : ChannelRulesContext
    {

        public string ChannelId
        {
            get;
            set;
        }



        public override void Apply(T ruleContext)
        {
            Guid guid;

            if (!Guid.TryParse(this.ChannelId, out guid))
            {
                Log.Debug(string.Format("Specified channel [{0}] was not a valid Guid", this.ChannelId));
                return ;
            }

            ruleContext.ChannelId = new Sitecore.Data.ID(guid);

        }

    }
}