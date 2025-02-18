using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper_MAB.TagHelpers
{
    [HtmlTargetElement("mybutton", Attributes = "bg-color")]
    public class MyTagHelperB : TagHelper
    {
        public string BgColor { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.TagMode = TagMode.StartTagAndEndTag;

            output.Attributes.SetAttribute("style", $"background-color: black; color: white; padding: 10px 20px; border: none; color: white; cursor: pointer;");
            output.Attributes.SetAttribute("onclick", $"document.body.style.backgroundColor = '{BgColor}'");

            output.Content.SetContent("Click me");
        }
    }
}
