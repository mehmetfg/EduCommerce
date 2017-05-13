using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCommerce.Model
{
   public  class Students:BaseModel
    {
        //*, DealerID, StudentName, TCNumber, StudentUser, StudentPass, BornDate, Gender, Email, Phone, EduStatus, 
        //Adress, Status, EDate, Language, StudentLoginDate, StudentLoginIP, StartDate, FinishDate, Document, GKOD *//
        public int DealerID { get; set; }
        public string StudentName { get; set; }
        public string TCNumber { get; set; }
        public string StudentUser { get; set; }
        public string StudentPass { get; set; }
        public DateTime BornDate { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }
        public string EduStatus { get; set; }
        public string Adress { get; set; }
        public bool Status { get; set; }
        public DateTime EDate { get; set; }
        public string Language { get; set; }
        public DateTime StudentLoginDate { get; set; }
        public string StudentLoginIP { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public bool Document { get; set; }
        public string GKOD { get; set; }
    } 
    
         
}
