using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCom.Entity
{
    public abstract class Car
    {
        protected string brand;
        protected string driver;
        public Car() { }
        public Car(string driver)
        {
            this.driver = driver;
        }

        public void Drive()
        {
            if (string.IsNullOrEmpty(this.driver))
            {
                Console.WriteLine($"a {brand} car was drvied");
            }
            else
            {
                Console.WriteLine($"{driver} drive a {brand}");
            }
        }

        public abstract void MakeUp(string brand);

        private string _engine;
        private string _dispatcher;
        private string _wheel;
        private string _bodyWork;

        public string Engine { get => _engine; set => _engine = value; }
        public string Dispatcher { get => _dispatcher; set => _dispatcher = value; }
        public string Wheel { get => _wheel; set => _wheel = value; }
        public string BodyWork { get => _bodyWork; set => _bodyWork = value; }


        public override string ToString()
        {
            return $"a {this.brand} builded with {this._bodyWork} 车身 {this._engine} 发动机 {this._dispatcher} 离合器 {this._wheel} 轮胎 ";
        }
    }
}
