using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace UnivertsyManagement.Models.Concrete
{
    public class Exam
    {
        [Key]
        public int ExamID { get; set; }

        public double? MidtermExam_Score { get; set; }
        public DateTime ExamDateDeclareMidterm { get; set; }
        public bool IsChangeableMidterm { get; set; }
        public bool IsTakenMidterm { get; set; }

        public double? FinalExam_Score { get; set; }
        public DateTime ExamDateDeclareFinal { get; set; }
        public bool IsChangeableFinal { get; set; }
        public bool IsTakenFinal { get; set; }

        public double? ButExam_Score { get; set; }
        public DateTime ExamDateDeclareBut { get; set; }
        public bool IsChangeableBut { get; set; }
        public bool CanTakeBut { get; set; }
        public bool IsTakenBut { get; set; }

        public int FlagModelID { get; set; }
        public virtual FlagModel FlagAbc { get; set; }

        public bool IsConstant { get; set; }
        public bool IsPassed { get; set; }
        public double Score { get; set; }

       
        public int? LessonID { get; set; }

        public virtual Lesson Lesson { get; set; }

       
        public int? Student_ID { get; set; }
 
        public virtual Student Student { get; set; }

    
        public int? Academician_ID { get; set; }

        public virtual Academician Academician { get; set; }

    
        public int? AcademicYear_ID { get; set; }

        public virtual AcademicYear AcademicYear { get; set; }
    }
}