using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HousingEstate;


namespace menu
{
    public class MainClass
    {

        public static void printMenu(string[] options)
        {
            Console.Clear();

            foreach (string option in options)
            {
                Console.WriteLine(option);
            }
            Console.Write("Choose your option : ");
        }
        public static void mainmenu(string[] args)
        {
            Housingestate housing = new Housingestate("Kysuce");

            Console.WriteLine("Customization of Housing Estate");
            String[] options = {"1) To create a Block of Flats",
                            "2) To create Entrance",
                            "3) To create Flat",
                            "4) To create Person",
                            "5) To create Inhabitant",
                            "6) To show information",
                            "7) Exit",
                                };

            int option = 0;
            while (true)
            {
                printMenu(options);

                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter a number between 1 and " + options.Length);
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("An unexpected error happened. Please try again");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }
                switch (option)
                {
                    case 1://Bof creating
                        option1(housing);
                        break;
                    case 2://creating entrance
                        int name = 0;
                        Console.WriteLine("Write number of block where you want create Entrance");
                        name = Convert.ToInt32(Console.ReadLine());
                        var pair = housing.Blocks.Select((Value, Index) => new { Value, Index })
                        .Single(p => p.Value.NumberOfBlock == name);
                        option2(housing.Blocks[pair.Index]);
                        break;
                    case 3://creating flat
                        Console.WriteLine("Write number of block where you want to create Flat");
                        name = Convert.ToInt32(Console.ReadLine());
                        var pair2 = housing.Blocks.Select((Value, Index) => new { Value, Index })
                        .Single(p => p.Value.NumberOfBlock == name);
                        Console.WriteLine("Write number of Entrance where you want to create Flat");

                        int name2 = Convert.ToInt32(Console.ReadLine());
                        var pair3 = pair2.Value.EntrancesInBlock.Select((Value, Index) => new { Value, Index })
                        .Single(p => p.Value.NumberOfEntrance == name2);


                        option3(pair2.Value.EntrancesInBlock[pair3.Index]);
                        break;
                    case 4://creating person
                        option4();
                        break;
                    case 5://creatinginhabitant
                        option5();
                        break;
                    case 6://showing informations
                        Console.Clear();
                        System.Threading.Thread.Sleep(1000);
                        String[] options2 = { "1) To show a Blocks of Flats" ,
                            "2) To show Entrances in Block of Flats",
                        "3) To show Flats in Entrace",
                        "4) To show Person",
                        "5) To show Inhabitant in Flats",
                        "6) Exit"};

                        while (true)
                        {
                            printMenu(options2);
                            try
                            {
                                option = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (System.FormatException)
                            {
                                Console.WriteLine("Please enter a number between 1 and " + options2.Length);
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                continue;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("An unexpected error happened. Please try again");
                                System.Threading.Thread.Sleep(1000);
                                Console.Clear();
                                continue;
                            }
                            switch (option)
                            {

                                case 1:
                                    option01(housing);
                                    break;
                                case 2:
                                    name = 0;
                                    Console.WriteLine("Write number of block of flats ");
                                    name = Convert.ToInt32(Console.ReadLine());
                                    var pair1 = housing.Blocks.Select((Value, Index) => new { Value, Index })
                                    .Single(p => p.Value.NumberOfBlock == name);
                                    Console.WriteLine("Write a number of Entrace in BoF");


                                    option02(housing.Blocks[pair1.Index]);
                                    break;
                                case 3:
                                    break;
                                case 4:
                                    break;
                                case 5:
                                    break;
                                case 6:
                                    Environment.Exit(0);
                                    break;
                                default:
                                    break;
                            }

                        }
                    case 7://exit
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter an integer value between 1 and " + options.Length);
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }

            }
        }

        private static void option1(Housingestate housing)
        {
            Console.WriteLine("To create a BlockOfFlats, write a number which you want");
            int objectName = int.Parse(Console.ReadLine());
            housing.AddBlockInHousing(new BlockOfFlats(objectName));
            Console.WriteLine("You successfully created a Block of Flats {0}", objectName);
            System.Threading.Thread.Sleep(3000);
        }
        private static void option2(BlockOfFlats block)
        {
            Console.WriteLine("To create a Entrance, write a number of entrance and number of floors");
            int numOfEnt = int.Parse(Console.ReadLine());
            int NumOfFloors = int.Parse(Console.ReadLine());
            block.AddEntranceToBlock(new Entrance(numOfEnt, NumOfFloors));
            Console.WriteLine("You successfully created an Entrance {0} with {1} floors", numOfEnt, NumOfFloors);
            System.Threading.Thread.Sleep(3000);
        }

        private static void option3(Entrance entrance)
        {

            Console.WriteLine("Finaly, write number of a flat");
            int flatnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Write an area of flat");
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a number of rooms in a flat");
            int numofrooms = int.Parse(Console.ReadLine());
            entrance.AddFlatInEntrance(new Flat(flatnum, area, numofrooms));
            Console.WriteLine("You successfully created a Flat {0} with area of {1} and {2} rooms", flatnum, area, numofrooms);
            System.Threading.Thread.Sleep(3000);

        }
        private static void option4()
        {
            Console.WriteLine("Executing option 1");
        }
        private static void option5()
        {
            Console.WriteLine("Executing option 1");
        }
        private static void option01(Housingestate housing)
        {
            housing.GetInfoAboutBlock();
            //Console.WriteLine(housing.ToString());
            System.Threading.Thread.Sleep(5000);
            Console.ReadLine();

        }
        private static void option02(BlockOfFlats blockOfFlats)
        {
            Console.WriteLine(blockOfFlats.GetInfoAboutBoF());
            System.Threading.Thread.Sleep(5000);
            Console.ReadLine();

        }
        private static void option6()
        {

        }
    }
 }
 

