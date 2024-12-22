using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Custom_Tag_Helper_Create.Helpers.TagHelpers.CustomTagHelpers
{
    [HtmlTargetElement("button-with-icon")]
    public class ButtonWithIconTagHelper : TagHelper
    {
        public string Text { get; set; }
        public string IconClass { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.Attributes.SetAttribute("class", "btn btn-primary");
            var icon = $"<i class='{IconClass}'></i>";
            
            output.Content.SetHtmlContent(icon + " " + Text);
        }
    }
}