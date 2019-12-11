using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SAPSDK_API.Controllers.MasterData
{
    [RoutePrefix("api/items")]
    public class ItemsController : ApiController
    {
        [Route("get")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
