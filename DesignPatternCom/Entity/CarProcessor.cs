using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCom.Entity
{
    public class CarProcessor
    {
        public CarBuilder CarBuilder { get; set; }
        public void ProcessCarBuild()
        {
            this.CarBuilder.SetupBody();
            this.CarBuilder.SetupWheel();
            this.CarBuilder.SetupEngine();
            this.CarBuilder.SetupDispacther();
        }
    }
}
