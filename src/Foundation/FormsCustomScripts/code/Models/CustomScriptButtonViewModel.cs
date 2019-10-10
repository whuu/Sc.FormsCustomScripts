using Sitecore;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.ExperienceForms.Mvc.Models.Fields;

namespace Sc.FormsCustomScripts.Models
{
    public class CustomScriptButtonViewModel : ButtonViewModel
    {
        public string FormSubmitScript { get; set; }

        protected override void InitItemProperties(Item item)
        {
            Assert.ArgumentNotNull(item, nameof(item));
            base.InitItemProperties(item);
            FormSubmitScript = StringUtil.GetString((object)item.Fields["Form Submit Script"]);
        }

        protected override void UpdateItemFields(Item item)
        {
            Assert.ArgumentNotNull(item, nameof(item));
            base.UpdateItemFields(item);
            item.Fields["Form Submit Script"]?.SetValue(FormSubmitScript, false);
        }
    }
}