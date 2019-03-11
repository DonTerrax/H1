using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilblotek
{
    class Book
    {
        #region variables
        private static List<object>bookList = new List<object>();
        private static Stack<object>userStack = new Stack<object>();
        private string name;
        private string genre;
        private string author;
        private int publishYear;
        private sbyte id;
        #endregion

        #region get/set

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Genre
        {
            get
            {
                return genre;

            }
            set
            {
                genre = value;

            }
        }

        public string Author
        {
            get
            {
                return author;

            }
            set
            {
                author = value;

            }
        }

        public int PublishYear
        {
            get
            {
                return publishYear;

            }
            set
            {
                publishYear = value;

            }
        }

        public sbyte Id
        {
            get
            {
                return id;

            }
            set
            {
                id = value;

            }
        }

        public Stack<object> UserStack
        {
            get
            {
                return userStack;

            }
            set
            {
                userStack = value;

            }
        }

        public List<object> BookList
        {
            get
            {
                return bookList;

            }
            set
            {
                bookList = value;

            }
        }
        #endregion

        #region Constructors


        public Book(sbyte id)
        {
            this.id = id;
        }

        public Book()
        {

        }
        
        public Book(string name,string genre,string author,int publishYear)
        {
            this.name = name;
            this.genre = genre;
            this.author = author;
            this.publishYear = publishYear;
        }
        #endregion


        //Creates 3 objects and inserts them to the list
        public void Books()
        {
            Book book1 = new Book("Erik Menneskesøn","Adventure","Lars Henrik Olsen",1986);
            Book book2 = new Book("Lord Of the Rings","Adventure", "John Ronald Reuel",1954);
            Book book3 = new Book("Treasure Island","Adventure","Robert Louise Stevenson",2010);
            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);

        }
        //Returns the list to main
        public static List<object>AddTobockStack()
        {
            return bookList;
        }
        //Returns the stack to main
        public static Stack<object> RemoveFromlist()
        {
            return userStack;
        }
        //Removes a book from the list and adds it to the stack
        public void BorrowBook()
        {
            userStack.Push(bookList[id - 1]);
            bookList.RemoveAt(id - 1);
        }
        //Adds a book to the list and removes it from the stack
        public void ReturnBook()
        {
            bookList.Add(userStack.Pop());
        }
    }
}
