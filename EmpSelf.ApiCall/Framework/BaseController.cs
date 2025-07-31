using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpSelf.Shared.Domain;
using Microsoft.AspNetCore.Mvc;

namespace EmpSelf.ApiCall.Framework
{
    public class BaseController : Controller
    {
        protected new IActionResult Response(CommonResponse response)
        {
            var returnResult = response.IsValid ? response.Data : new { Error = response.Exception.Message };
            return new ObjectResult(returnResult) { StatusCode = response.HttpCode };
        }
    }
}
