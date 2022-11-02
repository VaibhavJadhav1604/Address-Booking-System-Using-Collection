using System;
using System.Collections.Generic;

namespace AddContact
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int ZipCode;
        public long MobNumber;

        public Person(string FirstName, string LastName, string Address, string City, string State, int ZipCode, long MobNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
            this.MobNumber = MobNumber;
        }
    }
    public class Details
    {
        //creating list of type person class
        List<Person> p = new List<Person>();
        public void AddContact(string firstname,string lastname,string address,string city,string state,int zipcode,long mobnum)
        {
            //adding value in list by creating separate objects For each data
            p.Add(new Person(firstname, lastname, address, city, state, zipcode, mobnum));
        }
        public void Display()
        {
            foreach (var person in p)
            {
                Console.WriteLine(person.FirstName);
                Console.WriteLine(person.LastName);
                Console.WriteLine(person.Address);
                Console.WriteLine(person.City);
                Console.WriteLine(person.State);
                Console.WriteLine(person.ZipCode);
                Console.WriteLine(person.MobNumber);
                Console.WriteLine("\n");
            }
        }
    }
    public class ABS_Using_C2
    {
        static void Main(string[] args)
        {
            //creating object of Details class
            Details details = new Details();
            Console.Write("How many Contact You Have To Add:");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                //Accepting Details From User
                Console.WriteLine("Enter Details For "+i+" Contact");
                Console.Write("Enter First Name:");
                string firstname = Console.ReadLine();

                Console.Write("Enter Last Name:");
                string lastname = Console.ReadLine();

                Console.Write("Enter Address:");
                string address = Console.ReadLine();

                Console.Write("Enter City:");
                string city = Console.ReadLine();

                Console.Write("Enter State:");
                string state = Console.ReadLine();

                Console.Write("Enter ZipCode:");
                int zipcode = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Mobile Number:");
                long mobnum = Convert.ToInt64(Console.ReadLine());

                //Adding Details
                details.AddContact(firstname,lastname,address,city,state,zipcode,mobnum);
                Console.WriteLine("Contact Added");
                Console.WriteLine("\n");
            }
            Console.WriteLine("-----------------Contact Details Are-----------------");
            //Displaying Details
            details.Display();
        }
    }
}
