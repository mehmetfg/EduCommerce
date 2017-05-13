using EduCommerce.Data;
using EduCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EduCommerce.Core
{
    public class PemissionsCore : IRepositroy<Permissions>
    {
        public bool Delete(Permissions entity)
        {
            throw new NotImplementedException();
        }

        public DataTable getAll()
        {
            driver d = new driver();
            return d.getTable("select * from Permissions");
        }

        public DataTable getByID(int Id)
        {
            throw new NotImplementedException();
        }

        public Permissions Insert(Permissions entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Permissions entity)
        {
            throw new NotImplementedException();
        }
    }
}
