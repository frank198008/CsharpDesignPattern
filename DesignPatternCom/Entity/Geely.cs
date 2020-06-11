using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCom.Entity
{
    public class Geely : Car
    {
        public Geely()
        {
            this.brand = "geely";
        }
        public Geely(string driver) : base(driver)
        {
            this.brand = "geely";
        }

        public override void MakeUp(string brand)
        {
            this.brand = brand;
        }
    }
}
