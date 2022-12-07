﻿using System;
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

        public override string ToString()
        {
            return String.Format($"Flat Number: {FlatNum}\nArea: {Area}\nNumber of rooms: {NumOfRooms}");
        }


    }
}