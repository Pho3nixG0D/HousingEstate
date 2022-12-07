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

            Person Lukas = new Person("Lukas","Cupa",15);

            Console.WriteLine(Lukas.ToString());
        }
    }
}
