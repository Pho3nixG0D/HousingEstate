using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    public class Entrance
    {
        //Fields
        private int numberOfEntrance;
        private int floorNumber;
        private List<Flat> flatsInEntrance = new List<Flat>();
        //Properties
        public int NumberOfEntrance
        {
            get { return numberOfEntrance; }
            set { numberOfEntrance = value; }
        }

        public int FloorNumber
        {
            get { return floorNumber; }
            set {floorNumber = value;}
        }
        //Constructor
        public Entrance(int numofent, int flnum)
        {
            this.numberOfEntrance = numofent;
            this.floorNumber = flnum;
        } 

        //Methods
        public void AddFlatInEntrance(Flat flt)
        {
            flatsInEntrance.Add(flt);
            
        }
    }
}
