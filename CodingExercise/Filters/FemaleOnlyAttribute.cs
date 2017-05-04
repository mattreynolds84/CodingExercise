using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;
using CodingExercise.Models;
using Newtonsoft.Json;

namespace CodingExercise.Filters
{
    public class FemaleOnlyAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            var data =
                (ObjectContent<List<Person>>) actionExecutedContext
                    .ActionContext.Response.Content;
            var results = (List<Person>)data.Value;



            actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(HttpStatusCode.OK, results);
            base.OnActionExecuted(actionExecutedContext);
        }
    }
}