using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace mvc_demo
{
    public static class MyHtmlHelpers
    {
        public static IHtmlString Button(this HtmlHelper helper, string name)
        {
            return MvcHtmlString.Create($"<button class=\"btn default\">{name}</button>");
        }
    }
}
