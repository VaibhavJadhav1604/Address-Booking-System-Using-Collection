using System;
using System.Collections.Generic;

namespace EditContact
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
        public void AddContact(string firstname, string lastname, string address, string city, string state, int zipcode, long mobnum)
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
        //editing contact of particular first name
        public void EditContact(string fname)
        {
            foreach(var data in p)
            {
                if(data.FirstName==fname)
                {
                    Console.WriteLine("1.First Name" + "\n" + "2.Last Name" + "\n" + "3.Address" + "\n" + "4.City" + "\n" + "5.State" + "\n" + "6.ZipCode" + "\n" + "7.Mobile Number");
                    Console.Write("Enter The Option You Want To Edit Of Your Contact:");
                    int opt = Convert.ToInt32(Console.ReadLine());
                    switch (opt)
                    {
                        case 1:
                            Console.Write("Enter First Name:");
                            string finame = Console.ReadLine();
                            data.FirstName = finame;
                            break;

                        case 2:
                            Console.Write("Enter Last Name:");
                            string lname = Console.ReadLine();
                            data.LastName = lname;
                            break;

                        case 3:
                            Console.Write("Enter Address:");
                            string addr = Console.ReadLine();
                            data.Address = addr;
                            break;

                        case 4:
                            Console.Write("Enter City:");
                            string cty = Console.ReadLine();
                            data.City = cty;
                            break;

                        case 5:
                            Console.Write("Enter State:");
                            string stt = Console.ReadLine();
                            data.State = stt;
                            break;

                        case 6:
                            Console.Write("Enter ZipCode:");
                            int zcode = Convert.ToInt32(Console.ReadLine());
                            data.ZipCode = zcode;
                            break;

                        case 7:
                            Console.Write("Enter Mobile Number:");
                            long mnum = Convert.ToInt64(Console.ReadLine());
                            data.MobNumber = mnum;
                            break;
                    }
                    Console.WriteLine("Contact Edited SuccessFully");
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("No Contact Found Of Name:"+ fname);
                    break;
                }
            }
        }
    }
    public class ABS_Using_C3
    {
        static void Main(string[] args)
        {
            //creating object of Details class
            Details details = new Details();
            Console.Write("How many Contact You Have To Add:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                //Accepting Details From User
                Console.WriteLine("Enter Details For " + i + " Contact");
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
                details.AddContact(firstname, lastname, address, city, state, zipcode, mobnum);
                Console.WriteLine("Contact Added");
                Console.WriteLine("\n");
            }
            Console.WriteLine("-----------------Contact Details Are-----------------");
            //Displaying Details
            details.Display();
            Console.Write("Enter The First Name Of The Contact You Want To Edit:");
            string fname = Console.ReadLine();
            details.EditContact(fname);
            Console.WriteLine("-----------------Contact Details Are-----------------");
            details.Display();
        }
    }
}
