using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Sitecore;
using Sitecore.Diagnostics;
using Sitecore.Rules;
using Sitecore.Rules.Conditions;
using Sitecore.Sites;
using System.Runtime.CompilerServices;

namespace Foundation.Analytics.ChannelRules.Rules.Conditions
{
    public class QueryStringCondition<T> : StringOperatorCondition<T>
    where T : RuleContext
    {
        public string Value
        {
            get;
            set;
        }
 
        protected override bool Execute(T ruleContext)
        {
            Assert.ArgumentNotNull(ruleContext, "ruleContext");
            string value = this.Value;
            if (value == null)
            {
                return false;
            }
            string queryString = Context.Request?.QueryString?.ToString();

            if (string.IsNullOrEmpty(queryString))
            {
                return false;
            }

            return base.Compare(queryString, value);
        }
    }
}
 