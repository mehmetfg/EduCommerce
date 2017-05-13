using System;
using EduCommerce.Model;
using EduCommerce.Data;
using System.Data;

namespace EduCommerce.Core
{

    public class EducationCore : IRepositroy<Educations>
    {
        
        public bool Delete(Educations entity)
        {
            
            throw new NotImplementedException();
        }

        public DataTable getAll()
        {
            driver d = new driver();
            return d.getTable("select * from Educations ");
            
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
