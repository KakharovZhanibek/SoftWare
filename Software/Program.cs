using Software.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            service.Create();
            while (true)
            {
                Console.WriteLine("1: Вывести информацию\n2: Вывести доступные к использованию\n\n3: Выход\n");
                int x = Int32.Parse(Console.ReadLine());
                if (x == 1)
                {
                    Console.Clear();
                    service.Print();
                    Console.WriteLine("Press any key...");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 2)
                {
                    Console.Clear();
                    service.Find();
                    Console.WriteLine("Press any key...");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 3)
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}
