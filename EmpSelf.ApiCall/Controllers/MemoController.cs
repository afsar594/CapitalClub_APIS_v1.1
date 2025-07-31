using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpSelf.ApiCall.Framework;
using EmpSelf.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpSelf.ApiCall.Controllers
{
    [Route("api/v1/memo")]
    [ApiController]
    public class MemoController : BaseController
    {
        private readonly IMemoService _memoService;
        public MemoController(IMemoService memoService)
        {
            _memoService = memoService;

        }
        [HttpGet("get/{empid}")]
        public IActionResult Getmemo(int empid)
        {
            return Response(_memoService.GetMemo(empid));
        }
        [HttpGet("getall/{empid}")]
        public IActionResult GetAllmemo(int empid)
        {
            return Response(_memoService.GetallMemo(empid));
        }

    }
}
