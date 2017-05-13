using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCommerce.Model
{
    public class Permissions:BaseModel
    {

        public int Code { get; set; }
        public string Name { get; set; }
        public int DealerID { get; set; }
    }
    //, , 
}
