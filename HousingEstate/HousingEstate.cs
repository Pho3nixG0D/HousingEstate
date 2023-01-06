using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HousingEstate
{
    public class HousingEstate
    {
        //Fields
        private string nameOfHousingEstate;
        private List<BlockOfFlats> blocks = new List<BlockOfFlats>();


        //Properties
        public string NameOfHousingEstate
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

            

     
        public void AddBlockInHousing(BlockOfFlats block)
        {
            this.blocks.Add(block);
            block.HousingOfBlock = this;
        }
         public void GetInfoAboutBlock()
        {
            foreach (var aPart in this.blocks)
            {
                Console.WriteLine(aPart);
            }
            //return String.Format($"Number Of Block: {res}");

        }
  
       /* public override string ToString()
        {
            return ;

        }
        */

    }
}
