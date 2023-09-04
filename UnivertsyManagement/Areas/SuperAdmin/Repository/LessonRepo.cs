using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivertsyManagement.Models.Concrete;
using UnivertsyManagement.Models.Concrete.Connectiondb;

namespace UnivertsyManagement.Areas.SuperAdmin.Repository
{
    public class LessonRepo
    {
        Context context = new Context();

        // en cok alınan der, en cok kalınan ders toplam ders 
        public List<Lesson> ListLesson()
        {
            var list= context.lessons.ToList();
            return list;
        }

        public bool AddLesson(Lesson lesson)
        {
            try
            {
                context.lessons.Add(lesson);
                context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
               
            }
               
        }

        public bool BeInactiveLesson(int id,bool statu)
        {
            try
            {
                var value = FindLesson(id);
                value.IsActive = statu;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public Lesson FindLesson(int id)
        {
          return  context.lessons.Where(x=>x.LessonID==id).FirstOrDefault();

        }

        public bool EditLesson(Lesson lesson)
        {
            Lesson _lesson = new Lesson();
            try
            {
                _lesson.AcademicianID = lesson.AcademicianID;
                _lesson.Lesson_Code = lesson.Lesson_Code;
                _lesson.IsActive = lesson.IsActive;
                _lesson.SinifID = lesson.SinifID;
                _lesson.CrediofLessons = lesson.CrediofLessons;
                _lesson.Department_ID = lesson.Department_ID;
                _lesson.Name = lesson.Name;

            
                context.SaveChanges();

                return true;


            }
            catch (Exception)
            {
                return false;

            }

        }

        public List<Lesson> ListLessonActive()
        {
            var list = context.lessons.Where(x=>x.IsActive==true).ToList();
            return list;
        }

        public List<Lesson> ListLessonByClass(int id)
        {
            var list = context.lessons.Where(x => x.IsActive == true && x.Sinif.Level==id.ToString()).ToList();
            return list;
        }

        public int LessonCountActive()
        {
            return context.lessons.Count();

        }

        public int CountOfTakenLesson(string Lesson, string Period,string Year)
        {
            return context.Student_Lessons.Where(x => x.Lesson.Name == Lesson && x.IsActive==true && x.AcademicYear.Period==Period && x.AcademicYear.YearOfEducation==Year).Count();
        }

    }
}