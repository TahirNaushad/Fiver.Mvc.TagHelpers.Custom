using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Fiver.Mvc.TagHelpers.Custom.TagHelpers
{
    [HtmlTargetElement("context-info")]
    public class ContextTagHelper : TagHelper
    {
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override void Process(
            TagHelperContext context, 
            TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;

            output.Content.AppendHtml(
                string.Format("<p>{0}</p>", this.ViewContext.ViewBag.Greeting));

            foreach (var item in ViewContext.RouteData.Values)
            {
                output.Content.AppendHtml(
                    string.Format("<p>{0}: {1}</p>", item.Key, item.Value));
            }

            output.Content.AppendHtml(
                string.Format("<p>ModelState.IsValid: {0}</p>", 
                                    this.ViewContext.ModelState.IsValid));
        }
    }
}
