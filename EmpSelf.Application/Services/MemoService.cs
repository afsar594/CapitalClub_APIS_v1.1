using EmpSelf.Core.Domain;
using EmpSelf.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpSelf.Application.Services
{
    public class MemoService : IMemoService
    {
        private readonly STContext _context;
        public MemoService(STContext context)
        {
            _context = context;

        }

        public CommonResponse GetallMemo(int Empid)
        {
            return CommonResponse.Ok(_context.HrMemo.Where(x => x.EmpId == Empid ).OrderByDescending(c=>c.MemoDate).ToList());
        }

        public CommonResponse GetMemo(int Empid)
        {
            
            return CommonResponse.Ok(_context.HrMemo.Where(x=>x.EmpId == Empid && x.MemoDate > DateTime.Now).OrderBy(c => c.MemoDate).ToList());
        }
    }
}
