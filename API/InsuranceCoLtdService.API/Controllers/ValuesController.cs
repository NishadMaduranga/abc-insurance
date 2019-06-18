using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsuranceCoLtdService.Core.ServiceContracts;
using InsuranceCoLtdService.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceCoLtdService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        private  IInsuarancePolicyProcessServices _service { get; set; }
        public ValuesController(IInsuarancePolicyProcessServices service)
        {
            this._service = service;
        }
   
        [HttpGet]
        // GET api/values/
        public JsonResult Get()
        {
            var policies = _service.GetAllPolicies();
            return Json(policies);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var policy = _service.GetPolicy(id);
            return Json(policy);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
