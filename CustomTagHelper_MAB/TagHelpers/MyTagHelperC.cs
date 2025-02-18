using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper_MAB.TagHelpers
{
    [HtmlTargetElement("myimage")]
    public class MyTagHelperC : TagHelper
    {
        public string Src { get; set; }
        public string Alt { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Class { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img";

            output.Attributes.SetAttribute("src", Src);

            output.Attributes.SetAttribute("alt", Alt);

            if (!string.IsNullOrEmpty(Width))
            {
                output.Attributes.SetAttribute("width", Width);
            }

            if (!string.IsNullOrEmpty(Height))
            {
                output.Attributes.SetAttribute("height", Height);
            }

            if (!string.IsNullOrEmpty(Class))
            {
                output.Attributes.SetAttribute("class", Class);
            }
        }
    }
}
