using System;

namespace Lab08_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Library()
        {
            
        }

        static void BookBag()
        {

        }

        static void LoadBooks()
        {
            Book book = new Lab08_Collections.Book();
            book.Title = "What are we even doing?";
            book.Author = "Mike";
            book.Genre = Books.GenreType.Horror;
        }

        static void UserInterface()
        {


        }
    }
}
