using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Models
{
    public class CheckINDto1
    {
        public  IFormFile file { get; set; }
        public long ProjectID { get; set; }
        public string Remarks { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string LocationName { get; set; }
        public bool punchMode { get; set; }
        public int empId { get; set; }
        public string? punchdate { get; set; }


    }
    //public   class CheckINDto
    //{
    //    public long EmpID { get; set; }
    //    public int CheckStatus { get; set; }

    //    public Coordinates Coordinates { get; set; }
    //    public string  Location { get; set; }
    //    public string Comment { get; set; }
    //    public byte[] File { get; set; }
    //    public string filepath { get; set; }

    //}
    //public class Coordinates
    //{
    //    public float Latitude { get; set; }
    //    public float Longitude { get; set; }
    //}
}
