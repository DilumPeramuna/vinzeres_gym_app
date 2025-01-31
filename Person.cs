using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_MANAGEMENT_FINALPROJECT
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
                else
                    throw new ArgumentException("Age must be positive.");
            }
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
