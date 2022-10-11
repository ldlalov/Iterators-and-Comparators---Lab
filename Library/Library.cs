using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public IEnumerator<Book> GetEnumerator()
        {
            books.Sort();
            for (int i = 0; i < books.Count; i++)
            {
                yield return books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private List<Book> books;
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        //public IEnumerator<Book> GetEnumerator()
        //{
        //    return new LibraryIterator(books);
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}

        //class LibraryIterator : IEnumerator<Book>
        //{
        //    private List<Book> books;
        //    private int currentIndex = -1;
        //    public LibraryIterator(List<Book> books)
        //    {
        //        this.books = books;
        //        Reset();
        //    }

        //    public Book Current => books[currentIndex];

        //    object IEnumerator.Current => Current;

        //    public void Dispose()
        //    {
        //    }

        //    public bool MoveNext()
        //    {
        //        currentIndex++;
        //        return  currentIndex < books.Count;
        //    }

        //    public void Reset()
        //    {
        //        currentIndex = -1;
        //    }
        //}
    }
}
