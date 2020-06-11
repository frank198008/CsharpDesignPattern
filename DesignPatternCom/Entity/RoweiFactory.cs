using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCom.Entity
{
    public class RoweiFactory : AbstractCarFactory
    {
        public override Sedan MakeSedan()
        {
            return new I5();
        }

        public override SUV MakeSUV()
        {
            return new RX5();
        }
    }
}
