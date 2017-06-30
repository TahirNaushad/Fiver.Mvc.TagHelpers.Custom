using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Text;

namespace Fiver.Mvc.TagHelpers.Custom.TagHelpers
{
    [HtmlTargetElement("employee")]
    public class EmployeeProfileTagHelper : TagHelper
    {
        [HtmlAttributeName("summary")]
        public string Summary { get; set; }

        [HtmlAttributeName("job-title")]
        public string JobTitle { get; set; }

        [HtmlAttributeName("profile")]
        public string Profile { get; set; }

        public override void Process(
            TagHelperContext context, 
            TagHelperOutput output)
        {
            output.TagName = "details";
            output.TagMode = TagMode.StartTagAndEndTag;

            var sb = new StringBuilder();
            sb.AppendFormat("<summary>{0}</summary>", this.Summary);
            sb.AppendFormat("<em>{0}</em>", this.JobTitle);
            sb.AppendFormat("<p>{0}</p>", this.Profile);
            sb.AppendFormat("<ul>");

            output.PreContent.SetHtmlContent(sb.ToString());

            output.PostContent.SetHtmlContent("</ul>");
        }
    }

    [HtmlTargetElement("friend", 
        ParentTag = "employee",
        TagStructure = TagStructure.WithoutEndTag)]
    public class EmployeeFriendTagHelper : TagHelper
    {
        [HtmlAttributeName("name")]
        public string Name { get; set; }

        public override void Process(
            TagHelperContext context, 
            TagHelperOutput output)
        {
            output.TagName = "li";
            output.TagMode = TagMode.StartTagAndEndTag;

            output.Content.SetContent(this.Name);
        }
    }
}
