using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Udemy___inheritance_and_more_oop
{
    class VideoPost : Post
    {

        // MemberFields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;


        // Properties
        public string VideoURL { get; set; }
        public int Length { get; set; }

        public VideoPost() { }

        // Constructor
        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int length)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = true;
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimeCallBack,null,0,1000);

            }
        }


        private void TimeCallBack(Object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s",currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }
        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
            
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {4} - {3}", this.ID, this.Title, this.VideoURL, this.Length, this.SendByUsername);
        }

    }
}
