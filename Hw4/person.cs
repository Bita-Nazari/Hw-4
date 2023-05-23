using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    public class Person
    {
        public string name { get; set; }
        public int id { get; set; }
        public long moblie { get; set; }
        public string birthdayDate { get; set; }


        public Person(string name, int id, long mobile, string birthdayDate)
        {
            this.name = name;
            this.id = id;
            this.moblie = mobile;
            this.birthdayDate = birthdayDate;


        }
    }
}
