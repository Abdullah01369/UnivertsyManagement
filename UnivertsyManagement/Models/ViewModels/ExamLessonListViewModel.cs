using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivertsyManagement.Models.Concrete;

namespace UnivertsyManagement.Models.ViewModels
{
    public class ExamLessonListViewModel
    {

        
 

        public double? MidtermExam_Score { get; set; }
        public DateTime datemid { get; set; }

        public bool IsChangeableMidterm { get; set; }
        public bool IsTakenMidterm { get; set; }

        public double? FinalExam_Score { get; set; }
        public DateTime datefinal { get; set; }

        public bool IsChangeableFinal { get; set; }
        public bool IsTakenFinal { get; set; }

        public double? ButExam_Score { get; set; }
        public DateTime datebut { get; set; }
       
        public bool IsChangeableBut { get; set; }
        public bool CanTakeBut { get; set; }
        public bool IsTakenBut { get; set; }


        public string Flagabc { get; set; }
        
        public bool IsConstant { get; set; }
        public bool IsPassed { get; set; }
        public double Score { get; set; }


        public string LessonName { get; set; }

        public string LessonCode { get; set; }







    }
}