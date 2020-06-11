using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCom.Entity
{
    public abstract class CarBuilder
    {
        private Car _car;

        public Car Car { get => _car; set => _car = value; }

        public abstract void SetupBody();
        public abstract void SetupEngine();
        public abstract void SetupWheel();
        public abstract void SetupDispacther();
    }
}
