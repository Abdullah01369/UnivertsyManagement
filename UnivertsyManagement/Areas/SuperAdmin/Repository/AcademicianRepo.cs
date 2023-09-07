using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivertsyManagement.Models.Concrete;
using UnivertsyManagement.Models.Concrete.Connectiondb;

namespace UnivertsyManagement.Areas.SuperAdmin.Repository
{
    public class AcademicianRepo
    {
        public Context context = new Context();
        public List<Academician> AcademicianList()
        {
            return context.academicians.ToList();


        }

        public Academician AcademicianById(int id)
        {

           return context.academicians.Where(x=>x.AcademicianID==id).FirstOrDefault();

        }
        public List<Academician> FindAcademicianListbyDepId(int id)
        {
            return context.academicians.Where(x=>x.DepartmentID==id).ToList();

        }
        public List<Academician> FindAcademicianListbyFacId(int id)
        {
            return context.academicians.Where(x => x.Department.FacultyId == id).ToList();

        }
        public string[] InfosAdminAcademician()
        {
            string[] liste = new string[4];

            liste[0] = context.academicians.Where(x => x.IsActive == true).Count().ToString(); 
            liste[1] = context.academicians.Where(x => x.Title.Name == "prof").Count().ToString(); 
            liste[2] = context.academicians.Where(x => x.Title.Name=="AG").Count().ToString(); 
            liste[3] = context.academicians.Count().ToString(); //toplam

            return liste;




        }

        public string AddAcademician(Academician  academician)
        {
            try
            {
                academician.AccessStatu = "1";
                academician.IsActive = true;

                context.academicians.Add(academician);
                context.SaveChanges();

               


                return "1";
            }
            catch (Exception)
            {
                return "0";
                throw;
            }


        }

        public string EditAcademician(int id, Academician  academician)
        {
            var _academician = FindAcademician(id);




           


            context.SaveChanges();
            return "1";


        }

        public Academician FindAcademician(int id)
        {


            var student = context.academicians.Where(x => x.AcademicianID == id).FirstOrDefault();
            return student;

        }

      


        public string DeleteAcademician(int id)
        {
            var _student = FindAcademician(id);



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
        public List<Title> TitleList()
        {
            return context.Titles.ToList();
        }
        public List<Academician> FindAcademicianWithFaculty(int id)
        {
            return context.academicians.Where(x => x.Department.FacultyId == id).ToList();

        }
        public List<Department> DepartmentsListByFacultyId(int id)
        {
            return context.departments.Where(x => x.FacultyId == id).ToList();

        }
        public List<Academician> FindAcademicianWithdDep(int depid)
        {
            return context.academicians.Where(x => x.DepartmentID == depid).ToList();
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
