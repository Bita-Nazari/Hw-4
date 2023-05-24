using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4.Repositories
{
    public interface IGenericRepo<T> where T : class
    {
        List<T> GetAll();
        void Create(T item);
        void Read(T item);
        void Delete(T item);
        void Update(T item);


    }
}
