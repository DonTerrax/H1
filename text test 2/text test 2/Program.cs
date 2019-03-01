using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_test_2
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteAllText(@".\StarWars.txt", "Han skød først");
            string txt = ReadAllText(@".\StarWars.txt");
            Console.WriteLine(txt);

            //Delete(@".\StarWars.txt");

            CreateDirectory(@".\Droids");
            WriteAllText(@".\Droids\R2D2.txt", "beep bop");
            //Delete(@".\Droids", true);

            CreateDirectory(@".\Droids\Astromech");
            CreateDirectory(@".\Droids\Protocol");
            WriteAllText(@".\Droids\Astromech\R2D2.txt", "beep bop");
            WriteAllText(@".\Droids\Protocol\C3P0.txt", "sir!");
            var file = new FileStream(@".\Starwars.txt", FileMode.Create);
            var write = new StreamWriter(file);
            foreach (string item in GetFiles(@".\Droids"))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
        public static void WriteAllText(string path, string contents)
        {
            File.WriteAllText(path, contents);
        }


        public static string ReadAllText(string path)
        {
            path = File.ReadAllText(path);
            return path;
        }


        public static void Delete(string path)
        {
            File.Delete(path);
        }


        public static DirectoryInfo CreateDirectory(string path)
        {
            return Directory.CreateDirectory(path);
        }


        public static void Delete(string path, bool recursive)
        {
            Directory.Delete(path, recursive);
        }


        public static string[] GetFiles(string path)
        {
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            return files;
        }

        public static string[] jedies = new[] {"luke skywalker", "Bobba Fet"};

    }
}
