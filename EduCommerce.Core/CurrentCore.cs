using EduCommerce.Data;
using EduCommerce.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCommerce.Core
{
  public  class  CurrentCore:IRepositroy<Current>
    {
        public bool Delete(Current entity)
        {
            throw new NotImplementedException();
        }

        public DataTable getAll()
        {
            driver d = new driver();
            return d.getTable("select * from  [Current]");
        }

        public DataTable getByID(int Id)
        {
            driver d = new driver();
            return d.getTable("select * from  [Current] where  DealerID=@p1", Id);
        }

   

        public Current Insert(Current entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Current entity)
        {
            throw new NotImplementedException();
        }
    }
}
