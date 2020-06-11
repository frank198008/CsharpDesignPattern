using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCom.Entity
{
    public class GeelyCarFactory : CarFactory
    {
        public override Car MakeCar()
        {
            return new Geely();
        }
    }
}
