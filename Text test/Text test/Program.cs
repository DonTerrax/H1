using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to do? \n 1: Add file \n 2: Delete file \n 3: Display files \n 4: Add folder \n 5: Search file \n 6: Other stuff \n 7: exit");
            int menuInput = int.Parse(Console.ReadLine());
            
            switch (menuInput)
            {
                case 1:
                    Console.WriteLine("Filename?");
                    string fileName = Console.ReadLine();
                    CreateFile(fileName);
                    
                    break;
                case 2:
                    Console.WriteLine("What file do you want to delete?");
                    foreach (var file in GetFiles(@"."))
                    {
                        
                    }
                    break;
                case 3:
                    break;
                case 4:
                    Console.WriteLine("Folder name?");
                    string folderName = Console.ReadLine();
                    CreateDirectory(folderName);
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    break;

            }
            
            //Delete(@".\folder\droids\R2D2.txt", true);
            //CreateDirectory(@".\folder\droids");
            //WriteAllText(@".\folder\droids\R2D2.txt", "beep bop");
            //string txt = ReadAllText(@".\folder\droids\R2D2.txt");
            //string content = ReadAllText(@".\folder\droids\R2D2.txt");
            //Console.WriteLine();

        }
        

        public static DirectoryInfo CreateDirectory(string folderName)
        {
            string name = (@".\folder\"+ folderName);
            return CreateDirectory(name);
        }


        public static void CreateFile(string fileName)
        {
            var filename = new FileStream(fileName+@"\folder\.txt", FileMode.Create);
            filename.Close();
            
            
        }

        public static string ReadAllText(string path)
        {
            File.ReadAllText(path);
            string content = ReadAllText(path);
            return content;
        }

        public static void Delete(string path,bool recursive)
        {
            Directory.Delete(@".\", true);
        }


        public static string[] GetFiles(string path)
        {
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            return files;
        }




    }
}
