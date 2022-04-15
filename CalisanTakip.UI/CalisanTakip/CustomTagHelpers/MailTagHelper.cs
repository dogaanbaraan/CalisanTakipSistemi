using CalisanTakip.Common.ConstantsModel;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CalisanTakip.CustomTagHelpers
{
    [HtmlTargetElement("My-Email")]
    public class MailTagHelper : TagHelper
    {
        public string MailTo { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var mailTo = MailTo + ResultConstant.MailTagHelperSuffeix;
            output.Attributes.SetAttribute("href", "MailTo: " + mailTo);
            base.Process(context, output);
        }
    }
}
