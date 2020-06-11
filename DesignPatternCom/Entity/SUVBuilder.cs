using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCom.Entity
{
    public class SUVBuilder : CarBuilder
    {
        public override void SetupBody()
        {
            this.Car.BodyWork = "铝合金SUV";
        }

        public override void SetupDispacther()
        {
            this.Car.Dispatcher = "进口AT6";
        }

        public override void SetupEngine()
        {
            this.Car.Engine = "1.6L TSI";
        }

        public override void SetupWheel()
        {
            this.Car.Wheel = "25cm 米其林";
        }
    }
}
