using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ExceptionTest.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			throw new WebException("awesome", WebExceptionStatus.RequestCanceled);
			return View();
		}
		public ActionResult poop()
		{
			throw new HttpResponseException(HttpStatusCode.BadGateway);
			return View();
		}

	}


}