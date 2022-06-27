using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    public class Сharacter
    {
        private double _hp;
        private (double, double) _point;
        private List<Artifact> _artifacts;

        public Сharacter(double hp, (double, double) point, List<Artifact> artifacts)
        {
            _hp = hp;
            _point = point;
            _artifacts = artifacts;
        }

        public void Regeneration()
        {
            this._hp += 10;
        }

        public IMemento Save()
        {
            return new ConcreteMemento(_hp, _point, _artifacts);
        }

        public void Restore(IMemento memento)
        {

            this._hp = memento.GetHp();
            this._point = memento.GetPoint();
            this._artifacts = memento.GetArtifacts();
        }
    }
}
