using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Udemy_arrays
{
    class Post
    {
        private static int currentpostId;


       

        protected int ID { get; set; }

        protected string Title { get; set; }

        protected string SendByUsername { get; set; }

        protected bool IsPublic { get; set; }


        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Mike Madsen";
        }

        // Instance constructor that has thee parameters
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextId()
        {
            return ++currentpostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }


        //Virtual method override of the ToString method that is inherited from system.object.
        
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", this.ID, this.Title, this.SendByUsername);
        }

        

    }
}
