using Hw4.Entities;
using Hw4.Services.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4.Repositories
{
    public class GenericRepo : IGenericRepo
    {
       
        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Create(Person person)
        {
         
           
        }

       

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }

        public void Delete(Person person)
        {
         
        }
        public List<Person> GetAllPerson()
        {
            throw new NotImplementedException();
        }


        
    }
}
