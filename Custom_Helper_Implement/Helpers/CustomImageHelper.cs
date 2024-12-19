using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Custom_Helper_Implement.Helpers
{
    public static class CustomImageHelper
    {
        public static IHtmlContent Image(this IHtmlHelper htmlHelper, string src, string alt, object htmlAttributes = null){
            var imgTag = new TagBuilder("img");
            imgTag.Attributes.Add("alt", alt);
            imgTag.Attributes.Add("src", src);

            if(htmlAttributes != null){
                var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
                imgTag.MergeAttributes(attributes);
            }
            return imgTag;
        }
    }
}