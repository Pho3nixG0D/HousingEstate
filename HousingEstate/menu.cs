using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace HousingEstate
{
   
    public class menu
    {
        public static bool MainMenu()
        {
            HousingEstate housing = new HousingEstate("Kysuce");

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) For create a Block of Flats");
            Console.WriteLine("2) For create Entrance");
            Console.WriteLine("3) For create Flat");
            Console.WriteLine("4) For create Person");
            Console.WriteLine("5) For create Inhabitant");
            Console.WriteLine("6) For show information");
            Console.WriteLine("7) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1": //creating BoF
                    Console.WriteLine("For create a BlockOfFlats, write a number which you want");
                    string objectName = Console.ReadLine();
                    Type type = Type.GetType(objectName);
                    object obj = Activator.CreateInstance(type);
                     obj = new BlockOfFlats(Int32.Parse(objectName));
                    housing.AddBlock((BlockOfFlats)obj);
                    Console.WriteLine("You successfully created a Block of Flats {0}", Int32.Parse(objectName));
                    System.Threading.Thread.Sleep(3000);
                    return true;
                case "2": // creating entrance
                    int entnum, floorsnum = 0;
                    Console.WriteLine("For create an Entrance, write a number which you want for name");
                    entnum = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Set a number of floors");
                    floorsnum = Int32.Parse(Console.ReadLine());
                    Entrance ent = new Entrance(entnum,floorsnum);
                    Console.WriteLine("You successfully created a entrance {0}, with {1} floors", entnum,floorsnum);
                    System.Threading.Thread.Sleep(3000);
                    return true;
                case "3":// creating Flat
                    int flatNum, area, numOfRooms = 0;
                    Console.WriteLine("For create an Flat, write a number which you want for name");
                    flatNum= Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Set area of flat");
                    area= Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Set number of rooms");
                    numOfRooms= Int32.Parse(Console.ReadLine());
                    Flat flt = new Flat(flatNum,area,numOfRooms);
                    Console.WriteLine("You successfully created a Flat {0}, with area of {1} and {2} rooms", flatNum, area, numOfRooms);
                    System.Threading.Thread.Sleep(3000);
                    return true;
                case "4":// Creating Person
                    string fname, lname = String.Empty; int age=0;
                    Console.WriteLine("For create an Person, write a First name");
                    fname = Console.ReadLine();
                    Console.WriteLine("Set Last name");
                    lname = Console.ReadLine();
                    Console.WriteLine("Set person`s age");
                    age= Int32.Parse(Console.ReadLine());
                    Person prs = new Person(fname, lname, age);
                    Console.WriteLine("You successfully created a {0} {1} {2}y.o.",fname,lname,age);
                    System.Threading.Thread.Sleep(3000);
                    return true;
                case "5":// creating inhabitant
                    string ifname, ilname = String.Empty; int iage = 0;
                    Console.WriteLine("For create an Inhabitant, write a First name");
                    ifname = Console.ReadLine();
                    Console.WriteLine("Set Last name");
                    ilname = Console.ReadLine();
                    Console.WriteLine("Set person`s age");
                    iage = Int32.Parse(Console.ReadLine());
                    Person inh = new Person(ifname, ilname, iage);
                    Console.WriteLine("You successfully created a {0} {1} {2}y.o.", ifname, ilname, iage);
                    System.Threading.Thread.Sleep(3000);
                    return true;

                case "6":// show information
                    Console.Clear();
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1) For show a Blocks of Flats");
                    Console.WriteLine("2) For show Entrances in Block of Flats");
                    Console.WriteLine("3) For show Flats in Entrace");
                    Console.WriteLine("4) For show Person");
                    Console.WriteLine("5) For show Inhabitant in Flats");
                    Console.WriteLine("6) Exit");
                    Console.Write("\r\nSelect an option: ");
                    switch (Console.ReadLine())
                    {

                        case "1":
                            Console.WriteLine(housing.ToString());
                            System.Threading.Thread.Sleep(5000);
                            return true;
                        case "2": 
                            return true;
                        case "3": 
                            return true;
                        case "4":
                            return true;
                        case "5":
                            return true;
                        case "6":
                        return false;
                        default: 
                            return true;
                    }
                case "7": //exit
                    return false;
                default:
                    return true;
            }
        }




    }
}
