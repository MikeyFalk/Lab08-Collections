using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08_Collections
{
    public class Library <T>
    {
        public T[] Books = new T[5];
        public int Count { get; set; }

        public void Add(T book)
        {
            if (Count == Books.Length)
            {
                Array.Resize(ref Books, Books.Length * 2);
            }
            Books[Count++] = book;
        }

        public void Remove(int indexToRemove)
        {
            T[] adjustedBooks = new T[Books.Length - 1];
            for (int i = 0; i < adjustedBooks.Length; i++)
            {
                if (indexToRemove > i ) { adjustedBooks[i] = Books[i]; }
                if (indexToRemove<= i) { adjustedBooks[i] = Books[i + 1]; }
            }

            Books = adjustedBooks;
            Count = adjustedBooks.Length;

        }
    }
}
