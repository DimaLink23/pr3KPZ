using System;
using System.Collections.Generic;
using System.Linq;
///using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using WorkLibrary;

namespace ConsoleApp2
{

    class Program
    {

        static void Main(string[] args)
        {




            List<Worker> objArray = new List<Worker>(10);
            objArray.Add(new Worker("Dawtona", "traktorist", 2300, "Slavko Lubiv", 2010, 11) { });
            objArray.Add(new Worker("Sec.Resp", "director", 0, "Dima Linkevych", 2010, 09) { });
            objArray.Add(new Worker("Apple", "nihto", 1000, "Max Petrunak", 2010, 02) { });
            objArray.Add(new Worker("Apple", "nihto", 1000, "Yura Bobak", 2010, 10) { });
            objArray.Add(new Worker("Maincraft", "nub", 1000, "Dima Ogorodnichuk", 2010, 10) { });
            objArray.Add(new Worker("Maincraft", "VIP", 1000, "Vasuok Mykytuk", 2010, 10) { });
            objArray.Add(new Worker("Microsoft", "coder", 2000, "Sasha Gladunyk", 2010, 10) { });
            objArray.Add(new Worker("Microsoft", "coder", 2000, "Ulyana Babiy", 2010, 05) { });
            objArray.Add(new Worker("Microsoft", "coder", 2000, "Igor Katamaranow", 2010, 12) { });



            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"                                   Меню: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"1) Показати список працівників");
            Console.WriteLine($"2) Показати стаж (в роках, в місяцях)");
            Console.WriteLine($"3) Показати зарплату за всі роки");
            Console.WriteLine($"4) Сортувати за іменами працівників");
            Console.WriteLine($"5) Сортувати за зарплатою");
            Console.WriteLine($"6) Додати працівника");
            Console.WriteLine($"7) Додати працівників");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Введіть номер пункту і натисніть ентер >>>>>");
            Console.ForegroundColor = ConsoleColor.Green;
            int caseSwitch = Convert.ToInt32(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("                      Пункт 1");
                    Console.ForegroundColor = ConsoleColor.Green;

                    Worker objSet2 = new Worker();



                    foreach (Worker p in objArray)

                    {

                        p.PrintWorker();
                        Console.WriteLine("_____________________________________");


                    }

                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("                      Пункт 2");
                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (Worker p in objArray)
                    {
                        p.PrintWorker();
                        p.GetTotalExperience();
                        Console.WriteLine($"_____________________________________");

                    }

                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("                      Пункт 3");
                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (Worker p in objArray)
                    {
                        p.PrintWorker();
                        p.GetTotalMoney();
                        Console.WriteLine($"_____________________________________");

                    }


                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("                      Пункт 4");
                    Console.ForegroundColor = ConsoleColor.Green;

                    Worker objSet3 = new Worker();


                    var result = from objArrays in objArray
                                 orderby objArrays.name
                                 select objArrays;
                    foreach (Worker p in result)
                    {

                        p.PrintWorker();
                        Console.WriteLine("_____________________________________");


                    }
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("                      Пункт 5");
                    Console.ForegroundColor = ConsoleColor.Green;

                    Worker objSet4 = new Worker();


                    var result2 = from objArrays in objArray
                                  orderby objArrays.workPlace.salary
                                  select objArrays;
                    foreach (Worker p in result2)
                    {

                        p.PrintWorker();
                        Console.WriteLine("_____________________________________");


                    }
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("                      Пункт 6");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введіть назву компанії : ");
                    Worker objSet = new Worker();

                    objSet.workPlace._name = Console.ReadLine();
                    Console.WriteLine("Введіть посаду : ");
                    objSet.workPlace._position = Console.ReadLine();
                    Console.WriteLine("Введіть зарплату : ");
                    objSet.workPlace._salary = Convert.ToInt32(Console.ReadLine());

                    objSet.ReadWorkersArray();
                    objArray.Add(objSet);
                    foreach (Worker p in objArray)

                    {

                        p.PrintWorker();
                        Console.WriteLine("_____________________________________");


                    }

                    break;
                case 7:
                    Console.WriteLine("                      Пункт 6");

                    Worker objSet1 = new Worker();

                    objSet1.ReadWorkersArray();
                    objArray.Add(objSet1);
                    foreach (Worker p in objArray)

                    {

                        p.PrintWorkers();
                        Console.WriteLine($"_____________________________________");


                    }

                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }



        }
    }

}
