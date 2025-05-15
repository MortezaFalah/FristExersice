using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace YourProjectNamespace.TagHelpers
{
    [HtmlTargetElement("paging")]
    public class PaginationTagHelper(IUrlHelperFactory urlHelperFactory) : TagHelper
    {

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }

        public string UlClass { get; set; } = "pagination justify-content-center mt-3";
        public string LiClass { get; set; } = "page-item";
        public string AClass { get; set; } = "page-link";
        public string ActiveClass { get; set; } = "active";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            output.TagName = "nav";
            output.Content.Clear();

            var ulTag = new TagBuilder("ul");
            ulTag.AddCssClass(UlClass);

            for (int i = 1; i <= TotalPages; i++)
            {
                var liTag = new TagBuilder("li");
                liTag.AddCssClass(LiClass);
                if (i == CurrentPage)
                    liTag.AddCssClass(ActiveClass);

                var aTag = new TagBuilder("a");
                aTag.AddCssClass(AClass);
                aTag.Attributes["href"] = urlHelper.Action(Action, Controller, new { page = i });
                aTag.InnerHtml.Append(i.ToString());

                liTag.InnerHtml.AppendHtml(aTag);
                ulTag.InnerHtml.AppendHtml(liTag);
            }

            output.Content.AppendHtml(ulTag);
        }
    }
}
