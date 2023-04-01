using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string ContactUsername { get; set; }
        public string CommentMail { get; set; }
        public string CommentSubject { get; set; }
        public string CommentMessage { get; set; }
        public DateTime ContactDate { get; set; }
        public bool ContactStatus { get; set; }


    }
}
