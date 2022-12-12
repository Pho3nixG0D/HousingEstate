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
        //Properties
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
        //Constructor
        public BlockOfFlats(int numofblock, Entrance entinblock)
        {
            this.numberOfBlock = numofblock;
            this.entrancesInBlock.Add(entinblock);
        }
        //Methods
        public void AddEntranceToBlock(Entrance entinblc)
        {
            this.entrancesInBlock.Add(entinblc);
            entinblc.BlockOfFlat = this;
        }

  
    }
}
