using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCom.Entity
{
    public class Benz : Car
    {
        public Benz() {
            this.brand = "benz";
        }
        public Benz(string driver) : base(driver)
        {
            this.brand = "benz";
        }

        public override void MakeUp(string brand)
        {
            this.brand = brand;
        }

        public int Weight { get; set; }
    }
}
