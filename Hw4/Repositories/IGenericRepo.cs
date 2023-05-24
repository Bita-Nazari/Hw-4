using Hw4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4.Repositories
{
    public interface IGenericRepo
    {
     
        void Create(Person person);
        void Read();
        void Delete(Person person);
        void Update(Person person);
        List<Person> GetAllPerson();


    }
}
