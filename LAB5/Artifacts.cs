using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    public abstract class Artifact
    {
        public string Name { get; private set; }
        public Artifact(string name)
        {
            Name = name;
        }
    }
    public class Gun : Artifact
    {
        public double damage;
        public Gun(string name, double damage) : base(name)
        {
            this.damage = damage;
        }

    }
}
