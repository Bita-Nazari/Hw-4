using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hw4.Services.Exception;


namespace Hw4.Services.Exception
{
   
    class NotValidNumberException : Exception
    {
        public NotValidNumberException() 
        {
            Console.WriteLine("its not in correct format");

        }
    }
}
