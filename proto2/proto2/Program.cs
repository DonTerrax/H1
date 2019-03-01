using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proto2
{
    class Program
    {
        static void Main(string[] args)
        {   ////////////////////////Country
            Console.WriteLine("1.Danmark\n2.Udlandet");
            int Country = int.Parse(Console.ReadLine());

            switch (Country)
            {
                case 1://Danmark
                    Console.WriteLine("1.Kase\n2.Rulle eller Stang");
                    int ShapeDK = int.Parse(Console.ReadLine());
                    switch (ShapeDK)
                    {
                        case 1://Kase
                            KaseDK(); break;
                        case 2://Rulle //Stang
                            RullestangDK(); break;
                        default: break;
                    }
                    break;

                case 2://Udlandet
                    Console.WriteLine("1.Kase\n2.Rulle eller Stang");
                    int ShapeUD = int.Parse(Console.ReadLine());
                    switch (ShapeUD)
                    {
                        case 1://Kase
                            KaseUD(); break;
                        case 2://Rulle //Stang
                            RullestangUD(); break;
                        default: break;
                    }
                    break;
                default: break;
            }
            Console.ReadKey();
        }
        public static void RullestangUD()
        {
            Console.WriteLine("Længde ");
            double RullestangL = double.Parse(Console.ReadLine());

            Console.WriteLine("Højde  ");
            double RullestangB = double.Parse(Console.ReadLine());

            double RullestangSize = (RullestangL * 2) + (RullestangB * 2);

            Console.WriteLine("Vægt i gram");
            double Vægt = double.Parse(Console.ReadLine());

            if (Vægt <= 2000 && RullestangSize <= 104)
            {
                if (Vægt <= 50)
                {
                    Console.WriteLine("Pris kr 27-");
                }
                else if (Vægt <= 100)
                {
                    Console.WriteLine("Pris kr 27-");
                }
                else if (Vægt <= 250)
                {
                    Console.WriteLine("Pris kr 54-");
                }
                else if (Vægt <= 500)
                {
                    Console.WriteLine("Pris kr 54-");
                }
                else if (Vægt <= 1000)
                {
                    Console.WriteLine("Pris kr 108-");
                }
                else if (Vægt <= 2000)
                {
                    Console.WriteLine("Pris kr 108-");
                }
            }
            else if (Vægt > 2000 || RullestangSize >= 104 && RullestangSize <= 300)
            {
                Console.WriteLine("1.Posthus\n2.Online ");
                int PostOnl = int.Parse(Console.ReadLine());
                if (PostOnl == 1)
                {
                    if (Vægt <= 5000)
                    {
                        Console.WriteLine("Pris kr 345-");
                    }
                    else if (Vægt <= 10000)
                    {
                        Console.WriteLine("Pris kr 523-");
                    }
                    else if (Vægt <= 15000)
                    {
                        Console.WriteLine("Pris kr 668-");
                    }
                    else if (Vægt <= 20000)
                    {
                        Console.WriteLine("Pris kr 820-");
                    }
                }
                else
                {
                    if (Vægt <= 5000) { Console.WriteLine("Pris kr 315-"); }
                    else if (Vægt <= 10000)
                    {
                        Console.WriteLine("Pris kr 493-");
                    }
                    else if (Vægt <= 15000)
                    {
                        Console.WriteLine("Pris kr 638-");
                    }
                    else if (Vægt <= 20000)
                    {
                        Console.WriteLine("Pris kr 790-");
                    }
                }
            }
            else { Console.WriteLine("Max størlse 300 cm Max Vægt 20 kg"); }
        }
        public static void RullestangDK()
        {
            Console.WriteLine("Længde ");
            double RullestangL = double.Parse(Console.ReadLine());

            Console.WriteLine("Højde  ");
            double RullestangB = double.Parse(Console.ReadLine());

            double RullestangSize = (RullestangL * 2) + (RullestangB * 2);

            Console.WriteLine("Vægt i gram");
            double Vægt = double.Parse(Console.ReadLine());

            if (Vægt <= 2000 && RullestangSize <= 104)
            {
                if (Vægt <= 50)
                {
                    Console.WriteLine("Pris kr 9-");
                }
                else if (Vægt <= 100)
                {
                    Console.WriteLine("Pris kr 18-");
                }
                else if (Vægt <= 250)
                {
                    Console.WriteLine("Pris kr 36-");
                }
                else if (Vægt <= 500)
                {
                    Console.WriteLine("Pris kr 45-");
                }
                else if (Vægt <= 1000)
                {
                    Console.WriteLine("Pris kr 54-");
                }
                else if (Vægt <= 2000)
                {
                    Console.WriteLine("Pris kr 54-");
                }
            }
            else if (Vægt > 2000 || RullestangSize >= 105 && RullestangSize >= 300)
            {
                if (Vægt <= 5000)
                {
                    Console.WriteLine("Pris kr 60-");
                }
                else if (Vægt <= 10000)
                {
                    Console.WriteLine("Pris kr 90-");
                }
                else if (Vægt <= 15000)
                {
                    Console.WriteLine("Pris kr 150-");
                }
                else if (Vægt <= 20000)
                {
                    Console.WriteLine("Pris kr 150-");
                }
                else if (Vægt <= 25000)
                {
                    Console.WriteLine("Pris kr 250-");
                }
                else if (Vægt <= 30000)
                {
                    Console.WriteLine("Pris kr 312.50-");
                }
                else if (Vægt <= 35000)
                {
                    Console.WriteLine("Pris kr 350-");
                }
            }
            else
            {
                Console.WriteLine("Max størlse 300 cm Max Vægt 35 kg");
            }
        }
        public static void KaseDK()
        {
            Console.WriteLine("Længde ");
            double KaseL = double.Parse(Console.ReadLine());

            Console.WriteLine("Bredde ");
            double KaseB = double.Parse(Console.ReadLine());

            Console.WriteLine("Højde ");
            double KaseH = double.Parse(Console.ReadLine());

            double KaseSize = KaseL + KaseB + KaseH;

            Console.WriteLine("Vægt i gram");
            double Vægt = double.Parse(Console.ReadLine());

            if (KaseSize <= 90 && Vægt <= 2000)
            {
                if (Vægt <= 50)
                {
                    Console.WriteLine("Pris kr 9-");
                }
                else if (Vægt <= 100)
                {
                    Console.WriteLine("Pris kr 18-");
                }
                else if (Vægt <= 250)
                {
                    Console.WriteLine("Pris kr 36-");
                }
                else if (Vægt <= 500)
                {
                    Console.WriteLine("Pris kr 45-");
                }
                else if (Vægt <= 1000)
                {
                    Console.WriteLine("Pris kr 54-");
                }
                else if (Vægt <= 2000)
                {
                    Console.WriteLine("Pris kr 54-");
                }
            }
            else if (Vægt > 2000 || KaseSize <= 300 && KaseSize > 90)
            {
                if (Vægt <= 5000)
                {
                    Console.WriteLine("Pris kr 60-");
                }
                else if (Vægt <= 10000)
                {
                    Console.WriteLine("Pris kr 90-");
                }
                else if (Vægt <= 15000)
                {
                    Console.WriteLine("Pris kr 150-");
                }
                else if (Vægt <= 20000)
                {
                    Console.WriteLine("Pris kr 150-");
                }
                else if (Vægt <= 25000)
                {
                    Console.WriteLine("Pris kr 250-");
                }
                else if (Vægt <= 30000)
                {
                    Console.WriteLine("Pris kr 312.50-");
                }
                else if (Vægt <= 35000)
                {
                    Console.WriteLine("Pris kr 350-");
                }
            }
            else { Console.WriteLine("Max størlse 300 cm Max Vægt 35 kg"); }
        }
        public static void KaseUD()
        {
            Console.WriteLine("Længde ");
            double L = double.Parse(Console.ReadLine());

            Console.WriteLine("Bredde ");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Højde ");
            double H = double.Parse(Console.ReadLine());

            double Size = L + B + H;

            Console.WriteLine("Vægt i gram");
            double Vægt = double.Parse(Console.ReadLine());

            if (Size <= 90 && Vægt <= 2000)
            {
                if (Vægt <= 50) { Console.WriteLine("Pris kr 27-"); }
                else if (Vægt <= 100)
                {
                    Console.WriteLine("Pris kr 27-");
                }
                else if (Vægt <= 250)
                {
                    Console.WriteLine("Pris kr 54-");
                }
                else if (Vægt <= 500)
                {
                    Console.WriteLine("Pris kr 54-");
                }
                else if (Vægt <= 1000)
                {
                    Console.WriteLine("Pris kr 108-");
                }
                else if (Vægt <= 2000)
                {
                    Console.WriteLine("Pris kr 108-");
                }
            }
            else if (Vægt > 2000 || Size <= 300 && Size > 90)
            {
                Console.WriteLine("1.Posthus\n2.Online ");
                int PostOnl = int.Parse(Console.ReadLine());
                if (PostOnl == 1)
                {
                    if (Vægt <= 5000)
                    {
                        Console.WriteLine("Pris kr 345-");
                    }
                    else if (Vægt <= 10000)
                    {
                        Console.WriteLine("Pris kr 523-");
                    }
                    else if (Vægt <= 15000)
                    {
                        Console.WriteLine("Pris kr 668-");
                    }
                    else if (Vægt <= 20000)
                    {
                        Console.WriteLine("Pris kr 820-");
                    }
                }
                else
                {
                    if (Vægt <= 5000)
                    {
                        Console.WriteLine("Pris kr 315-");
                    }
                    else if (Vægt <= 10000)
                    {
                        Console.WriteLine("Pris kr 493-");
                    }
                    else if (Vægt <= 15000)
                    {
                        Console.WriteLine("Pris kr 638-");
                    }
                    else if (Vægt <= 20000)
                    {
                        Console.WriteLine("Pris kr 790-");
                    }
                }
            }
            else { Console.WriteLine("Max størlse 300 cm Max Vægt 20 kg"); }
        }
    }
}
