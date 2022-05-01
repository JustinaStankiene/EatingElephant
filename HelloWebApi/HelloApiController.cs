using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace HelloWebApi
{
    public class HelloApiController : ApiController
    {
        public HttpResponseMessage Get(string name)
        {
            string result = $"Hello, {name}";
            var resp = new HttpResponseMessage(HttpStatusCode.OK);
            resp.Content = new StringContent(result, System.Text.Encoding.UTF8, "text/plain");
            return resp;
        }
    }
}