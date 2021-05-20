using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Business.Abstract
{
    public interface IBaseService<T>
    {
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        bool Validation(T entity);
    }
}
