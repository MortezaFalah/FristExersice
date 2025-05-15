using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace FristExersiceZhenic.InfraStructures
{
    [HtmlTargetElement("paging")]
    public class PageTagHelper(IUrlHelperFactory urlHelperFactory) : TagHelper
    {
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            output.TagName = "nav";
            output.Content.Clear();

            var ulTag = new TagBuilder("ul");
            ulTag.AddCssClass("pagination");

            for (int i = 1; i <= TotalPages; i++)
            {
                var liTag = new TagBuilder("li");
                liTag.AddCssClass("page-item");
                if (i == CurrentPage)
                    liTag.AddCssClass("active");

                var aTag = new TagBuilder("a");
                aTag.AddCssClass("page-link");
                aTag.Attributes["href"] = urlHelper.Action(Action, Controller, new { page = i });
                aTag.InnerHtml.Append(i.ToString());

                liTag.InnerHtml.AppendHtml(aTag);
                ulTag.InnerHtml.AppendHtml(liTag);
            }

            output.Content.AppendHtml(ulTag);
        }
    }
}
