using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class Flat
    {
        private int FlatNum { get; set; }
        private int Area { get; set; }
        private int NumOfRooms { get; set; }
        private List<Person> inhabitants = new List<Person>();
        public Flat(int flatNum, int area, int numOfRooms)
        {
            FlatNum = flatNum;
            Area = area;
            NumOfRooms = numOfRooms;
        }
        public void AddInhabitant(Person inhabitant)
        {
            inhabitants.Add(inhabitant);
        }
        public override string ToString()
        {
            string FlatInhabitants = String.Empty;
            foreach (var inh in inhabitants)
            {
                FlatInhabitants += inh + " ";
            }

            return String.Format($"Flat Number: {FlatNum}\nArea: " +
                $"{Area}\nNumber of rooms: {NumOfRooms}\nInhabitants:\n {FlatInhabitants}");

        }


    }
}
