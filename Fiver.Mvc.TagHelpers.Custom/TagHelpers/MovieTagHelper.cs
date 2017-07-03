using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiver.Mvc.TagHelpers.Custom.TagHelpers
{
    [HtmlTargetElement("movie",
        TagStructure = TagStructure.WithoutEndTag)]
    public class MovieTagHelper : TagHelper
    {
        [HtmlAttributeName("for-title")]
        public ModelExpression Title { get; set; }

        [HtmlAttributeName("for-year")]
        public ModelExpression ReleaseYear { get; set; }

        [HtmlAttributeName("for-director")]
        public ModelExpression Director { get; set; }

        [HtmlAttributeName("for-summary")]
        public ModelExpression Summary { get; set; }
        
        [HtmlAttributeName("for-stars")]
        public ModelExpression Stars { get; set; }

        public override void Process(
            TagHelperContext context,
            TagHelperOutput output)
        {
            if (!(this.Stars.Model is List<string>))
                throw new ArgumentException("Stars must be a list");
            
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;

            output.Attributes.Add("class", "movie-tag");

            output.Content.AppendHtml(GetTitle());
            output.Content.AppendHtml(GetDirector());
            output.Content.AppendHtml(GetSummary());
            output.Content.AppendHtml(GetStars());
        }

        private TagBuilder GetTitle()
        {
            var year = new TagBuilder("span");
            year.Attributes.Add("class", "movie-year");
            year.InnerHtml.AppendHtml(
                string.Format("({0})", this.ReleaseYear.Model));

            var title = new TagBuilder("div");
            title.Attributes.Add("class", "movie-title");
            title.InnerHtml.AppendHtml(
                string.Format("{0}", this.Title.Model));
            title.InnerHtml.AppendHtml(year);

            return title;
        }

        private TagBuilder GetDirector()
        {
            var director = new TagBuilder("div");
            director.Attributes.Add("class", "movie-director");
            director.InnerHtml.AppendHtml(
                string.Format("<span>Director: {0}</span>", this.Director.Model));
            return director;
        }

        private TagBuilder GetSummary()
        {
            var summary = new TagBuilder("div");
            summary.Attributes.Add("class", "movie-summary");
            summary.InnerHtml.AppendHtml(
                string.Format("<span><strong>Plot: </strong>{0}</span>", this.Summary.Model));
            return summary;
        }

        private TagBuilder GetStars()
        {
            var stars = new TagBuilder("div");
            stars.Attributes.Add("class", "movie-stars");
            stars.InnerHtml.AppendHtml("<strong>Stars</strong>");
            stars.InnerHtml.AppendHtml("<ul>");

            var model = this.Stars.Model as List<string>;
            foreach (var item in model)
            {
                stars.InnerHtml.AppendHtml(
                    string.Format("<li>{0}</li>", item));
            }

            stars.InnerHtml.AppendHtml("</ul>");
            return stars;
        }
    }
}
