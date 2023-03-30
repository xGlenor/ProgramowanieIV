using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Repositories
{
    interface IRepository<T>
    {
        IEnumerable<T> All();
        T Get(int id);

        void Insert(T t);
        void Update(T t);

        void Delete(int id);
    }
}
