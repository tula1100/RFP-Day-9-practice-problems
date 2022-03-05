using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace address_uc_1
{
    public class Address
    {
        public string firstName, lastName, address, city, state, zip, phoneNumber, email;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Address a = new Address();
            System.Collections.ArrayList addbook = new System.Collections.ArrayList();
            Console.WriteLine("Enter First Name ");
            a.firstName = Convert.ToString(Console.ReadLine());
            addbook.Add(a.firstName);
            Console.WriteLine("Enter Last Name");
            a.lastName = Convert.ToString(Console.ReadLine());
            addbook.Add(a.lastName);
            Console.WriteLine("Enter Address ");
            a.address = Convert.ToString(Console.ReadLine());
            addbook.Add(a.address);
            Console.WriteLine("Enter city");
            a.city = Convert.ToString(Console.ReadLine());
            addbook.Add(a.city);
            Console.WriteLine("Enter state");
            a.state = Convert.ToString(Console.ReadLine());
            addbook.Add(a.state);
            Console.WriteLine("Enter zip");
            a.zip = Convert.ToString(Console.ReadLine());
            addbook.Add(a.zip);
            Console.WriteLine("Enter Phone Number");
            a.phoneNumber = Convert.ToString(Console.ReadLine());
            addbook.Add(a.phoneNumber);
            Console.WriteLine("Enter Email");
            a.email = Convert.ToString(Console.ReadLine());
            addbook.Add(a.email);

            Console.WriteLine("\nGiven Detail Are : \n");
            Console.WriteLine("First Name = " + addbook[0]);
            Console.WriteLine("Lastt Name = " + addbook[1]);
            Console.WriteLine("Address = " + addbook[2]);
            Console.WriteLine("City = " + addbook[3]);
            Console.WriteLine("State = " + addbook[4]);
            Console.WriteLine("Zip = " + addbook[5]);
            Console.WriteLine("Phone Number = " + addbook[6]);
            Console.WriteLine("Email = " + addbook[7]);
        }
    }
}
