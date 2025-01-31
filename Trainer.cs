using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_MANAGEMENT_FINALPROJECT
{
    internal class Trainer : Person
    {
        private string trainerId;
        private int experience;

        
        public Trainer( string name, int age, string trainerId, int experience)
            : base( name, age)
        {
            this.Name = name;
            this.Age = age;
            this.trainerId = trainerId;
            this.experience = experience;
            
        }

        public string TrainerId
        {
            get { return trainerId; }
            set { trainerId = value; }
        }

        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }
    }
}
