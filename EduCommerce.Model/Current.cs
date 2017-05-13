using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCommerce.Model
{
    public class Current:BaseModel
    {
        //DealerID, StudentID, Type, Class, Price, Quantity, Status, CreateDate
        public int DealerID { get; set; }
        public int StudentID { get; set; }
        public int Type { get; set; }
        public int Class { get; set; }

        public int Price { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
