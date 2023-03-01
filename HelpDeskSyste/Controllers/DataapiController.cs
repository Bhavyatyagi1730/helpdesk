using HelpDeskSyste.Models.Database;
using Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelpDeskSyste.Controllers
{
    public class DataapiController : ApiController
    {

        Models.Database.ApidataEntities db = new Models.Database.ApidataEntities();

        [System.Web.Http.HttpGet]  
        public IHttpActionResult Action()
        {
            List<Models.Database.Roletable> obj = db.Roletables.ToList();

            return Ok(obj);
        }
    }
}
