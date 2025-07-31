using EmpSelf.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Models
{
    public class AuthResponse
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string UserPwd { get; set; }
        public string Token { get; set; }
        public long? workgroupid { get; set; }
        public byte[]? UserImg { get; set; }
        public string UserstaffName {get;set;}
        public string UserPassportNo { get; set; }
        public string UserDesignation { get; set; }
        public AuthResponse(HrUsers user, string token, byte[] uImg)
        {
            Id = user.UserId;
            Username = user.UserName;
            UserPwd = user.Passwd;
            workgroupid = user.WorkgroupId;
            Token = token;
            UserImg = uImg;
            UserstaffName = user.StaffName;
            UserPassportNo = user.PassportNo;
            UserDesignation = user.Designation;

        }
    }
}
