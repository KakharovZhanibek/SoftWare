using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Module
{
    public class Commercial : Software
    {
        public double Price { get; set; }
        public DateTime DateOfInstall { get; set; }
        public DateTime DateOfExpire { get; set; }


        public Commercial()
        {
            Name = "None";
            Manufacturer = "None";
            Price = 0;
            DateOfInstall = DateTime.Now;
            DateOfExpire = DateTime.Now;
        }
        public Commercial(double Price, DateTime DateOfInstall, DateTime DateOfExpire)
        {
            this.Price = Price;
            this.DateOfInstall = DateOfInstall;
            this.DateOfExpire = DateOfExpire;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("\n___________");
            Console.WriteLine("Название : " + Name);
            Console.WriteLine("Производитель : " + Manufacturer);
            Console.WriteLine("Цена : " + Price);
            Console.WriteLine("Дата установки : " + DateOfInstall);
            Console.WriteLine("Срок бесплатного использования : " + DateOfExpire);
            Console.WriteLine("Состояние : \n");
            if (DateOfExpire > DateTime.Now)
            {
                Console.WriteLine("\tДо конца истечения срока лицензии осталось: " + (DateOfExpire - DateTime.Now).Days + " дней");
            }
            else
            {
                Console.WriteLine("\tСрок лицензии истек!");
            }
            Console.WriteLine("___________");
        }
    }
}
