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
    public class ReferralCondition<T> : StringOperatorCondition<T>
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

            string UrlReferrer = HttpContext.Current.Request.UrlReferrer?.ToString();

            if (string.IsNullOrEmpty(UrlReferrer))
            {
                return false;
            }
            return base.Compare(UrlReferrer, value);
        }
    }
}
 