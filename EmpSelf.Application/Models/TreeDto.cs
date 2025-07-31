using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSelf.Application.Models
{
 public   class TreeDto
    {
        public TreeDto()
        {
            TreeMonths = new List<TreeMonth>();

        }
        public int Year { get; set; }
        public IList<TreeMonth> TreeMonths { get; set; }
    }

    public class TreeMonth
    {
        public TreeMonth()
        {
            TreeDay = new List<TreeDay>();

        }
        public int? Month { get; set; }
        public string? MonthName { get; set; }
        public IList<TreeDay>? TreeDay { get; set; }

    }
    public class TreeDay
    {
        public int? Day { get; set; }
        public  string? DayName { get; set; }
        public int? TimesheetID { get; set; }

    }
}
