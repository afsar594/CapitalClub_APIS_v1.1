using EmpSelf.Application.Models;
using EmpSelf.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Services
{
    public class CurrentinfoServices : ICurrentInfoServices
    {
        public CommonResponse GetCurrentTime()
        {
            CurrentInfo Curtime = new CurrentInfo()
            {
                Curtime = DateTime.Now
            };
            return CommonResponse.Ok(Curtime);
        }
    }
}
