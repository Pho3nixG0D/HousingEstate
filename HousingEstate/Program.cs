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

            Inhabitant lukas = new Inhabitant("Lukas","Cupa",15);
            Inhabitant samo = new Inhabitant("Samo", "Malik", 15);
            Inhabitant romko = new Inhabitant("Roman", "Popper", 30);
            Flat numOne = new Flat(1, 50, 3);
            Flat numTwo = new Flat(2, 100, 4);
            numOne.AddInhabitant(romko);
            numOne.AddInhabitant(samo);
            numTwo.AddInhabitant(lukas);


            Console.WriteLine(numOne.ToString());


            Console.WriteLine(lukas.GetInfoAboutFlat());
        }
    }
}
