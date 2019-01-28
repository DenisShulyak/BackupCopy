using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; // Для  Thread.Sleep(время);

namespace BackupСopy
{
    class HDD : Storage
    {
        private double _speedHDD;
        private double _hddCapacity;
        private int _partitionQuantity;
        private double _emptyMemory;


        public double SpeedHDD
        {
            get
            {
                return _speedHDD;
            }
            set
            {
                _speedHDD = value;
            }
        }

        public double HddCapacity
        {
            get
            {
                return _hddCapacity;
            }
            set
            {
                _hddCapacity = value;
            }
        }

        public int PartitionQuantity
        {
            get
            {
                return _partitionQuantity;
            }
            set
            {
                _partitionQuantity = value;
            }
        }

        public double PartitionCapacity
        {
            get
            {
                return _hddCapacity / _partitionQuantity;
            }
        }





        public override void GetCountMemory()
        {
            Console.WriteLine("Объем памяти съемного HDD: " + _hddCapacity + " гигабайт");
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

            double subtraction = _hddCapacity - data;
            if (subtraction >= 0)
            {
                Console.WriteLine("Данные перешли на съемный HDD");
            }
            else
            {
                Console.WriteLine("Нет места на HDD: " + subtraction);
            }
        }
        public override void GetEmptyMemory()
        {
            Console.WriteLine("Осталось места на съемном HDD: " + _emptyMemory);
        }
        public override void GetInformation()
        {
            Console.WriteLine("Объем памяти съемного HDD: " + _hddCapacity + " гигабайт");
            Console.WriteLine("Скорость: " + _speedHDD);
        }

    }

}
