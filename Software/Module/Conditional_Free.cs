using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Module
{
    public class Conditional_Free : Software
    {
        public DateTime DateOfInstall { get; set; }
        public DateTime DateOfExpire { get; set; }
        public Conditional_Free()
        {
            Name = "None";
            Manufacturer = "None";
            DateOfInstall = DateTime.Now;
            DateOfExpire = DateTime.Now;
        }
        public Conditional_Free(DateTime DateOfInstall,DateTime DateOfExpire)
        {
            this.DateOfInstall = DateOfInstall;
            this.DateOfExpire = DateOfExpire;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("\n___________");
            Console.WriteLine("Название : " + Name);
            Console.WriteLine("Производитель : " + Manufacturer);
            Console.WriteLine("Дата установки : " + DateOfInstall);
            Console.WriteLine("Срок бесплатного использования : " + DateOfExpire);
            Console.WriteLine("Состояние :\n");
            if (DateOfExpire > DateTime.Now)
            {
                Console.WriteLine("\tДо конца срока бесплатного использования осталось: " + (DateOfExpire - DateTime.Now).Days+" дней");
            }
            else
            {
                Console.WriteLine("\tСрок бесплатного использования истек!");
            }
            Console.WriteLine("___________");
        }
    }
}
