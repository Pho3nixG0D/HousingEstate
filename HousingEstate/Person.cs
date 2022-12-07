using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class Person
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int Age { get; set; }

        /// <summary>
        /// Constructors for Person
        /// </summary>
        public Person(string fname, string lname, int age)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Age = age;
        }

        public override string ToString()
        {
            return String.Format($" First name: {FirstName}\n Last Name: {LastName}\n Age: {Age}\n");
        }
    }
}
