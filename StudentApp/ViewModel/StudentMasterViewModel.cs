using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentApp.ViewModel
{
    public class StudentMasterViewModel
    {
        [Display(Name = "Student Name")]
        public string Name { get; set; }
        [Display(Name = "Class Name")]
        public string Class { get; set; }
        [Display(Name = "Roll Number")]
        public string RollNumber { get; set; }
        [Display(Name ="Exam")]
        public int ExamId { get; set; }
        [Display(Name = "Subject")]
        public int SubjectId { get; set; }
        public IEnumerable<SelectListItem> ListOfExams { get; set; }
        public IEnumerable<SelectListItem> ListOfSubject { get; set; }
        [Display(Name = "Total Marks")]
        public int TotalMarks { get; set; }
        [Display(Name = "Marks Obtained")]
        public int MarksObtained { get; set; }
        [Display(Name = "Percentage")]
        public decimal Percentage { get; set; }
    }
}