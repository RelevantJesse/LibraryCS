using System;
using System.Collections.Generic;

namespace LibraryCS
{
    class Library
    {
        static void Main(string[] args)
        {
            List<string> bookTitles = new List<string>();

            while (true)
            {
                Console.WriteLine("Welcome to the Library App!");
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. List all books");
                Console.WriteLine("3. Check out book");
                Console.WriteLine("4. Check in book");

                string input = Console.ReadLine();

                int numChoice = Convert.ToInt32(input);

                switch (numChoice)
                {
                    case 1:
                    {
                        Console.WriteLine("Title:");
                        string title = Console.ReadLine();

                        bookTitles.Add(title);

                        //Console.WriteLine("Author:");
                        //string author = Console.ReadLine();
                        break;
                    }
                    case 2:
                        for (int i = 0; i < bookTitles.Count; i++)
                        {
                            Console.WriteLine((i+1) + ". " + bookTitles[i]);
                        }

                        break;
                    case 3:
                    {
                        Console.WriteLine("What book do you want to check out?");
                        string title = Console.ReadLine();

                        if (!bookTitles.Contains(title))
                        {
                            Console.WriteLine(title + " does not exist");
                            continue;
                        }

                        Console.WriteLine(title + " checked out!");
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("What book do you want to check out?");
                        string title = Console.ReadLine();

                        if (!bookTitles.Contains(title))
                        {
                            Console.WriteLine(title + " does not exist");
                            continue;
                        }

                        Console.WriteLine(title + " checked in!");
                        break;
                    }
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
