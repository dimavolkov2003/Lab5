using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    class ConcreteMemento : IMemento
    {
        private double _hp;
        private (double, double) _point;
        private List<Artifact> _artifacts;
        private DateTime _date;

        public ConcreteMemento(double hp, (double, double) point, List<Artifact> artifacts)
        {
            _hp = hp;
            _point = point;
            _artifacts = artifacts;
            this._date = DateTime.Now;
        }

        public double GetHp()
        {
            return this._hp;
        }
        public (double, double) GetPoint()
        {
            return this._point;
        }
        public List<Artifact> GetArtifacts()
        {
            return this._artifacts;
        }


        public DateTime GetDate()
        {
            return this._date;
        }
    }
}
