using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApp.ViewModel
{
    public class StudentMarksViewModel
    {
        public int SubjectId { get; set; }
        public int TotalMarks { get; set; }
        public int ObtainedMarks { get; set; }
        public decimal Percentage { get; set; }
    }
}