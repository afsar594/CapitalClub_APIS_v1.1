using EmpSelf.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Services
{
    public interface ICurrentInfoServices
    {
        CommonResponse GetCurrentTime();
    }
}
