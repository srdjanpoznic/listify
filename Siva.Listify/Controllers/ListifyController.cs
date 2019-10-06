using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Siva.Listify.Models;

namespace Siva.Listify.Controllers
{
	public class ListifyController : ApiController
	{
		// {POST} api/listify
		[HttpPost]
		//[Route("/")]
		public HttpResponseMessage Post([FromBody] GetListifyValueRequest getValueRequest)
		{
			if (getValueRequest == null)
				return Request.CreateResponse(HttpStatusCode.BadRequest);

			try
			{
				var listify = new Models.Listify(getValueRequest.Begin, getValueRequest.End);
				var value = listify[getValueRequest.Index];
				return Request.CreateResponse(HttpStatusCode.OK, value);
			}
			catch (IndexOutOfRangeException e)
			{
				var message = $"Index {getValueRequest.Index} not found";
				HttpError err = new HttpError(message);
				return Request.CreateResponse(HttpStatusCode.NotFound, err);
			}
			catch (Exception e)
			{
				return Request.CreateResponse(HttpStatusCode.NotFound, new HttpError("Unhandled error. Please call the administrator."));
			}
		}
	}
}

