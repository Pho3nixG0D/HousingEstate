using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    public class Entrance
    {
        //Fields
        private int numberOfEntrance;
        private List<Flat> flatsInEntrance = new List<Flat>();
        private BlockOfFlats blockOfFlat;
        //Properties
        public int NumberOfEntrance
        {
            get { return numberOfEntrance; }
            set { numberOfEntrance = value; }
        }

        public BlockOfFlats BlockOfFlat
        {
            get { return blockOfFlat;}
            set { blockOfFlat = value;}
        }
        //Constructor
        public Entrance(int numofent)
        {
            this.numberOfEntrance = numofent;
        } 

        //Methods
        public void AddFlatInEntrance(Flat flt)
        {
            flatsInEntrance.Add(flt);
            flt.EntranceOfFlat = this;
            
        }
        public string GetInfoAboutEntrance()
        {
            string flatInEntrance = string.Empty;
            foreach (var flat in flatsInEntrance)
            {
                flatInEntrance += flat + " ";
            }
            return flatInEntrance;
        }

        //Tostring override
        public override string ToString()
        {
            return String.Format($"Number of Entrance: {this.numberOfEntrance}\n" +
                $"Flats in Entrance:\n {GetInfoAboutEntrance()}");
        }
    }
}
