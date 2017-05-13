using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCommerce.Model
{
    public class Educations:BaseModel
    {
        //ID, Category, Name, Price, Time, University
        public int Category { get; set; }
        public string Name { get; set; }
        public Double Price { get; set; }
        public DateTime Time { get; set; }
        public string  University { get; set; }
    }
}
