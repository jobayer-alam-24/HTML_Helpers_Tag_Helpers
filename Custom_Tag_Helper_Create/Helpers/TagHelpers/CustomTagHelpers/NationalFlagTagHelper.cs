using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
namespace Custom_Tag_Helper_Create.Helpers.TagHelpers.CustomTagHelpers
{
    [HtmlTargetElement("national-flag")]
    public class NationalFlagTagHelper : TagHelper
    {
        public string InnerColor { get; set; } = null;
        public string OuterColor { get; set; } = null;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("style", $"display: flex; align-items: center; justify-content: center; width: 500px; height: 300px; background-color: {OuterColor};");
            
            var completeTag = $"<div style='width:150px; height:150px; border-radius: 50%; background-color: {InnerColor}'></div>";

            output.Content.SetHtmlContent(completeTag);
        }
    }
}