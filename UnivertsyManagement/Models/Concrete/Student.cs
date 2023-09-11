using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace UnivertsyManagement.Models.Concrete
{

    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Student_No { get; set; }
        public string Password { get; set; }


        public int? CityID { get; set; }
        public virtual City City { get; set; } 


        public int? GenderID { get; set; }
        public virtual Gender Gender { get; set; }

        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        public string E_Mail { get; set; }
        public string TC { get; set; }
        public bool Graduation_Status { get; set; }
        public bool IsActive { get; set; }
        public float GANO { get; set; }
        public string PhotoBase64Text { get; set; }
        public int Degree { get; set; }

        public int? SinifID { get; set; }
        public virtual Sinif Sinif { get; set; }

       

        public int? ConsultantID { get; set; }
        public virtual Consultant Consultant { get; set; }

       
        public int? DepartmentID { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Student_Lesson> Student_Lessons { get; set; } 
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<LessonStuationForGradudation>  LessonStuationForGradudations { get; set; }
    }
}