/*
 * samuel.w2@schule.koeln 2020
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PersonNoOO
{
    class Program
    {
        static void Main(string[] args) {
            List<Person> personList = new List<Person>();
            Console.Title = "Person No OO";
            Console.WriteLine("\n******* " + Console.Title + " ********");

            personList = Load();

            if (personList.Count == 0) {
                Person person = new Person("Irma", "Iller", "0179 987654321");
                personList.Add(person);

                Person person2 = new Person("Hugo", "Heller", "+49 (0)221 123456");
                personList.Add(person2);
            }

            Display(personList);
    
            Store(personList);

            Console.Write("\nFertig. ");
            Console.ReadLine();
        }

        static void Display(List<Person> personList)
        {
            foreach (Person person in personList)
            {
                person.Display();
            }
        }

        private static List<Person> Load()
        {
            // To do: load persons from CSV-text file
            List<Person> personList = new List<Person>();
            try
            {
                using (StreamReader reader = new StreamReader(@"..\..\..\output.csv", true))
                {
                    while (!reader.EndOfStream)
                    {
                        personList.Add(new Person(reader));
                    }
                }
            }
            catch (Exception e)
            {
                if (e is FileNotFoundException)
                {
                    Console.WriteLine("Datei nicht gefunden!");
                }
                else
                {
                    Console.WriteLine(e);
                }
            }

            return personList;
        }

        private static void Store(List<Person> personList)
        {
            // To do: store persons to text file using CSV-format
            using (StreamWriter writer = new StreamWriter(@"..\..\..\output.csv", false, new UTF8Encoding(true)))
            {
                foreach (Person person in personList)
                {
                    person.Store(writer);
                }
            }
        }
    }
}
