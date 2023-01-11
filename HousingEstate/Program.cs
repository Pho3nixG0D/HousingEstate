
namespace HousingEstate
{
    public class Program
    {

        static void Main(string[] args)
        {
            menu.MainClass.printMenu(args);
            menu.MainClass.mainmenu(args);




            /*
                        bool showMenu = true;
                        while (showMenu)
                        {
                            showMenu = menu.MainMenu();
                        }
                    HousingEstate housing = new HousingEstate("Kysuce");*/
            /*
        public HousingEstate Housing { get { return housing; } set { housing = value; } }
        public static bool MainMenu()
        {

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
                case "1":
                    //creating BoF


                    return true;

                case "2": // creating entrance
                    int entnum, floorsnum = 0;
                    Console.WriteLine("For create an Entrance, write a number which you want for name");
                    entnum = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Set a number of floors");
                    floorsnum = Int32.Parse(Console.ReadLine());
                    Entrance ent = new Entrance(entnum, floorsnum);
                    Console.WriteLine("You successfully created a entrance {0}, with {1} floors", entnum, floorsnum);
                    System.Threading.Thread.Sleep(3000);
                    return true;
                case "3":// creating Flat
                    int flatNum, area, numOfRooms = 0;
                    Console.WriteLine("For create an Flat, write a number which you want for name");
                    flatNum = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Set area of flat");
                    area = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Set number of rooms");
                    numOfRooms = Int32.Parse(Console.ReadLine());
                    Flat flt = new Flat(flatNum, area, numOfRooms);
                    Console.WriteLine("You successfully created a Flat {0}, with area of {1} and {2} rooms", flatNum, area, numOfRooms);
                    System.Threading.Thread.Sleep(3000);
                    return true;
                case "4":// Creating Person
                    string fname, lname = String.Empty; int age = 0;
                    Console.WriteLine("For create an Person, write a First name");
                    fname = Console.ReadLine();
                    Console.WriteLine("Set Last name");
                    lname = Console.ReadLine();
                    Console.WriteLine("Set person`s age");
                    age = Int32.Parse(Console.ReadLine());
                    Person prs = new Person(fname, lname, age);
                    Console.WriteLine("You successfully created a {0} {1} {2}y.o.", fname, lname, age);
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
                            Console.WriteLine(Option01());
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




        //menu methods
        public void Option1()
        {

            Console.WriteLine("For create a BlockOfFlats, write a number which you want");
            int objectName = int.Parse(Console.ReadLine());
            housing.AddBlockInHousing(new BlockOfFlats(objectName));
            Console.WriteLine("You successfully created a Block of Flats {0}", objectName);
            System.Threading.Thread.Sleep(3000);

        }
        public void Option01()
        {
            housing.GetInfoAboutBlock();
            //Console.WriteLine(housing.ToString());
            System.Threading.Thread.Sleep(5000);
            Console.ReadLine();

        }*/
            /*
            //inhabitants
            Inhabitant lukas = new Inhabitant("Lukas","Cupa",16);
            Inhabitant samo = new Inhabitant("Samo", "Malik", 3);
            Inhabitant romko = new Inhabitant("Roman", "Popper", 28);
            Inhabitant kubko = new Inhabitant("Jakub", "Chalupka", 15);
            Inhabitant marko = new Inhabitant("Marko", "Jantula", 16);
            Inhabitant matus = new Inhabitant("Matus", "Nekoranec", 15);
            Inhabitant misko = new Inhabitant("Michal", "Bernát", 16);
            Inhabitant jozko = new Inhabitant("Jozo", "SpodOravy", 16);
            Inhabitant peto = new Inhabitant("Peter", "Odrobinak", 3);
            Inhabitant sameAsRoman = new Inhabitant("Martin", "Popper", 28);
            Inhabitant jakub = new Inhabitant("Jakub", "Mikus", 15);


            //flats
            Flat numOne = new Flat(1, 50, 3);
            Flat numTwo = new Flat(2, 100, 4);
            Flat numThree = new Flat(3, 50, 3);
            Flat numFour = new Flat(4, 100, 4);
            Flat numFive = new Flat(5, 50, 3);
            Flat numSix = new Flat(6, 100, 4);
            Flat numSeven = new Flat(7, 50, 3);
            Flat numEight = new Flat(8, 100, 4);
            Flat numNine = new Flat(9, 50, 3);
            Flat numTen = new Flat(10, 100, 4);
            Flat numEleven = new Flat(11, 50, 3);
            Flat numTwelve = new Flat(12, 100, 4);
            Flat numThirteen = new Flat(13, 50, 3);
            Flat numFourteen = new Flat(14, 100, 4);
            //Entrances
            Entrance entOne = new Entrance(1);
            Entrance entTwo = new Entrance(2);
            Entrance entThree = new Entrance(3);
            //BlocksOfFlats
            BlockOfFlats BoF1 = new BlockOfFlats(1);
            BlockOfFlats BoF2 = new BlockOfFlats(2);

            numOne.AddInhabitant(lukas);
            numOne.AddInhabitant(samo);
            numTwo.AddInhabitant(romko);
            numThree.AddInhabitant(kubko);
            numFour.AddInhabitant(marko);
            numFive.AddInhabitant(matus);
            numSix.AddInhabitant(misko);
            numSeven.AddInhabitant(jozko);
            numEight.AddInhabitant(peto);
            numNine.AddInhabitant(sameAsRoman);
            numTen.AddInhabitant(jakub);

            entOne.AddFlatInEntrance(numOne);
            entOne.AddFlatInEntrance(numTwo);
            entOne.AddFlatInEntrance(numThree);
            entTwo.AddFlatInEntrance(numFour);
            entTwo.AddFlatInEntrance(numNine);
            entThree.AddFlatInEntrance(numFive);
            entThree.AddFlatInEntrance(numSix);
            entThree.AddFlatInEntrance(numSeven);
            entThree.AddFlatInEntrance(numEight);
            entThree.AddFlatInEntrance(numTen);

            BoF1.AddEntranceToBlock(entOne);
            BoF2.AddEntranceToBlock(entTwo);
            BoF2.AddEntranceToBlock(entThree);

            Console.WriteLine(BoF1);
            //Console.WriteLine(BoF2);

            */




        }
    }
}

