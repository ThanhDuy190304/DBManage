using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagerApp.src.Controllers;

namespace SchoolManagerApp
{
    class Program
    {
        // "admin";  "Admin123";

        static void Main()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();    

            var controller = new Form1Controller(username, password);

            Console.WriteLine("\ninnnnnn ...");

            if (controller.Login())
                Console.WriteLine("ok!");
            else
                Console.WriteLine("no ok");

            Console.ReadLine();
        }
      
    }

}
