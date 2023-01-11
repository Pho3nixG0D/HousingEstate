using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    public class BlockOfFlats
    {
        //Fields
        private int numberOfBlock;
        private Entrance blockOfEntrance;
        private List<Entrance> entrancesInBlock = new List<Entrance>();
        private Housingestate housingOfBlock;


        //Properties
  
        public List<Entrance> EntrancesInBlock
        {
            get { return entrancesInBlock; }
            set { entrancesInBlock = value; }
        }
        public int NumberOfBlock
        {
            get { return numberOfBlock; }
            set { numberOfBlock = value; }
        }
        public Entrance BlockOfEntrance
        {
            get { return blockOfEntrance; }
            set { blockOfEntrance = value; }
        }
        public Housingestate HousingOfBlock
        {
            get { return housingOfBlock; }
            set { housingOfBlock = value; }
        }
        //Constructor
        public BlockOfFlats( int numofblock)
        {
            this.numberOfBlock = numofblock;
         }
        //Methods
        public void AddEntranceToBlock(Entrance entinblc)
        {
            this.entrancesInBlock.Add(entinblc);
            entinblc.BlockOfFlat = this;
        }


        public string GetInfoAboutBoF()
        {
            string res = "";
            foreach (var aPart in entrancesInBlock)
            {
                res += aPart.ToString();
            }
            return res;
        }
        //string override tostring
       
        public override string ToString()
        {
            return String.Format($"Number Of Block: {this.numberOfBlock}");//Entrances in Block:\n {GetInfoAboutBoF()
        }


    }
}
