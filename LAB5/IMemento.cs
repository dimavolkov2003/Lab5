using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    public interface IMemento
    {
        DateTime GetDate();
        double GetHp();
        (double, double) GetPoint();
        List<Artifact> GetArtifacts();

    }
}
