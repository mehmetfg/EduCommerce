using EduCommerce.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCommerce.Model;
namespace EduCommerce.Core
{
    public class DealersCore:IRepositroy<Dealers>
    {
        public bool Delete(Dealers entity)
        {
            throw new NotImplementedException();
        }

        public DataTable getAll()
        {
            driver d = new driver();
            return d.getTable("select * from Dealers");
        }

        public DataTable getByID(int Id)
        {
            throw new NotImplementedException();
        }

     

        public Dealers Insert(Dealers entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Dealers entity)
        {
            throw new NotImplementedException();
        }
    }
}
