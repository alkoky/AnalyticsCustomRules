using Sitecore.Data;
using Sitecore.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foundation.Analytics.ChannelRules.Rules
{
    public class ChannelRulesContext : RuleContext
        {
            public ID ChannelId { get; set; }
        }

}