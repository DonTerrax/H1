using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy___inheritance_and_more_oop
{
    // ImagePost derices from post and adds a property (ImageURL) and two constructors
    class ImagePost:Post
    {
        public string ImageURL { get; set; }

        public ImagePost()
        {

        }

        public ImagePost(string title, string sendByUsername, string imageUrl, bool isPublic)
        {
            // The following properties and the GetNextID method are inherited from Post.
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;


            // Property ImageURL is a member of ImagePost, but not of Post.
            this.ImageURL = imageUrl;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", this.ID, this.Title,this.ImageURL, this.SendByUsername);
        }

    }
}
