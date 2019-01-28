using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; // Для  Thread.Sleep(время);
namespace BackupСopy
{
    class DVD : Storage
    {
   
        
   


        private double _speedRead;
        private bool _typeDisk; // тип (односторонний (4.7 Гб) /двусторонний (9 Гб) )
        private double _dvdMemory;
        private double _emptyMemory;

        public double SpeedRead
        {
            get
            {
                return _speedRead;
            }
            set {
                _speedRead = value;
            }
        }

        public double DvdMemory
        {
            get
            {
                return _dvdMemory;
            }
            set
            {
                _dvdMemory = value;
            }
        }

        public bool TypeDisk
        {
            get
            {
                return _typeDisk;
            }
            set
            {
                TypeDisk = value;
            }
        }





        public override void GetCountMemory()
        {
            Console.WriteLine("Объем памяти DVD диска: " + _dvdMemory + " гигабайт");
        }


        public override void Copy(double data)
        {
            Random rand = new Random();
            int n = rand.Next(5, 10);
            for (int i = 0; i < n; i++)
            {
                Thread.Sleep(1000);
                Console.Write("Loading...");
            }

            double subtraction = _dvdMemory - data;
            if (subtraction >= 0)
            {
                Console.WriteLine("Данные перешли на диск");
            }
            else
            {
                Console.WriteLine("Нет места на диске: " + subtraction);
            }
        }
        public override void GetEmptyMemory()
        {
            Console.WriteLine("Осталось места на диске: " + _emptyMemory);
        }
        public override void GetInformation()
        {
            Console.WriteLine("Объем памяти диска: " + _dvdMemory + " гигабайт");
            Console.WriteLine("Скорость: " + _speedRead);
        }

    }
}
