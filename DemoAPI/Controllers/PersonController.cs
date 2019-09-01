using DemoApplication.Interfaces.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    [RoutePrefix("Person")]
    public class PersonController : ApiController
    {
        IGetPersonInteractor usecase;

        public PersonController(IGetPersonInteractor _res)
        {
            usecase = _res;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetPersons()
        {
            return Ok(usecase.Hanlde(""));
        }
    }
}
