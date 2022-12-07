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

            Person lukas = new Person("Lukas","Cupa",15);
            Person samo = new Person("Samo", "Malik", 15);
            Flat numOne = new Flat(1, 50, 3);

            Console.WriteLine(lukas.ToString());
            Console.WriteLine(numOne.ToString());
        }
    }
}
