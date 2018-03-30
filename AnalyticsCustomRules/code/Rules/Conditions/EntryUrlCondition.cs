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
    public class EntryUrlCondition<T> : StringOperatorCondition<T>
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
            string Url = Context.RawUrl;

            if (string.IsNullOrEmpty(Url))
            {
                return false;
            }

            int QuerystringIndex = Url.IndexOf('?');
            Url = QuerystringIndex > 0 ? Url.Substring(0, QuerystringIndex) : Url;

            return base.Compare(Url, value);
        }
    }
}
 