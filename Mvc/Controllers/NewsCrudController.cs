/* ------------------------------------------------------------------------------
<auto-generated>
    This file was generated by Sitefinity CLI v1.1.0.31
</auto-generated>
------------------------------------------------------------------------------ */

using SFDevApril2023.Mvc.Models;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.GenericContent.Model;
using Telerik.Sitefinity.Modules.News;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Personalization;

namespace SFDevApril2023.Mvc.Controllers
{
	[ControllerToolboxItem(Name = "NewsCrud", Title = "News Widget", SectionName = "SFDevApril2023")]
	public class NewsCrudController : Controller, IPersonalizable
	{
        NewsManager newsManager = NewsManager.GetManager();
        // GET: NewsCrud
        public ActionResult Index()
		{
            var news = newsManager.GetNewsItems().Where(n => n.Status == ContentLifecycleStatus.Live);
            var model = new NewsCrudModel(news);
			
			return View("Index", model);
		}
		
        protected override void HandleUnknownAction(string actionName)
        {
            this.ActionInvoker.InvokeAction(this.ControllerContext, "Index");
        }

	}
}