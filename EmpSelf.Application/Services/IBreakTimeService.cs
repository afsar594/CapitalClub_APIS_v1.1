using EmpSelf.Application.Models;
using EmpSelf.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Services
{
  public  interface IBreakTimeService
    {
        CommonResponse UpdateBreakTime(NewBreakiTimeDto BreakTimeDet);
        CommonResponse GetBreakTime(long empid);

    }
}
