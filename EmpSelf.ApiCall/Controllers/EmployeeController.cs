using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpSelf.Application.Models;
using EmpSelf.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using EmpSelf.ApiCall.Framework;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmpSelf.ApiCall.Controllers
{
    //[Authorize]
    [Route("api/v1/user")]
    [ApiController]
    public class EmployeeController : BaseController
    {

        private readonly IEmployeeService _empService;
        public EmployeeController(IEmployeeService empService)
        {
            _empService = empService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] UserLoginDto model)
        {
            var response = _empService.CheckLogin(model);


            return Response(response);
        }


        [HttpGet]
        [Route("AuthCheck")]
        public IActionResult AuthCheck(/*[FromBody]UserLoginDto userdata*/ )    
        {
            UserLoginDto userdata = new UserLoginDto()
            {
                Password = "1234",
                Username = "admin"
            };
            var data=  Response(_empService.CheckLogin(userdata));
            return data;
        }

        [HttpGet]
        [Route("Updatepassword/{Uid}/{NewPwd}")]
        public IActionResult Update(int uid,  string newPwd)
        {

            return Response(_empService.UpdateUserPwd(uid,newPwd));
        }

        // GET: api/<EmployeeController>
        [HttpGet]
      /*  public IEnumerable<object> Get()
        {
        }*/

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
