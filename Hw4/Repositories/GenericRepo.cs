using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        public void Read(T item)
        {
            throw new NotImplementedException();
        }

        public void Create(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
