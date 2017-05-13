using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCommerce.Data;
using EduCommerce.Model;

namespace EduCommerce.Core
{
    public class StudentCore : IRepositroy<Educations>
    {
        Students std = new Students();
      
        public bool Delete(Educations entity)
        {
            throw new NotImplementedException();
        }

        public DataTable getAll()
        {
            driver d = new driver();
            return d.getTable("select * from Students");
           
        }

        public DataTable getByID(int Id)
        {
            throw new NotImplementedException();
        }

        public Educations Insert(Educations entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Educations entity)
        {
            throw new NotImplementedException();
        }
    }
}
