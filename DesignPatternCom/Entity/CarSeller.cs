using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCom.Entity
{
    public class CarSeller
    {
        public Car MakeCar(string brand,string driver)
        {
            
            var car = new Benz(driver);
            car.MakeUp("Benz");
            return new Benz(driver);

            //var car = new Geely(driver);
            //car.MakeUp(brand);
            //return new Geely(driver);
            
        }
    }
}
