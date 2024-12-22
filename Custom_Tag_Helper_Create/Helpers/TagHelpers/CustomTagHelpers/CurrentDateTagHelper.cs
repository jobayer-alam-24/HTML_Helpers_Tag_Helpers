using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Custom_Tag_Helper_Create.Helpers.TagHelpers.CustomTagHelpers
{
    [HtmlTargetElement("current-date")]
    public class CurrentDateTagHelper : TagHelper
    {
        public override void Process(TagHelperContext _context, TagHelperOutput output)
        {
            output.TagName = "b";
            output.Content.SetContent(DateTime.Now.ToString("dd/MM/yyyy"));
        }
    }
}