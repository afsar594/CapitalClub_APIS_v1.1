using EmpSelf.Application.Helpers;
using EmpSelf.Application.Models;
using EmpSelf.Core.Domain;
using EmpSelf.Shared.Domain;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace EmpSelf.Application.Services
{
    public class EmployeeService : IEmployeeService
    {


        private readonly STContext _context;
        private readonly AppSettings _appSettings;

        public EmployeeService(STContext context, IOptions<AppSettings> appSettings)
        {
            _context = context;
            _appSettings = appSettings.Value;

        }

        public CommonResponse UpdateUserPwd(int Uid, string NewPwd)
        {
            try
            {
                var data = _context.HrUsers.Where(x => x.UserId == Uid).FirstOrDefault();
                if (data != null)
                {
                    data.Passwd = NewPwd;
                    this._context.HrUsers.Update(data);
                    this._context.SaveChanges();
                    return CommonResponse.Created(data);
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //return CommonResponse.Error();
            }
            return CommonResponse.Error();
        }

        public CommonResponse CheckLogin(UserLoginDto _Userdata)
        {
            try
            {
                var user = _context.HrUsers.Where(x => x.UserName == _Userdata.Username && x.Passwd == _Userdata.Password).FirstOrDefault();
                if (user == null) return CommonResponse.Error();
                byte[] uImg = null;
                // authentication successful so generate jwt token
                var token = generateJwtToken(user);

                var uImgN = _context.HrStaffMaster.Where(c => c.StaffId == user.UserId).FirstOrDefault();
                if(uImgN != null)
                {
                     uImg =  uImgN.StaffPhoto;
                }

                return CommonResponse.Ok(new AuthResponse(user, token, uImg));
            }
            catch (Exception ex)
            {
                return CommonResponse.Error();
            }

        }

        private string generateJwtToken(HrUsers user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
