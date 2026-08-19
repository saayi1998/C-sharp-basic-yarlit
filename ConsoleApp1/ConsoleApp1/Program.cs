using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your First Name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your Last Name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter your Date of Birth (dd/mm/yyyy): ");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter your Address: ");
            string add = Console.ReadLine();
            Console.WriteLine("Enter your Telephone Number: ");
            string tel = Console.ReadLine();
            Console.WriteLine("Enter your Gender: ");
            string gen = Console.ReadLine();
            Console.WriteLine("Enter your NIC Number: ");
            string NIC = Console.ReadLine();

            Console.WriteLine("*****************************");
            Console.WriteLine("My Information");
            Console.WriteLine("*****************************");
            Console.WriteLine("First Name: " + fname);
            Console.WriteLine("Last Name: " + lname);
            Console.WriteLine("Date of Birth:" + dob.ToShortDateString());
            Console.WriteLine("Address: " + add);
            Console.WriteLine("Telephone Number: " + tel);
            Console.WriteLine("Gender: " + gen);
            Console.WriteLine("NIC Number: " + NIC);
            Console.WriteLine("*****************************");
        }
    }
}
