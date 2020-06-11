using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCom.Entity
{
    public class BuickFactory : AbstractCarFactory
    {
        public override Sedan MakeSedan()
        {
            return new LandCross();
        }

        public override SUV MakeSUV()
        {
            return new EnCore();
        }
    }
}
