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
        private static Stack<object>Bookstack = new Stack<object>();
        private static Stack<object>UserStack = new Stack<object>();
        private string name;
        private string genre;
        private string author;
        private int publishYear;
        private int id;
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
        #endregion

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

        public void Books()
        {
            Book book1 = new Book("Erik Menneskesøn","Adventure","Lars Henrik Olsen",1986);
            Book book2 = new Book("Lord Of the Rings","Adventure", "John Ronald Reuel",1954);
            Book book3 = new Book("Treasure Island","Adventure","Robert Louise Stevenson",2010);
            Bookstack.Push(book1);
            Bookstack.Push(book2);
            Bookstack.Push(book3);

        }

        public static Stack<object>AddTobockStack()
        {
            
            return Bookstack;
        }

        public static Stack<object> AddToUserStack(int userChoice)
        {
            
            return UserStack;
        }
    }
}
