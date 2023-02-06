// See https://aka.ms/new-console-template for more information
using Library_Managment;
using System;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace library
{
class program
    {
       
        static void Main(string[] args)
        {
            admin admin = new admin();
            client client = new client();
            books books = new books();

            //books TTBP = new books("The Three-Body Problem", "Cixin Liu", new DateOnly(2022, 03, 21));
            //books theStimulatedMultiverse = new books("The Stimulated Multiverse", "Rizwan Vik", new DateOnly(2021, 03, 18));
            //books starWars = new books("The Art Of Star Wars:Galaxy's edge", "Amy Ratcliffe", new DateOnly(2021, 01, 06));
            //books providence = new books("Providence", "Max Berry", new DateOnly(2020, 5, 7));
            //books theRoad = new books("The Road", "Commac McCarthy", new DateOnly(2006, 7, 30));

            string storeName = "Body, Soul & Books";
            Console.WriteLine($"              \n" +
                $"welcome to {storeName} library \n" +
                $"**************************************************** \n");
            input:
            Console.WriteLine( "If you are a costumer, Enter 1\n" +
                $"if you are an admin, Enter 2");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
         
                Console.WriteLine("                  \n" +
                    "Already have an account?, Enter 1 to log in\n" +
                    "Your first time here, Enter 2 to create a new account");
                  ans:
                int ans = Convert.ToInt32(Console.ReadLine());
                if (ans == 1)
                {
                    //client log in ...remember to create data for an already created account
                }
                else if (ans == 2)
                {
                   
                    client.AccountCreation();
                    pref:
                    
                    Console.WriteLine($"\n Explore {storeName}\n" +
                        $"____________________________________\n" +
                        $"                  \n" +
                       // $"Choose Your Book Preference:  \n" +
                        $"Enter 1 for fictional books  \n" +
                        $"Enter 2 for non-fictional books \n" +
                        $"Enter 3 to view your shelf \n" +
                        $"Enter 4 to return book \n ");
                    int bookpref = Convert.ToInt32(Console.ReadLine());
                    if (bookpref == 1)
                    {
                        fic:
                        books.Fiction();
                     
                        Console.WriteLine("enter 9 to go back to home");
                        Console.WriteLine("Enter 5 to go back ");
                        int enter = Convert.ToInt32(Console.ReadLine());
                        if (enter == 9)
                        {
                            goto pref;
                        }
                        else if (enter == 5)
                        {
                            goto fic;


                        }
                    }
                    else if (bookpref == 2)
                    {
                        non:
                        //you havent created a method for non fictional books yet
                        Console.WriteLine("enter 9 to go back to home");
                        Console.WriteLine("Enter 5 to go back ");
                        int enter = Convert.ToInt32(Console.ReadLine());
                        if (enter == 9)
                        {
                            goto pref;
                        }
                        else if (enter == 5)
                        {
                            goto non;


                        }
                      
                    }
                    else if (bookpref == 3)
                    {
                        Console.WriteLine($"           \n" +
                            $"You have {books.noOfBooks} books in your shelf\n" +
                            $"These are the books in your shelf:  ");
                        for (int i = 0; i < books.shelf.Count; i++)
                        {
                            Console.WriteLine($"{i +1}) {books.shelf[i].name} written by {books.shelf[i].author}");
                        }
                            Console.WriteLine("enter 9 to go back to home");
                            int enter = Convert.ToInt32(Console.ReadLine());
                            if (enter == 9)
                            {
                                goto pref;
                            }
                          
                    }
                    else if (bookpref == 4)
                    {
                        //for returning borrowed book
                        Console.WriteLine("             \n");
                        books.ReturnBooks();

                        Console.WriteLine("enter 9 to go back to home");
                        int enter = Convert.ToInt32(Console.ReadLine());
                        if (enter == 9)
                        {
                            goto pref;
                        }
                    }
                    else
                    {
                        Console.WriteLine("invalid input...");
                        goto pref;
                    }

                }
                else
                {
                    Console.WriteLine("you Entered an invalid input \n Enter another valid input");
                    goto ans;
                }
            }
            else if (input == 2)
            {
                //admin
                admin.adminLogin();
                back:
                Console.WriteLine("   \n" +
                    "Enter 1 to add new books to the library \n" +
                    "Enter 2 to view costumers' details");
                int add = Convert.ToInt32(Console.ReadLine());
                switch(add)
                {
                    case 1: //adding new books to the library
                        books.AddBooks();
                        break;
                    case 2: //viewing costumers details
                        confirm:
                        Console.Write("To view customers' details, Confirm password:   ");
                        int confirm = Convert.ToInt32(Console.ReadLine());
                        if(confirm == admin.password)
                        {
                            Console.WriteLine("Password confirmed");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect password...try again");
                            goto confirm;
                        }
                        client.costumerDetails();
                        break;
                }
                shii:
                Console.WriteLine("Enter 9 to go back");
                int back = Convert.ToInt32(Console.ReadLine());
                if(back == 9)
                {
                    goto back;
                }
                else
                {
                    Console.WriteLine("Invalid input... Try again");
                    goto shii;
                }
          
            }
            else
            {
                Console.WriteLine("you entered an invalid input...Try Again");
                goto input;
            }





        }
    }
}
