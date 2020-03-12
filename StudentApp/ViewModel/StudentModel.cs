using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApp.ViewModel
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string ExamName { get; set; }
        public string ClassName { get; set; }
        public int RollNumber { get; set; } //string
    }
}