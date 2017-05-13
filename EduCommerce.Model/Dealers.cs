using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCommerce.Model
{
    public  class Dealers:BaseModel
    {
        // , , , , , , , , 
        //, , , , , , , , , , , , , , , , , , 

        public int UpDealer { get; set; }
        public string DealerType { get; set; }
        public int DealerName { get; set; }
        public string DealerUser { get; set; }
        public string DealerPass { get; set; }
        public int DealerAuthority { get; set; }
        public string DealerPhone { get; set; }
        public string DealerFax { get; set; }
        public string DealerMail { get; set; }
        public string DealerAddress { get; set; }
        public string IBAN { get; set; }
        public string BankName { get; set; }
        public string AccountName { get; set; }

        public string TaxNo { get; set; }
        public int CountryID { get; set; }
        public int CityID { get; set; }
        public int DealerLanguage { get; set; }
        public string VLanguage { get; set; }
        public bool Status { get; set; }
        public string DealerLoginIP { get; set; }
        public string DealerPicture { get; set; }
        public string GKOD { get; set; }
        public string WebSite { get; set; }
        public string MailTo { get; set; }
        public string Domain { get; set; }
        public string Logo { get; set; }
        public string Permissions { get; set; }
        public int Percentage { get; set; }
      

    }
}
