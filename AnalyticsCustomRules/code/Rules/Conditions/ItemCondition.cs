 using Sitecore.Diagnostics;
using Sitecore.Rules;
using Sitecore.Data.Items;
using System;

namespace Foundation.Analytics.ChannelRules.Rules.Conditions
{
    public class ItemCondition<T>  : Sitecore.Rules.Conditions.ItemConditions.ItemIdCondition<T>
    where T : RuleContext
    {
 
        protected override bool Execute(T ruleContext)
        {

           Assert.ArgumentNotNull(ruleContext, "ruleContext");
            Item item = ruleContext.Item;
            if (item == null)
            {
                return false;
            }

            Guid guid;
            string guidId = this.Value ?? string.Empty;

            if (string.IsNullOrEmpty(guidId) || !Guid.TryParse(guidId, out guid))
            {
                Log.Debug(string.Format("Specified item id [{0}] was not a valid Guid", guidId));
                return false;
            }


            return item?.ID?.Guid == guid;
        }
    }
}
 