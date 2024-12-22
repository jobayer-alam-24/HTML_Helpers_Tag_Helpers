using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Custom_Tag_Helper_Create.Helpers.TagHelpers.CustomTagHelpers
{
    [HtmlTargetElement("highlight-text")]
    public class HighlightTextTagHelper : TagHelper
    {
        public string Text { get; set; } = null;
        public string HighlightColor {get; set;} = null;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            output.Attributes.SetAttribute("style", $"background-color: {HighlightColor}");
            output.Content.SetContent(Text);
        }
    }
}