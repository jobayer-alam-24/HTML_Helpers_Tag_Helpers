using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Custom_Helper_Implement.Helpers
{
    public static class FormControlHelpers
    {
        public static IHtmlContent CustomInputWithValidation(this IHtmlHelper htmlHelper, string propertyName, string labelText){
            var htmlContent = @$"
            <div class='form-group'>
                <label for='{propertyName}'>{labelText}</label>
                <input type='text' class='form-control' id='{propertyName}' name='{propertyName}' asp-for='{propertyName}' />
                <span asp-validation-for='{propertyName}' class='text-danger'></span>
            </div>";
            return new HtmlString(htmlContent);
        }   
    }
}