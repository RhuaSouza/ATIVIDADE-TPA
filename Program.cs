using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_TPA
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c, d, e;
            int pt1, pt2, pt3, pt4, pt5;
            Console.WriteLine("Qual time voce quer?");
            Console.WriteLine("Digite o time: ");
            a = Console.ReadLine();
            Console.WriteLine("De uma pontuaçao para esse time: ");
           pt1 = int.Parse (Console.ReadLine());
            Console.WriteLine("Digite outro time: ");
            b = Console.ReadLine();
            Console.WriteLine("De uma pontuaçao para esse time: ");
            pt2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro time: ");
            c = Console.ReadLine();
            Console.WriteLine("De uma pontuaçao para esse time: ");
            pt3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro time: ");
            d = Console.ReadLine();
            Console.WriteLine("De uma pontuaçao para esse time: ");
            pt4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro time: ");
            e = Console.ReadLine();
            Console.WriteLine("De uma pontuaçao para esse time: ");
            pt5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Os times sao: " +a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.ReadKey();
        }
    }
}
