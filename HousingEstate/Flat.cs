using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    public class Flat
    {
        //fields
        private int flatNum;
        private int area;
        private int numOfRooms;
        private List<Person> inhabitants = new List<Person>();
        private Entrance entranceOfFlat;


        //properties
        public Entrance EntranceOfFlat
        {
            get { return entranceOfFlat; }
            set { entranceOfFlat = value; }
        }
        public int FlatNum
        {
            get { return flatNum; }
            set { flatNum = value; }
        }
        
        public int Area
        {
            get { return area; }
            set { area = value; }
        }
        public int NumOfRooms
        {
            get { return numOfRooms; }
            set { numOfRooms = value; }
        }

        //constructor

        public Flat(int flatNum, int area, int numOfRooms)
        {
            FlatNum = flatNum;
            Area = area;
            NumOfRooms = numOfRooms;
        }

        //methods
        public void AddInhabitant(Inhabitant inhabitant)
        {
            inhabitants.Add(inhabitant);
            inhabitant.FlatOfPerson = this;
        }
        

        public string GetInfoAboutAllInhabitants()
        {
            string FlatInhabitants = String.Empty;
            foreach (var inh in inhabitants)
            {
                FlatInhabitants += inh + " ";
            }
            return FlatInhabitants;
        }

        //string override
        public override string ToString()
        {
            

           
           return String.Format($"Flat Number: {FlatNum}\nArea: " +
                $"{Area}\nNumber of rooms: {NumOfRooms}\nInhabitants:\n{GetInfoAboutAllInhabitants()}");

        }


    }
}
