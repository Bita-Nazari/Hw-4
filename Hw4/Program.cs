using Hw4;
using System;
using System.ComponentModel;

namespace hw4 
{
class program
{   
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num of persons that you want to add");
            int numpersons = Convert.ToInt32(Console.ReadLine());
            Person[] people = new Person[numpersons];
            for (int i = 0; i < numpersons; i++)
            {
                Console.WriteLine($"enter name of person[{(i + 1)}]");
                string name = Console.ReadLine();
                Console.WriteLine($"enter id of person[{(i + 1)}]");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"enter mobile of person[{(i + 1)}]");
                long mobile = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine($"enter birthday date of person[{(i + 1)}] and split with /");
                string birthdayDate = Console.ReadLine();


                Person person = new Person(name, id, mobile, birthdayDate);
                people[i] = person;
            }
            Console.Clear();

            foreach (Person person in people)
            {
                Console.WriteLine($" person name is : {person.name} prson  {person.id}  {person.moblie} , {person.birthdayDate}");

            }

            Console.ReadKey();


        }

    }
}
