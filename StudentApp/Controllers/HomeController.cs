using StudentApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentApp.Models;

namespace StudentApp.Controllers
{
    
    public class HomeController : Controller
    {
        StudentDBEntities objStudentDBEntities;
        public HomeController()
        {
            objStudentDBEntities = new StudentDBEntities();
        }
        // GET: Home
        public ActionResult Index()
        {
            StudentMasterViewModel objMasterViewModel = new StudentMasterViewModel();

            objMasterViewModel.ListOfExams = (from obj in objStudentDBEntities.Exams
                                              select new SelectListItem()
                                              {
                                                  Text = obj.ExamName,
                                                  Value=obj.ExamId.ToString()
                                              }).ToList();

            objMasterViewModel.ListOfSubject = (from obj in objStudentDBEntities.Subjects
                                              select new SelectListItem()
                                              {
                                                  Text = obj.SubjectName,
                                                  Value = obj.SubjectId.ToString()
                                              }).ToList();

            return View(objMasterViewModel);
        }

        [HttpPost]
        public ActionResult Index(StudentViewModel objStudentViewModel)
        {
            StudentMaster objStudentMaster = new StudentMaster()
            {
                Name = objStudentViewModel.StudentName,
                ClassName = objStudentViewModel.ClassName,
                ExamId = objStudentViewModel.ExamId,
                RollNumber = objStudentViewModel.RollNumber
            };
            objStudentDBEntities.StudentMasters.Add(objStudentMaster);
            objStudentDBEntities.SaveChanges();

            foreach(var item in objStudentViewModel.ListOfStudentMarks)
            {
                StudentDetail objStudentDetail = new StudentDetail()
                {
                    MarksObtained = item.ObtainedMarks,
                    Percentage = Convert.ToInt32(item.Percentage),     ///to check conversion
                    StudentId = objStudentMaster.StudentId,
                    TotalMarks = item.TotalMarks,
                    SubjectId = item.SubjectId

                };
                objStudentDBEntities.StudentDetails.Add(objStudentDetail);
                objStudentDBEntities.SaveChanges();
            }


            return Json(new { message = "Data successfully added", status = true}, JsonRequestBehavior.AllowGet);
        }
    }
}