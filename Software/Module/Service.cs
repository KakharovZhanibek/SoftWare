using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Module
{
    public class Service
    {
        public List<Free> frees;
        public List<Conditional_Free> conditional_Frees;
        public List<Commercial> commercials;
        public Service()
        {
            frees = new List<Free>();
            conditional_Frees = new List<Conditional_Free>();
            commercials = new List<Commercial>();
        }
        public void Create()
        {
            Free s1 = new Free();
            s1.Name = "Virtual Box";
            s1.Manufacturer = "Oracle";
            frees.Add(s1);

            Free s2 = new Free();
            s2.Name = "TeamViewer";
            s2.Manufacturer = "Permira";
            frees.Add(s2);

            Free s3 = new Free();
            s3.Name = "DropBox";
            s3.Manufacturer = "DropBox Inc.";
            frees.Add(s3);

            Free s4 = new Free();
            s4.Name = "TeamSpeak";
            s4.Manufacturer = "Tihon(разработчик)";
            frees.Add(s4);

            Free s5 = new Free();
            s5.Name = "Adobe Flash Player";
            s5.Manufacturer = "Adobe systems";
            frees.Add(s5);

            Free s6 = new Free();
            s6.Name = "Advanced SystemCare Free";
            s6.Manufacturer = "IObit";
            frees.Add(s6);


            Conditional_Free CF1 = new Conditional_Free(DateTime.Now.AddMonths(-15), DateTime.Now.AddMonths(2));
            CF1.Name = "ViperVPN";
            CF1.Manufacturer = "Golden Frog";
            conditional_Frees.Add(CF1);

            Conditional_Free CF2 = new Conditional_Free(DateTime.Now.AddMonths(-5), DateTime.Now.AddMonths(-2));
            CF2.Name = "ABBYY FineReader";
            CF2.Manufacturer = "ABBYY";
            conditional_Frees.Add(CF2);

            Conditional_Free CF3 = new Conditional_Free(DateTime.Now.AddMonths(-7), DateTime.Now.AddMonths(5));
            CF3.Name = "Avira Phantom VPN";
            CF3.Manufacturer = "Avira";
            conditional_Frees.Add(CF3);

            Conditional_Free CF4 = new Conditional_Free(DateTime.Now.AddMonths(-1).AddDays(6), DateTime.Now.AddMonths(-1).AddDays(24));
            CF4.Name = "Advanced SystemCare Pro";
            CF4.Manufacturer = "IObit";
            conditional_Frees.Add(CF4);

            Conditional_Free CF5 = new Conditional_Free(DateTime.Now, DateTime.Now.AddMonths(2));
            CF5.Name = "Driver Booster";
            CF5.Manufacturer = "IObit";
            conditional_Frees.Add(CF5);


            Commercial C1 = new Commercial(20000, DateTime.Now.AddMonths(-20), DateTime.Now.AddMonths(4));
            C1.Name = "Adobe Photoshop";
            C1.Manufacturer = "Adobe systems";
            commercials.Add(C1);

            Commercial C2 = new Commercial(15250, DateTime.Now.AddMonths(-14), DateTime.Now.AddMonths(-2));
            C2.Name = "Adobe Premier";
            C2.Manufacturer = "Adobe systems";
            commercials.Add(C2);

            Commercial C3 = new Commercial(22670, DateTime.Now.AddMonths(0), DateTime.Now.AddMonths(36));
            C3.Name = "Visual Studio 2017 Professional";
            C3.Manufacturer = "Microsoft";
            commercials.Add(C3);

            Commercial C4 = new Commercial(5500, DateTime.Now.AddMonths(-5), DateTime.Now.AddMonths(7));
            C4.Name = "Express VPN";
            C4.Manufacturer = "Express VPN International Ltd.";
            commercials.Add(C4);

            Commercial C5 = new Commercial(7230, DateTime.Now.AddMonths(-2).AddDays(13), DateTime.Now.AddMonths(1).AddDays(-17));
            C5.Name = "Advanced SystemCare Ultimate";
            C5.Manufacturer = "IObit";
            commercials.Add(C5);
        }
        public void Print()
        {
            Console.WriteLine("----------------Бесплатное----------------");
            foreach (Free item in frees)
            {
                item.PrintInfo();
            }
            Console.WriteLine("\n\n----------------Условно-бесплатное----------------");
            foreach (Conditional_Free item in conditional_Frees)
            {
                item.PrintInfo();
            }
            Console.WriteLine("\n\n-----------------Коммерческое---------------");
            foreach (Commercial item in commercials)
            {
                item.PrintInfo();
            }
            Console.WriteLine("--------------------------------");
        }
        public void Find()
        {
            foreach (Free item in frees)
            {
                item.PrintInfo();
            }
            foreach (Conditional_Free item in conditional_Frees)
            {
                if(item.DateOfExpire>DateTime.Now)
                {
                    item.PrintInfo();
                }
            }
            foreach (Commercial item in commercials)
            {
                if (item.DateOfExpire > DateTime.Now)
                {
                    item.PrintInfo();
                }
            }
        }
    }
}
