using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public abstract class Animal : IMakeNoise, IMakeTrick
    {
        public int Age { get; protected set; }
        public string Name { get; protected set; }

        public Animal(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public virtual string MakeNoise()
        {
            return string.Format($"My name is {Name}. I'm {Age} old");
        }

        public virtual string MakeTrick()
        {
            return string.Format($"Look at my tricks");
        }
    }
}
