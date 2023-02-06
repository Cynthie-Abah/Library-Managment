using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment
{
    public class client
    {
        public string name;
        public int age;
        public string address;
        private protected int password;
        public client()
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.password = password;
        }

        public client(string name, int age, string address, int noOfBooks, int password)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.password = password;
        }

        public void AccountCreation()
        {
            Console.Write("To Create an account:  \n" +
                "Enter your name ");
            name = Console.ReadLine();
            Console.Write("Enter your age:  ");
            age = Convert.ToInt32(Console.ReadLine());
            password:
            Console.Write("Choose password:  ");
            password = Convert.ToInt32(Console.ReadLine());
            Console.Write("confirm password:  ");
            int check = Convert.ToInt32(Console.ReadLine());
            if (password == check)
            {
                Console.WriteLine(" Account successfully created");
            }
            else
            {
                Console.WriteLine("Incorrect... Enter password again");
                goto password;
            }

        }
        public void costumerDetails()
        {
        //confirm:
        //    Console.Write("To view customers' details, Confirm password:   ");
        //    int confirm = Convert.ToInt32(Console.ReadLine());
        //    if (confirm == admin.password)
        //    {
        //        Console.WriteLine("Password confirmed");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Incorrect password...try again");
        //        goto confirm;
        //    }
            Console.WriteLine("Costumer's Details \n" +
                "*****************************\n" +
                "you have 0 costumer \n" +
               $"customer's name: {name} \n" +
               $"costumer's age: {age}\n" +
               $"costumer's address {address}");
        }


    }
}
