using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    public class Person
    {
        //fields
        private string firstName;
        private string lastName;
        private int age;
        private Flat flatOfPerson;
        //properties

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int Age { get { return age; } set { age = value; } }
        public Flat FlatOfPerson { get { return flatOfPerson; } set { flatOfPerson = value; } }
        //constructors
        public Person(string fname, string lname, int age)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Age = age;
        }
        //methods
        public string GetInfoAboutFlat()
        {
            return this.flatOfPerson.ToString();
        }
        //string override
        public override string ToString()
        {
            return String.Format($" First name: {FirstName}\n Last Name: {LastName}\n Age: {Age}\n");
        }
    }
}
