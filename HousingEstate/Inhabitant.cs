using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    public class Inhabitant : Person
    {
        //Fields
        private Flat flatOfPerson;

        public Inhabitant(string fname, string lname, int age) : base(fname, lname, age)
        {
        }

        //Properties
        public Flat FlatOfPerson
        {
            get { return flatOfPerson; }
            set { flatOfPerson = value; }
        }


        //Methods
        public string GetInfoAboutFlat()
        {
            return this.flatOfPerson.ToString();
        }


    }
}
