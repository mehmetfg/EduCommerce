using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCommerce.Model;
using System.Data;

namespace EduCommerce.Data
{
    public interface IRepositroy<TEntity> where TEntity:BaseModel
    {
        DataTable getAll();
        DataTable getByID(int Id);
        TEntity Insert(TEntity entity);
        void Update(TEntity entity);
        bool Delete(TEntity entity);
    }
}
