using EmpSelf.Core.Domain;
using EmpSelf.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpSelf.Application.Services
{
    public class ServiceRequestType : IServiceRequestType
    {
        private readonly STContext _context;
        public ServiceRequestType(STContext context)
        {
            _context = context;
        }
        public CommonResponse GetServiceType()
        {
            return CommonResponse.Ok(_context.HrServiceRequestType.ToList());
        }
    }
}
