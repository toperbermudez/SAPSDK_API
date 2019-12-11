using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SAPSDK_API.Models.MasterData;

namespace SAPSDK_API.Controllers.MasterData
{
    [AllowAnonymous]
    [RoutePrefix("api/segments")]
    public class SegmentsController : ApiController
    {
        [Route("Get")]
        public IHttpActionResult Get()
        {
            //List<object> model = new List<object>();
            //model.Add(new
            //{
            //    Id = 1,
            //    Name = "Christopher Bermudez"
            //});

            //model.Add(new
            //{
            //    Id = 2,
            //    Name = "James Reid"
            //});

            List<OASC> model = new List<OASC>();
            model.Add(new OASC
            {
                SegmentID = 1,
                Name = "Chris",
                Code = "001"
            });

            model.Add(new OASC
            {
                SegmentID = 2,
                Name = "James",
                Code = "002"
            });

            //return Ok(JsonConvert.SerializeObject(model));
            return Ok(model);
        }

        [Route("Post")]
        public IHttpActionResult Post([FromBody] OASC model)
        {
            //List<object> model = new List<object>();
            //model.Add(new
            //{
            //    Id = 1,
            //    Name = "Christopher Bermudez"
            //});

            //model.Add(new
            //{
            //    Id = 2,
            //    Name = "James Reid"
            //});

            //List<OASC> model = new List<OASC>();
            //model.Add(new OASC
            //{
            //    SegmentID = 1,
            //    Name = "Chris",
            //    Code = "001"
            //});

            //model.Add(new OASC
            //{
            //    SegmentID = 2,
            //    Name = "James",
            //    Code = "002"
            //});

            //return Ok(JsonConvert.SerializeObject(model));
            return Ok();
        }
    }
}
