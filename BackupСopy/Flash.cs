using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; // Для  Thread.Sleep(время);
using System.Threading.Tasks;
namespace BackupСopy
{
    class Flash : Storage
    {



        private double _speedUSB;
        private double _usbCapacity;
        private double _emptyMemory;

        public double SpeedUSB
        {
            get
            {
                return _speedUSB;
            }
            set
            {
                _speedUSB = value;
            }
        }

        public double Capacity
        {
            get
            {
                return _usbCapacity;
            }
            set
            {
                _usbCapacity = value;
            }
        }

        public override void GetCountMemory()
        {
            Console.WriteLine("Объем памяти USB накопителя: " + _usbCapacity + " гигабайт");
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

            double subtraction = _usbCapacity - data;
            if (subtraction >= 0)
            {
                Console.WriteLine("Данные перешли на накопитель");
            }
            else
            {
                Console.WriteLine("Нет места на накопителе: " + subtraction);
            }
        }
        public override void GetEmptyMemory()
        {
            Console.WriteLine("Осталось места на флешке: " + _emptyMemory);
        }
        public override void GetInformation()
        {
            Console.WriteLine("Объем памяти USB накопителя: " + _usbCapacity + " гигабайт");
            Console.WriteLine("Скорость: " + _speedUSB);
        }
    }
}
