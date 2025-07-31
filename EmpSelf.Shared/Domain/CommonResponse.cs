using EmpSelf.Shared.Exceptions;
using System;

namespace EmpSelf.Shared.Domain{
    public class CommonResponse{

        public CommonResponse()
        {
            this.HttpCode= 200;
        }
            public CommonResponse(int httpCode, object data)
        {
            this.HttpCode = httpCode;
            this.Data = data;
        }
        public bool IsValid => Exception == null;
        public CommonException Exception { get; set; }
        public int HttpCode { get; set; }
        public object Data { get; set; }
        public static CommonResponse Ok(object resource = null) {return new CommonResponse (200,resource); }
        public static CommonResponse Created(object resource){ return new CommonResponse(201, resource); }
        public static CommonResponse Error(object resource=null ) { return new CommonResponse(500, resource); }

       
    }
}