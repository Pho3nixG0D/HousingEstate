﻿using System;
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
        private HousingEstate housingOfBlock;


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
        public HousingEstate HousingOfBlock
        {
            get { return housingOfBlock; }
            set { housingOfBlock = value; }
        }
        //Constructor
        public BlockOfFlats(int numofblock)
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
            string entinblock = String.Empty;
            foreach (var x in this.entrancesInBlock)
            {
                entinblock += x + " ";
            }
            return entinblock;
        }
        //string override tostring

        public override string ToString()
        {
            return String.Format($"Number Of Block: {this.numberOfBlock}\nEntrances in Block:\n {GetInfoAboutBoF()}");
        }


    }
}
