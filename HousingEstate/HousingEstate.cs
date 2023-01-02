using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    public class HousingEstate
    {
        //Fields
        private string nameOfHousingEstate;
        private List<BlockOfFlats> blocks = new List<BlockOfFlats>();


        //Properties
        public string NameOfHousingEstete
        {
            get { return nameOfHousingEstate; }
            set { nameOfHousingEstate = value; }

        }
        public List<BlockOfFlats> Blocks
        {
            get { return blocks; }
            set { blocks = value; }
        }


        //constructor 
        public HousingEstate(string nameofhousing)
        {
            this.nameOfHousingEstate= nameofhousing;
            
        }
        //methods 
        public void AddBlock(BlockOfFlats block)
        {
            this.blocks.Add(block);
            block.HousingOfBlock = this;
        }
        public string WriteBlocks()
        {

            string blocksinhousing = String.Empty;
            foreach (var x in this.blocks)
            {
                blocksinhousing += x + " ";
            }
            return blocksinhousing;
        }
        //string override tostring

        public override string ToString()
        {
            return String.Format($"Blocks:\n {WriteBlocks()}");
        }
    
    }
}
