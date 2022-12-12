using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inhabitants
            Inhabitant lukas = new Inhabitant("Lukas","Cupa",16);
            Inhabitant samo = new Inhabitant("Samo", "Malik", 3);
            Inhabitant romko = new Inhabitant("Roman", "Popper", 30);
            Inhabitant kubko = new Inhabitant("Jakub", "Chalupka", 15);
            Inhabitant marko = new Inhabitant("Marko", "Jantula", 15);
            Inhabitant matus = new Inhabitant("Matus", "Nekoranec", 15);
            Inhabitant misko = new Inhabitant("Michal", "Bernát", 16);

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
            Entrance flatOne = new Entrance()


            //BlocksOfFlats
            BlockOfFlats BoF1 = new BlockOfFlats(1,)





            numOne.AddInhabitant(romko);
            numOne.AddInhabitant(samo);
            numTwo.AddInhabitant(lukas);


            



            Console.WriteLine(numOne.ToString());


            Console.WriteLine(lukas.GetInfoAboutFlat());
        }
    }
}
