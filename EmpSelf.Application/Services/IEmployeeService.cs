using EmpSelf.Application.Models;
using EmpSelf.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Services
{
  public  interface IEmployeeService
    {

        CommonResponse CheckLogin(UserLoginDto _Userdata);
        CommonResponse UpdateUserPwd(int Uid, string NewPwd);
    }
}
