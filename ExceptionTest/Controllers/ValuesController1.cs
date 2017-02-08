using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExceptionTest.Controllers
{
	public class ValuesController : ApiController
	{
		// GET api/<controller>
		public IEnumerable<string> Get()
		{
			throw new HttpResponseException(HttpStatusCode.BadGateway);
			//throw new WebException("awesome", WebExceptionStatus.RequestCanceled);
		}
	}
}