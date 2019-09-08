using DemoApplication.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    [RoutePrefix("api/customer")]
    public class CustomerController : ApiController
    {
        private readonly ICustomerRespository _res;
        public CustomerController(ICustomerRespository rep)
        {
            _res = rep;
        }
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetPersons()
        {
            return Ok(_res.GetAllEntity());
        }
    }
}
