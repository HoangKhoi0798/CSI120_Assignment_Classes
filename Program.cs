using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace CSI120_Assignment_Classes
{
    internal class Program
    {
        // Hoang Khoi Gia Nguyen
        // CSI 120 - Computer Programming 1
        // Assignment - Classes

        public static Book[] books = new Book[10];
        static void Main(string[] args)
        {
            PreloadBooks();
            Menu();

        }// Main

        public static void Menu()
        {
            // Menu with switch

            Console.WriteLine("1 - Add a new book");
            Console.WriteLine("2 - Display all books");
            Console.WriteLine("3 - Update a book's information");
            Console.WriteLine("4 - Exit the program");
            Console.Write("Your choice: ");

            string userInput = Console.ReadLine();

            Console.WriteLine();

            switch (userInput)
            {
                case "1":
                    AddNewBook();
                    Menu();
                    break;

                case "2":
                    DisplayAllBook();
                    Menu();
                    break;

                case "3":
                    UpdateBook();
                    Menu();
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid");
                    Console.WriteLine();
                    Menu();
                    break;


            }
        }// End of Menu

        public static void PreloadBooks()
        {
            // Preloading some books
            books[0] = new Book("Book Girl", "Mizuki Nomura", 2006);
            books[1] = new Book("The Eminence in Shadow", "Daisuke Aizawa" , 2018);

        }// End of Preload

        public static void DisplayAllBook()
        {
            // Displaying books currently in the arrays

            for (int i = 0; i < books.Length; i++)
            {

                if (books[i] == null)
                {

                    Console.WriteLine("Empty");

                }
                else { 

                Book currentBook = books[i];

                Console.WriteLine(currentBook.DisplayBook());

                }

            }

            Console.WriteLine();

        }// End of Display

        public static void AddNewBook()
        {
            // Loops through array

            for (int i = 0; i < books.Length; i++)
            {

                try
                {

                // Check for an empty spot

                if (books[i] == null)
                {
                        //Add to space if empty
                        Console.WriteLine("Slot available");
                    
                    
                    Console.Write("Enter the title: ");
                    string inputTitle = Console.ReadLine();

                    Console.Write("Enter the author: "); 
                    string inputAuthor = Console.ReadLine();

                    Console.Write("Enter the year of publication: ");
                    string inputYear = Console.ReadLine();
                    int formatYear = int.Parse(inputYear);

                    books[i] = new Book($"{inputTitle}",$"{inputAuthor}", formatYear);

                        Console.WriteLine();
                        return;

                }

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                    break;

                }

            }

        }// End of Adding

        public static void UpdateBook()
        {
            
            Console.Write("Enter book's title: ");
            string titleInput = Console.ReadLine();

            // Loop through array to check

            for (int i = 0; i < books.Length; i++)
            {
                // If match, prompt input new information
                try
                {

                if (titleInput == books[i].Title)
                {
                    Console.Write("Enter the title: ");
                    string inputTitle = Console.ReadLine();

                    Console.Write("Enter the author: ");
                    string inputAuthor = Console.ReadLine();

                    Console.Write("Enter the year of publication: ");
                    string inputYear = Console.ReadLine();
                    int formatYear = int.Parse(inputYear);

                    books[i] = new Book($"{inputTitle}", $"{inputAuthor}", formatYear);
                       
                        Console.WriteLine("Updated");
                        Console.WriteLine();
                        break;
                }


                }

                catch (Exception ex)
                {

                    Console.WriteLine("No matches.");
                    Console.WriteLine();
                    break;

                }

            }

        }// End of Update
               

    }// Class

    public class Book
    {
        public string Title;
        public string Author;
        public int Year;

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public string DisplayBook()
        {
            return $"{Title} , {Author}, {Year}";
        }
    }

}// Name
