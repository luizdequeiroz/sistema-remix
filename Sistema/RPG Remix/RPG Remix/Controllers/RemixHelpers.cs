using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace RPG_Remix.Controllers
{
    public static class RemixHelpers
    {
        public static MvcHtmlString TagActionLink(this AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, object routeValues, AjaxOptions ajaxOptions, object htmlAttributes)
        {
            var repId = Guid.NewGuid().ToString();
            var tag = ajaxHelper.ActionLink(repId, actionName, controllerName, routeValues, ajaxOptions, htmlAttributes);
            return MvcHtmlString.Create(tag.ToString().Replace(repId, linkText));
        }
    }
}