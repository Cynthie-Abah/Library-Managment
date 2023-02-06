using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment
{
    public class books
    {
        public string name;
        public string author;
        public DateOnly? dateRegistered;
       public List<books> shelf = new List<books>();
        public int noOfBooks;

        public List<books> science = new List<books>();
       public List<books> mystery = new List<books>();
       public List<books> Hystorical = new List<books>();
       public List<books> Thriller = new List<books>();
       public List<books> Romance = new List<books>();
       public List<books> Horror = new List<books>();
      public List<books> fictionBooks = new List<books>();
    

        public books()
        {
            this.name = name;
            this.author = author;
            this.dateRegistered = dateRegistered;
            this.shelf = shelf;
        }
        public books(string name, string author, DateOnly dateRegistered)
        {
            this.name = name;
            this.author = author;
            this.dateRegistered = dateRegistered;
            this.shelf = shelf;
        }

     
        public void Fiction()
        {
            
        Switch:
            home:
            Console.WriteLine("******************************************\n" +
                "  You are in the fiction books section now \n" +
                "Choose your preference :\n" +
                "1) Science \n" +
                "2) Mystery \n" +
                "3) Historical \n" +
                "4) Thriller \n" +
                "5) Romance \n" +
                "6) Horror \n" +
                "7) All");
     
            int bookrep = Convert.ToInt32(Console.ReadLine());
           string enter;
           
            switch (bookrep)
            {
                case 1: Console.WriteLine(Science());
                   
                    break;
                case 2:
                    Console.WriteLine(Mystery());
                  
                    break;
                case 3:
                    Console.WriteLine(hystorical());
                    
                    break;
                case 4:
                    Console.WriteLine(thriller());
                    
                    break;
                case 5:
                    Console.WriteLine(romance());
                 
                    break;
                case 6:
                    Console.WriteLine(horror());
                 
                    break;
                case 7:
                    //all books
                      all();
                   
                    break;
                default:
                    Console.WriteLine("you have entered an invalid input...pls Enter the correct input");
                    goto Switch;

                    if (enter =="*")
                    {
                        goto home;
                    }
                    break;
                
            }

        }

        public string Science()
        {

        
        science:
            books TTBP = new books("The Three-Body Problem", "Cixin Liu", new DateOnly(2022, 03, 21));
            books theStimulatedMultiverse = new books("The Stimulated Multiverse", "Rizwan Vik", new DateOnly(2021, 03, 18));
            books starWars = new books("The Art Of Star Wars:Galaxy's edge", "Amy Ratcliffe", new DateOnly(2021, 01, 06));
            books providence = new books("Providence", "Max Berry", new DateOnly(2020, 5, 7));
            books theRoad = new books("The Road", "Commac McCarthy", new DateOnly(2006, 7, 30));

            science.Add(TTBP);
            science.Add(theStimulatedMultiverse);
            science.Add(starWars);
            science.Add(providence);
            science.Add(theRoad);

            Console.WriteLine("***********************************************\n" +
                " here are the books available under this category \n");
            for (int i = 0; i < science.Count; i++)
            {
                Console.WriteLine($"{i})" + science[i].name);
            }
            Console.WriteLine("Enter the number assigned to the book of your choice");
            int counts = Convert.ToInt32(Console.ReadLine());

        cart:
            Console.WriteLine($"*************************************************************" +
                $"\nThe book you have selected is {science[counts].name}\n" +
                $"It was written by {science[counts].author} and registered into the library on this date {science[counts].dateRegistered}\n" +
                $"and has a total of 345 pages\n" +
                $"Enter 1 to add to shelf \n" +
                $"Enter 2 to continue exploring science fictions");

            int cart = Convert.ToInt32(Console.ReadLine());
            if (cart == 1)
            {
              
                ++noOfBooks;
                Console.WriteLine("Book successfully added to shelf");
            
               
            }
           
            else if(cart == 2)
            {
                goto science;
            }
            else
            {
                Console.WriteLine("Failed to add to cart...Please Enter a valid input and try again");
                goto cart;
            }
            
            shelf.Add(science[counts]);
       
            return "******************************************";

        }

        public string Mystery()
        {
 
        myst:
            books theFamilyRemains = new books("The Family Remains", "Lisa Jewell", new DateOnly(2022, 03, 21));
            books thePush = new books("The push", "Ashley Audrain", new DateOnly(2022, 03, 18));
            books verity = new books("Verity", "Colleen Hoover", new DateOnly(2021, 01, 06));
            books theSecretPlace = new books("The Secret Place", "Tana French", new DateOnly(2021, 5, 7));
            books inColdBlood = new books("In Cold Blood", "Truman Capote", new DateOnly(2022, 7, 30));

            mystery.Add(theFamilyRemains);
            mystery.Add(thePush);
            mystery.Add(verity);
            mystery.Add(theSecretPlace);
            mystery.Add(inColdBlood);

            Console.WriteLine("***********************************************\n" +
                " here are the books available under this category \n");
            for (int i = 0; i < mystery.Count; i++)
            {
                Console.WriteLine($"{i})" + mystery[i].name);
            }
            Console.WriteLine("Enter the number assigned to the book of your choice");
            int countm = Convert.ToInt32(Console.ReadLine());

        cart:
            Console.WriteLine($"*************************************************************" +
                $"\nThe book you have selected is {mystery[countm].name}\n" +
                $"It was written by {mystery[countm].author} and registered into the library on this date {mystery[countm].dateRegistered}\n" +
                $"and has a total of 345 pages\n" +
                $"Enter 1 to add to shelf \n" +
                $"Enter 2 to continue exploring mystery fictions");
            int cart = Convert.ToInt32(Console.ReadLine());
            if (cart == 1)
            {
              
                ++noOfBooks;
                Console.WriteLine("Book successfully added to shelf");
                
            }
            else if(cart ==2)
            {
                goto myst;
            }
            else
            {
                Console.WriteLine("Failed to add to shelf...Please Enter a valid input and try again");
                goto cart;
            }
            shelf.Add(mystery[countm]);

            return "******************************************";
        }

        public string thriller()
        {
            
        thril:
            books theConfession = new books("The Confession", "John Grisham", new DateOnly(2022, 03, 21));
            books theGuestList = new books("The Guest List", "Lucy Foley", new DateOnly(2022, 03, 18));
            books theTurnout = new books("The Turnout", "Megan Abbot", new DateOnly(2021, 01, 06));
            books theWitness = new books("The Witness", "Nora Roberts", new DateOnly(2021, 5, 7));
            books theObsession = new books("the Obssession", "Nora ROberts", new DateOnly(2022, 7, 30));

            Thriller.Add(theConfession);
            Thriller.Add(theGuestList);
            Thriller.Add(theTurnout);
            Thriller.Add(theWitness);
            Thriller.Add(theObsession);

            Console.WriteLine("***********************************************\n" +
                " here are the books available under this category \n");
            for (int i = 0; i < Thriller.Count; i++)
            {
                Console.WriteLine($"{i})" + Thriller[i].name);
            }
            Console.WriteLine("Enter the number assigned to the book of your choice");
            int countt = Convert.ToInt32(Console.ReadLine());

        cart:
            Console.WriteLine($"*************************************************************" +
                $"\nThe book you have selected is {Thriller[countt].name}\n" +
                $"It was written by {Thriller[countt].author} and registered into the library on this date {Thriller[countt].dateRegistered}\n" +
                $"and has a total of 345 pages\n" +
                $"Enter 1 to add to shelf \n" +
                $"Enter 2 to continue exploring thriller fictions ");
            int cart = Convert.ToInt32(Console.ReadLine());
            if (cart == 1)
            {
                
                ++noOfBooks;
                Console.WriteLine("Book successfully added to shelf");
                
            }
            else if(cart == 2)
            {
                goto thril;
            }
            else
            {
                Console.WriteLine("Failed to add to shelf...Please Enter a valid input and try again");
                goto cart;
            }
            shelf.Add(Thriller[countt]);
            return "******************************************";
        }
        public string hystorical()
        {
            
        hist:
            books devotion = new books("Devotion", "Loya Jaye", new DateOnly(2022, 03, 21));
            books stoneBlind = new books("Stone Blind", "Natalie Haynes", new DateOnly(2022, 03, 18));
            books theRedTent = new books("The Red Tent", "Anita Diamant", new DateOnly(2021, 01, 06));
            books haven = new books("Haven", "Emma Donghue", new DateOnly(2021, 5, 7));
            books wolfHall = new books("wolfHall", "Hilary Mantel", new DateOnly(2022, 7, 30));

            Hystorical.Add(devotion);
            Hystorical.Add(stoneBlind);
            Hystorical.Add(theRedTent);
            Hystorical.Add(haven);
            Hystorical.Add(wolfHall);

            Console.WriteLine("***********************************************\n" +
                " here are the books available under this category \n");
            for (int i = 0; i < Hystorical.Count; i++)
            {
                Console.WriteLine($"{i})" + Hystorical[i].name);
            }
            Console.WriteLine("Enter the number assigned to the book of your choice");
            int counth = Convert.ToInt32(Console.ReadLine());

        cart:
            Console.WriteLine($"*************************************************************" +
                $"\nThe book you have selected is {Hystorical[counth].name}\n" +
                $"It was written by {Hystorical[counth].author} and registered into the library on this date {Hystorical[counth].dateRegistered}\n" +
                $"and has a total of 345 pages\n" +
                $"Enter 1 to add to shelf \n" +
                $"Enter 2 to continue exploring Historical fictions");
            int cart = Convert.ToInt32(Console.ReadLine());
            if (cart == 1)
            {
               
                ++noOfBooks;
                Console.WriteLine("Book successfully added to shelf");
               
            }
            else if(cart == 2)
            {
                goto hist;
            }
            else
            {
                Console.WriteLine("Failed to add to shelf...Please Enter a valid input and try again");
                goto cart;
            }
            shelf.Add(Hystorical[counth]);
            return "******************************************";
        }

        public string romance()
        {
          

        rom:
            books forbidden = new books("Forbidden", "Berverly Jenkins", new DateOnly(2022, 03, 21));
            books theProposal = new books("The proposal", "Jasmine Gulliary", new DateOnly(2022, 03, 18));
            books visionInWhite = new books("Vision In White", "Nora Roberts", new DateOnly(2021, 01, 06));
            books prideAndPrejudice = new books("pride And Prejudice", "Jane Austen", new DateOnly(2021, 5, 7));
            books outlander = new books("outlander", "Diana Gabaldon", new DateOnly(2022, 7, 30));

            Romance.Add(forbidden);
            Romance.Add(theProposal);
            Romance.Add(visionInWhite);
            Romance.Add(prideAndPrejudice);
            Romance.Add(outlander);

            Console.WriteLine("***********************************************\n" +
                " here are the books available under this category \n");
            for (int i = 0; i < Romance.Count; i++)
            {
                Console.WriteLine($"{i})" + Romance[i].name);
            }
            Console.WriteLine("Enter the number assigned to the book of your choice");
            int countr = Convert.ToInt32(Console.ReadLine());

        cart:
            Console.WriteLine($"*************************************************************" +
                $"\nThe book you have selected is {Romance[countr].name}\n" +
                $"It was written by {Romance[countr].author} and registered into the library on this date {Romance[countr].dateRegistered}\n" +
                $"and has a total of 345 pages\n" +
                $"Enter 1 to add to shelf \n" +
                $"Enter 2 to continue exploring Romance fictions");
            int cart = Convert.ToInt32(Console.ReadLine());
            if (cart == 1)
            {
              
                ++noOfBooks;
                Console.WriteLine("Book successfully added to shelf");
             
            }
            else if (cart == 2) 
            {
                goto rom;
            }
            else
            {
                Console.WriteLine("Failed to add to shelf...Please Enter a valid input and try again");
                goto cart;
            }
          
            shelf.Add(Romance[countr]);
            return "******************************************";
        }

        public string horror()
        {

        hor:
            books theLoop = new books("The Loop", "Jeremy Robert Johnson", new DateOnly(2022, 03, 21));
            books theExorcist = new books("The Excorcist", "William Peter", new DateOnly(2022, 03, 18));
            books harvestHome = new books("Harvest Home", "Thomas Tryon", new DateOnly(2021, 01, 06));
            books theAuctioneer = new books("The Auctioneer", "Joan Samson", new DateOnly(2021, 5, 7));
            books theHunger = new books("The Hunger", "Alma Katsu", new DateOnly(2022, 7, 30));

            Horror.Add(theLoop);
            Horror.Add(theExorcist);
            Horror.Add(harvestHome);
            Horror.Add(theAuctioneer);
            Horror.Add(theHunger);

            Console.WriteLine("***********************************************\n" +
                " here are the books available under this category \n");
            for (int i = 0; i < Horror.Count; i++)
            {
                Console.WriteLine($"{i})" + Horror[i].name);
            }
            Console.WriteLine("Enter the number assigned to the book of your choice");
            int count = Convert.ToInt32(Console.ReadLine());

        cart:
            Console.WriteLine($"*************************************************************" +
                $"\nThe book you have selected is {Horror[count].name}\n" +
                $"It was written by {Horror[count].author} and registered into the library on this date {Horror[count].dateRegistered}\n" +
                $"and has a total of 345 pages\n" +
                $"Enter 1 to add to shelf\n" +
                $"Enter 2 to continue exploring Horror fictions");
            int cart = Convert.ToInt32(Console.ReadLine());
            if (cart == 1)
            {
             
                ++noOfBooks;
                Console.WriteLine("Book successfully added to shelf");
               
            }
            else if(cart == 2)
            {
                goto hor;
            }
            else
            {
                Console.WriteLine("Failed to add to shelf...Please Enter a valid input and try again");
                goto cart;
            }
            var Shelf = Horror[count].name;
            shelf.Add(Horror[count]);
            return "******************************************";
        }

        public void all()
        {
            

            fictionBooks.AddRange(Horror);
            fictionBooks.AddRange(Romance);
            fictionBooks.AddRange(Thriller);
            fictionBooks.AddRange(science);
            fictionBooks.AddRange(Hystorical);
        all:
            
           

            Console.WriteLine("***********************************************\n" +
                " here are the books available under this category \n");
         
            for (int i = 0; i < fictionBooks.Count; i++)
            {
                Console.WriteLine(fictionBooks[i]);
                Console.WriteLine($"{i})" + fictionBooks[i].name);
            }
            Console.WriteLine("Enter the number assigned to the book of your choice");
            int count = Convert.ToInt32(Console.ReadLine());

        cart:
            Console.WriteLine($"*************************************************************" +
                $"\nThe book you have selected is {fictionBooks[count].name}\n" +
                $"It was written by {fictionBooks[count].author} and registered into the library on this date {Horror[count].dateRegistered}\n" +
                $"and has a total of 345 pages\n" +
                $"Enter 1 to add to shelf" +
                $"Enter 2 to continue Exploring fiction books");
            int cart = Convert.ToInt32(Console.ReadLine());
            if (cart == 1)
            {
              
                ++noOfBooks;
                Console.WriteLine("Book successfully added to shelf");
               
            }
            else if(cart ==2)
            {
                goto all;
            }
            else
            {
                Console.WriteLine("Failed to add to shelf...Please Enter a valid input and try again");
                goto cart;
            }
             shelf.Add(fictionBooks[count]);

        }


        public void ReturnBooks()
        {
            client client = new client();
            Console.WriteLine($"Hey {client.name} \n" +
                $"which book from your library do you want to return today?");
            for(int i = 0; i < shelf.Count; i++)
            {
                Console.WriteLine($"{i})  {shelf[i].name} by {shelf[i].author}");
            }
            Console.WriteLine("Enter the serial number of your choice");
            int Return = Convert.ToInt32(Console.ReadLine());
        pass:
            Console.WriteLine($"To confirm that you want to return {shelf[Return].name} by {shelf[Return].author}\n to the library,\n" +
                $" Enter 1 \n" +
                $"if not Enter 2 ");

            int option = Convert.ToInt32(Console.ReadLine());
            if(option == 1)
            {
                string removedName = shelf[Return].name;
                string removedAuthor = shelf[Return].author;
                shelf.Remove(shelf[Return]);
                --noOfBooks;
                Console.WriteLine($"you have successfully returned {removedName} by {removedAuthor} to the library \n" +
                    $"You now have {noOfBooks} books in your custody");

            }
            else if(option == 2)
            {
                Console.WriteLine("******************************************************************************");
            }
            else
            {
                Console.WriteLine("Incorrect Password...Try again");
                goto pass;
            }


        }

        public void AddBooks()
        {
            books newBook = new books();
            //create a method for the admin to be able to add books
            Console.Write("To add books to the library, Enter book name:    ");
            newBook.name = Console.ReadLine();
            Console.Write("Enter the name of the author:    ");
            newBook.author = Console.ReadLine();
            newBook.dateRegistered = DateOnly.MaxValue;
            Console.WriteLine( "CHoose a category for the book  \n" +
                "  Enter 1 for fiction book  \n" +
                " Enter 2 for non fiction books");
            int category = Convert.ToInt32(Console.ReadLine());
            if (category == 1)
            {
                Default:
                Console.WriteLine("What book category is this book under \n" +
                    "Enter 1 for science fiction \n" +
                    "Enter 2 for Mystery fiction \n" +
                    "Enter 3 for Romance fiction \n" +
                    "Enter 4 for Thriller fiction \n" +
                    "Enter 5 for Horror fiction \n" +
                    "Enter 6 for Historical fiction \n");
                int fictionpref = Convert.ToInt32(Console.ReadLine());
                switch(fictionpref)
                {
                    case 1: science.Add(newBook);
                        Console.WriteLine("Book successfully added to science fiction");
                        break;
                    case 2: mystery.Add(newBook);
                        Console.WriteLine("Book successfully added to mystery fiction");
                        break;
                    case 3: Romance.Add(newBook);
                        Console.WriteLine("Book successfully added to romance fiction");
                        break;
                    case 4: Thriller.Add(newBook);
                        Console.WriteLine("Book successfully added to thriller fiction");
                        break;
                    case 5: Horror.Add(newBook);
                        Console.WriteLine("Book successfully added to horror fiction");
                        break;
                    case 6: Hystorical.Add(newBook);
                        Console.WriteLine("Book successfully added to history fiction");
                        break;
                    default: Console.WriteLine("Incorrect... pls try again");
                        goto Default;
                }
            }
            else if (category == 2)
            {
                Console.WriteLine("THE NON-FICTION LIBRARY IS CURRENTLY DOWN ...PLEASE TRY AGAIN LATER");
            }
            


        }

        }

    }



