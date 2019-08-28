using System;
using System.Threading;
using System.Threading.Tasks;

namespace Udemy___inheritance_and_more_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Mike Madsen");
            Console.WriteLine(post1.ToString());

            ImagePost imagepost1 = new ImagePost("Check out my new shoes!", "Mike Madsen", "https://images.com/shoes", true);
            Console.WriteLine(imagepost1.ToString());

            VideoPost videopost1 = new VideoPost("Cool video", "Mike Madsen", "https://hentai.com/pr0n", true, 10);
            videopost1.Play();
            Console.WriteLine(videopost1.ToString());
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            videopost1.Stop();
        }
    }
}
