using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CsvHelper.Configuration.Attributes;

namespace Hw4.Entities
{
    public class Person
    {
        
        public string name { get; set; }

        public int id { get; set; }

        public long moblie { get; set; }
      
        public string birthdayDate { get; set; }


        public Person(int id, string name, long mobile, string birthdayDate)
        {
           this.id = id;
            this.name = name;
            moblie = mobile;
            this.birthdayDate = birthdayDate;
        }
       
        
           

        
       
    }
}
