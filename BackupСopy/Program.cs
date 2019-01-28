using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupСopy
{
    class Program
    {
        static void Main(string[] args)
        {

            double data = 200; // Размер данных
            Flash flash = new Flash();
            DVD dvd = new DVD();
            HDD hdd = new HDD();

           
            while (true)
            {
                Console.WriteLine("1) Использовать USB");
                Console.WriteLine("2) Использовать DVD");
                Console.WriteLine("3) Использовать HDD");
                Console.WriteLine("Введите действие: ");
                string option = Console.ReadLine();
                switch (option)
                {
                    default:
                        break;
                    case "1":
                        {
                           
                            Console.WriteLine("1) Объем");
                            Console.WriteLine("2) Вся информация");
                            Console.WriteLine("3) Оставшаяся память");
                            Console.WriteLine("4) Копия");
                            Console.WriteLine("5) Задать пераметры");
                            Console.WriteLine("Введите действие: ");
                            string option2 = Console.ReadLine();
                            switch (option2)
                            {
                                default:
                                    break;
                                case "1":
                                    {
                                        flash.GetCountMemory();
                                    }
                                    break;
                                case "2":
                                    {
                                        flash.GetInformation();
                                    }
                                    break;
                                case "3":
                                    {
                                        flash.GetEmptyMemory();
                                    }
                                    break;
                                case "4":
                                    {
                                        flash.Copy(data);
                                    }
                                    break;
                                case "5":
                                    {
                                        Console.Write("Введите название USB накопителя: ");
                                        flash.StrogeName = Console.ReadLine();
                                        Console.Write("Введите модель  USB накопителя: ");
                                        flash.ModelStorage = Console.ReadLine();
                                        Console.Write("Введите объем  USB накопителя: ");
                                        flash.Capacity = double.Parse(Console.ReadLine());
                                        Console.Write("Введите скорость  USB накопителя: ");
                                        flash.SpeedUSB = double.Parse(Console.ReadLine());
                                    }
                                    break;
                            }
                        }
                        break;
                    case "2":
                        {

                            Console.WriteLine("1) Объем");
                            Console.WriteLine("2) Вся информация");
                            Console.WriteLine("3) Оставшаяся память");
                            Console.WriteLine("4) Копия");
                            Console.WriteLine("5) Задать пераметры");
                            Console.WriteLine("Введите действие: ");
                            string option2 = Console.ReadLine();
                            switch (option2)
                            {
                                default:
                                    break;
                                case "1":
                                    {
                                        dvd.GetCountMemory();
                                    }
                                    break;
                                case "2":
                                    {
                                        dvd.GetInformation();
                                    }
                                    break;
                                case "3":
                                    {
                                        dvd.GetEmptyMemory();
                                    }
                                    break;
                                case "4":
                                    {
                                        dvd.Copy(data);
                                    }
                                    break;
                                case "5":
                                    {
                                        Console.Write("Введите название диска: ");
                                        dvd.StrogeName = Console.ReadLine();
                                        Console.Write("Введите модель  диска: ");
                                        dvd.ModelStorage = Console.ReadLine();
                                        Console.Write("Введите объем диска: ");
                                        dvd.DvdMemory = double.Parse(Console.ReadLine());
                                        Console.Write("Введите скорость  диска: ");
                                        dvd.SpeedRead = double.Parse(Console.ReadLine());
                                    }
                                    break;
                            }
                        }
                        break;
                    case "3":
                        {
                            Console.WriteLine("1) Объем");
                            Console.WriteLine("2) Вся информация");
                            Console.WriteLine("3) Оставшаяся память");
                            Console.WriteLine("4) Копия");
                            Console.WriteLine("5) Задать пераметры");
                            Console.WriteLine("Введите действие: ");
                            string option2 = Console.ReadLine();
                            switch (option2)
                            {
                                default:
                                    break;
                                case "1":
                                    {
                                        hdd.GetCountMemory();
                                    }
                                    break;
                                case "2":
                                    {
                                        hdd.GetInformation();
                                    }
                                    break;
                                case "3":
                                    {
                                        hdd.GetEmptyMemory();
                                    }
                                    break;
                                case "4":
                                    {
                                        hdd.Copy(data);
                                    }
                                    break;
                                case "5":
                                    {
                                        Console.Write("Введите название HDD: ");
                                        hdd.StrogeName = Console.ReadLine();
                                        Console.Write("Введите модель  HDD: ");
                                        hdd.ModelStorage = Console.ReadLine();
                                        Console.Write("Введите объем HDD: ");
                                        hdd.HddCapacity = double.Parse(Console.ReadLine());
                                        Console.Write("Введите скорость  HDD: ");
                                        hdd.SpeedHDD = double.Parse(Console.ReadLine());
                                    }
                                    break;
                            }
                        }
                        break;
                }
            }

        }
    }
}
