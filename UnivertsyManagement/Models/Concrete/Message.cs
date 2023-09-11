using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Models.Concrete
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public string MessageTitle { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageDate { get; set; }

        public string MessageTime { get; set; }

        public string SenderMail{ get; set; }
        public string ReceiverMail{ get; set; }
        







    }
}