﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApp.ViewModel
{
    public class StudentViewModel
    {
        public string StudentName { get; set; }
        public string ClassName { get; set; }
        public int ExamId { get; set; }
        public int RollNumber { get; set; }
        public List<StudentMarksViewModel>ListOfStudentMarks { get; set; }
    }
}