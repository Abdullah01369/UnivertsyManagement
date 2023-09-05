using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivertsyManagement.Models;
using UnivertsyManagement.Models.Concrete;
using UnivertsyManagement.Models.Concrete.Connectiondb;

namespace UnivertsyManagement.Areas.SuperAdmin.Repository
{
    public class StudentRepo
    {
        public Context context = new Context();
        public List<Student> StudentList()
        {
            return context.students.ToList();


        }

        public string[] InfosAdminStudent()
        {
            string[] liste = new string[4];

            liste[0] = context.students.Where(x => x.Graduation_Status == false).Count().ToString(); // aktif ogrenci
            liste[1] = context.students.Where(x => x.Graduation_Status == true).Count().ToString(); // mezun ogrenci
            liste[2] = context.students.Where(x => x.Sinif.Level == "1").Count().ToString(); // yeni kayıt ogrenci
            liste[3] = context.students.Count().ToString(); //toplam

            return liste;




        }

        public string AddStudent(Student student)
        {
            try
            {
                student.GANO = 0;
                student.IsActive = true;
                student.Graduation_Status = false;
                var depid = student.DepartmentID;

                //if (student.DepartmentID == 3)
                //{
                //    student.ConsultantID = 1;

                //}

                var list = FindDepartmentNum((int)student.DepartmentID);

                student.Student_No = $"{list[0]:D3}{list[1]:D3}00{student.Degree:D3}";

                student.Department = null;
                student.DepartmentID = depid;


                context.students.Add(student);
                context.SaveChanges();


                return "1";
            }
            catch (Exception)
            {
                return "0";
                throw;
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


        public string DeleteStudent(int id)
        {
            var _student = FindStudent(id);



            _student.IsActive = false;

            return "1";

        }

        public List<City> CityList()
        {
            return context.Cities.ToList();
        }

        public List<Gender> GenderList()
        {
            return context.Genders.ToList();
        }
        public List<Sinif> SinifList()
        {
            return context.Sinif.ToList();
        }
        public List<Faculty> FacultyList()
        {
            return context.faculties.ToList();
        }

        public List<Student> FindStudentWithFaculty(int id)
        {
            return context.students.Where(x => x.Department.FacultyId == id).ToList();

        }
        public List<Department> DepartmentsListByFacultyId(int id)
        {
            return context.departments.Where(x => x.FacultyId == id).ToList();

        }
        public List<Student> FindStudentWithdDep(int depid)
        {
            return context.students.Where(x => x.DepartmentID == depid).ToList();
        }
        public string[] FindDepartmentNum(int id)
        {
            string[] list = new string[2];
            var depnum = context.departments.Where(x => x.DepartmentID == id).FirstOrDefault().DepartmentNum;
            var facnum = context.departments.Where(x => x.DepartmentID == id).FirstOrDefault().Faculty.FacultyNum;
            facnum = "321";

            list[0] = depnum;
            list[1] = facnum;

            return list;


        }
    }
}