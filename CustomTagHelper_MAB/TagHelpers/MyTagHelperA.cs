using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper_MAB.TagHelpers
{
    [HtmlTargetElement("mytag")]
    public class MyTagHelperA : TagHelper
    {
        public string path { get; set; }

        public string altText { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";

            output.TagMode = TagMode.StartTagAndEndTag;

            output.Attributes.SetAttribute("href", path);
            output.Attributes.SetAttribute("alt", altText);
            output.Content.SetContent("Click me");
        }

    }

}
