using EmpSelf.Application.Models;
using EmpSelf.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Services
{
   public interface IAttendanceService
    {
        CommonResponse GetCurrentStatus(long Empid);
        CommonResponse CHeckIN(CheckINDto1 CheckInData);


    }
}
