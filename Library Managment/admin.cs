using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library_Managment
{
    internal class admin
    {
        public string name = "Cynthie";
        public int password = 6431;
        public string address = "13 Ejindu street";

        //public admin(string name, int password, string address)
        //    {
        //    this.name = name;
        //    this.password = password;
        //    this.address = address;
        //     }
            
        public void adminLogin()
        {
            //admin admin = new admin("Cynthie", 6431, "13 Ejindu street");
            Try:
            Console.Write("For Access To the admin Dashboard, Enter your name: ");
            string Confname = Console.ReadLine();
            Console.WriteLine("Confirm Password: ");
            int Confpassword = Convert.ToInt32(Console.ReadLine());
            if(Confname.ToLower() == name.ToLower() && Confpassword == password)
            {
                //cont for admin
                Console.WriteLine("     \n" +
                    "you are successfully logged in as an admin.");
                Console.WriteLine("******************************************************");
            }
            else
            {
                Console.WriteLine("Invalid Input...Try again ");
                goto Try;
            }

        }
}
    }

