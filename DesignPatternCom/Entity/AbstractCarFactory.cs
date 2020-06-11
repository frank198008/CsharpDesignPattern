using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCom.Entity
{
    public abstract class AbstractCarFactory
    {
        public abstract SUV MakeSUV();
        public abstract Sedan MakeSedan();
    }
}
