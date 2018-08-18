using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Module
{
    public class Free : Software
    {
        public override void PrintInfo()
        {
            Console.WriteLine("\n___________");
            Console.WriteLine("Название : "+Name);
            Console.WriteLine("Производитель : " + Manufacturer);
            Console.WriteLine("___________");
        }
    }
}
