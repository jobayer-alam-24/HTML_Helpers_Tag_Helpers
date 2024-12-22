using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Custom_Tag_Helper_Create.Helpers.TagHelpers.CustomTagHelpers
{
    [HtmlTargetElement("email-link")]
    public class EmailLinkTagHelper : TagHelper
    {
        public string text {get; set;}
        public string address {get; set;}

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + address);  
            output.Content.SetContent(text);      
        }
    }
}