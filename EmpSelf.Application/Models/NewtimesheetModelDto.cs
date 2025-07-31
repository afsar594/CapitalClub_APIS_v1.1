using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Models
{
    public class Root
    {
        //public string[]> Result { get; set; }
    }
    public   class NewtimesheetModelDto
    {
        public DateTime TimesheetDate { get; set; }
        public int empID { get; set; }
        public string[][] TimesheetData { get; set; }
    }
    public class TimesheetData
    {
        public TimesheetDataProject TimesheetDataProject { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Description { get; set; }

    }
    public class TimesheetDataProject
    {
        public string  ProjectName { get; set; }
    }
}
