using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetCore.WebApps.TagHelpers
{
    [HtmlTargetElement("my-first-tag-helper")]
    public class ExampleTagHelper : TagHelper
    {
        public string Name { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ExampleTagHelper1";
            output.TagMode = TagMode.StartTagAndEndTag;

            var sb = new StringBuilder();
            sb.AppendFormat("<span>Hi! {0}</span>", this.Name);

            output.PreContent.SetHtmlContent(sb.ToString());
        }
    }
}
