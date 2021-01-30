using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08_Collections
{
   class Book<T>
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public GenreType Genre { get; set; }

        public enum GenreType
        {
            Action,
            Classics,
            Comic,
            Mystery,
            Fantasy,
            Historical_Fiction,
            Horror,
            Literary_Fiction,
            Magical_Realism,
            Romance,
            Sci_Fi,
            Short_Stories,
            Suspense,
            Non_Fiction,
            CookBooks,
            History,
            True_Crime,
            Educational
        }

        public Book(string title, Author author, GenreType genre)
        {
            Title = title;
            Author = author;
            Genre =  genre;
         }
    }
 
}
