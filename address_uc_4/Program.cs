using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace address_uc_4
{
    public class Address
    {
        public string firstName, firstName2, lastName, lastName2, address, address2, city, city2, state, state2, zip, zip2, phoneNo, phoneNo2, email, email2;
        public int value;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Address a = new Address();
            ArrayList addbook = new ArrayList();
            choice();
            void choice()
            {
                Console.WriteLine("\nEnter 1 to Add Details");
                Console.WriteLine("Enter 2 to Add 2nd Person Details");
                Console.WriteLine("Enter 3 to Edit Existing Detail");
                Console.WriteLine("Enter 4 to Delete Existing Detials");
                a.value = Convert.ToInt32(Console.ReadLine());
                switch (a.value)
                {
                    case 1:

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
                        a.phoneNo = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.phoneNo);
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
                        break;
                    case 2:
                        Console.WriteLine("Enter First Name ");
                        a.firstName2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.firstName2);
                        Console.WriteLine("Enter Last Name");
                        a.lastName2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.lastName2);
                        Console.WriteLine("Enter Address ");
                        a.address2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.address2);
                        Console.WriteLine("Enter city");
                        a.city = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.city2);
                        Console.WriteLine("Enter state");
                        a.state2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.state2);
                        Console.WriteLine("Enter zip");
                        a.zip2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.zip2);
                        Console.WriteLine("Enter Phone Number");
                        a.phoneNo2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.phoneNo2);
                        Console.WriteLine("Enter Email");
                        a.email2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.email2);

                        Console.WriteLine("\nGiven new Details Are : \n");
                        Console.WriteLine("First Name = " + addbook[8]);
                        Console.WriteLine("Lastt Name = " + addbook[9]);
                        Console.WriteLine("Address = " + addbook[10]);
                        Console.WriteLine("City = " + addbook[11]);
                        Console.WriteLine("State = " + addbook[12]);
                        Console.WriteLine("Zip = " + addbook[13]);
                        Console.WriteLine("Phone Number = " + addbook[14]);
                        Console.WriteLine("Email = " + addbook[15]);
                        break;
                    case 3:
                        Console.WriteLine("Enter the First Name and Last Name of that Person");
                        string fname = Convert.ToString(Console.ReadLine());
                        string lname = Convert.ToString(Console.ReadLine());

                        if ((a.firstName == fname) && (a.lastName == lname))
                        {
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
                            a.phoneNo = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.phoneNo);
                            Console.WriteLine("Enter Email");
                            a.email = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.email);
                            Console.WriteLine("\nGiven new Details Are : \n");
                            Console.WriteLine("First Name = " + addbook[8]);
                            Console.WriteLine("Lastt Name = " + addbook[9]);
                            Console.WriteLine("Address = " + addbook[10]);
                            Console.WriteLine("City = " + addbook[11]);
                            Console.WriteLine("State = " + addbook[12]);
                            Console.WriteLine("Zip = " + addbook[13]);
                            Console.WriteLine("Phone Number = " + addbook[14]);
                            Console.WriteLine("Email = " + addbook[15]);
                        }
                        else if ((a.firstName2 == fname) && (a.lastName2 == lname))
                        {
                            Console.WriteLine("Enter First Name ");
                            a.firstName2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.firstName2);
                            Console.WriteLine("Enter Last Name");
                            a.lastName2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.lastName2);
                            Console.WriteLine("Enter Address ");
                            a.address2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.address2);
                            Console.WriteLine("Enter city");
                            a.city = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.city2);
                            Console.WriteLine("Enter state");
                            a.state2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.state2);
                            Console.WriteLine("Enter zip");
                            a.zip2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.zip2);
                            Console.WriteLine("Enter Phone Number");
                            a.phoneNo2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.phoneNo2);
                            Console.WriteLine("Enter Email");
                            a.email2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.email2);

                            Console.WriteLine("\nGiven new Details Are : \n");
                            Console.WriteLine("First Name = " + addbook[8]);
                            Console.WriteLine("Lastt Name = " + addbook[9]);
                            Console.WriteLine("Address = " + addbook[10]);
                            Console.WriteLine("City = " + addbook[11]);
                            Console.WriteLine("State = " + addbook[12]);
                            Console.WriteLine("Zip = " + addbook[13]);
                            Console.WriteLine("Phone Number = " + addbook[14]);
                            Console.WriteLine("Email = " + addbook[15]);

                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter First Name and Last Name of the person to delete his record");
                        string fname1 = Convert.ToString(Console.ReadLine());
                        string lname2 = Convert.ToString(Console.ReadLine());
                        if ((a.firstName == fname1) && (a.lastName == lname2))
                        {
                            addbook.RemoveRange(0, 7);

                            Console.WriteLine("\n Record Deleted: \n");

                        }
                        else if ((a.firstName2 == fname1) && (a.lastName2 == lname2))
                        {
                            addbook.RemoveRange(8, 15);
                            Console.WriteLine("\n Record Deleted: \n");

                        }
                        break;
                }
                choice();
            }
        }
    }
}
