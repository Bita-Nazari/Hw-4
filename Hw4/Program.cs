﻿using Chilkat;
using Hw4.Entities;
using System;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Collections;
using CsvHelper;
using System.Runtime.ExceptionServices;

namespace hw4
{
    class program
    {

        static void Main(string[] args)
        {



            string dataBase = "";
            Console.WriteLine("enter the num of persons that you want to add");
            int numpersons = Convert.ToInt32(Console.ReadLine());
            Person[] people = new Person[numpersons];





            for (int i = 0; i < numpersons; i++)
            {
                Console.WriteLine($"enter name of person[{(i + 1)}]");
                string name = Console.ReadLine();
             
                Console.WriteLine($"enter mobile of person[{(i + 1)}]");
                long mobile = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine($"enter birthday date of person[{(i + 1)}] and split with /");
                string birthdayDate = Console.ReadLine();
                int id = 1;
                for(int j = 1;  j < numpersons; j++) 
                {
                    id++;
                
                }
                Person person = new Person(id ,name , mobile, birthdayDate);
                people[i] = person;
            }
            Console.Clear();
            
            
            foreach (Person person in people)
            {
                var myPersonObjects = new List<Person>();
                Console.WriteLine($" person id is :  {person.id} person name is : {person.name} person mobile number is : {person.moblie} person birthday is :{person.birthdayDate}");
                string Path = "DataStorage.txt";
                File.WriteAllText(Path, person.name + " " + person.id + " " + person.moblie + " " + person.birthdayDate);
                String file = @"Database/person.csv";
                String separator = ",";
                using (var writer = new StreamWriter("filePersons.csv"))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(myPersonObjects);
                }

            }
            



            Console.ReadKey();
        

        }

    }
}
