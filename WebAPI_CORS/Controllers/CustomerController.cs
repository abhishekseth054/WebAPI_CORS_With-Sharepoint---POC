using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Test.DLL;
using WebAPI_Test.Entity;
using System.Web.Http.Cors;


namespace WebAPI_Test.Controllers
{
    [EnableCors(origins: "https://tenant.sharepoint.com", headers: "*", methods: "*")]
    public class CustomerController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<Customer> custDetails =  SampleData.GetSmapleDataFromCustomerTable();
            return Ok(custDetails);
        }
    }
}
