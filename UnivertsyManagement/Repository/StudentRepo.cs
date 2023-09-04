using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivertsyManagement.Models;
using UnivertsyManagement.Models.Concrete;
using UnivertsyManagement.Models.Concrete.Connectiondb;

namespace UnivertsyManagement.Repository
{
    public class StudentRepo
    {
        public Context context = new Context();
        public List<Student> StudentList()
        {
            return context.students.ToList();


        }
        public Student StudentLogin(StudentLoginViewModel student)
        {
            var studentControl = context.students.Where(x => x.Student_No == student.Student_No && x.Password == student.Password).FirstOrDefault();

            return studentControl;
 

        }

        public string AddStudent(Student student)
        {


            using (Context context = new Context())
            {

                if (student.Degree.ToString().Length < 10)
                {
                    string value = "00";
                    student.Student_No = "10" + student.Department.FacultyId.ToString() + student.Department.DepartmentID.ToString() + value + student.Degree.ToString();
                    student.GANO = 0;
                    student.Sinif.SinifID = 1;
                    student.IsActive = true;
                    student.Graduation_Status = false;



                }
                context.students.Add(student);
                context.SaveChanges();


                return "1";
            }

        }

        public string EditStudent(int id, Student student)
        {
            var _student = FindStudent(id);

          
            

                _student.E_Mail = student.E_Mail;
                _student.Password = student.Password;



                context.SaveChanges();
                return "1";
            

        }

        public Student FindStudent(int id)
        {
           
            
                var student = context.students.Where(x => x.StudentID == id).FirstOrDefault();
                return student;
            
        }
        public Student FindStudentWithNo(string No)
        {
       
            
                var student = context.students.Where(x => x.Student_No == No).FirstOrDefault();
                return student;
            
        }

        public List<Student> FindStudentWithdDep(int depid)
        {
         return  context.students.Where(x => x.DepartmentID == depid).ToList();
        }

        public string DeleteStudent(int id)
        {
            var _student = FindStudent(id);

            using (Context context = new Context())
            {
                _student.IsActive = false;

                return "1";
            }
        }
    }
}