namespace DesignPatternCom.Entity
{
    public class RX5 : SUV
    {
        public RX5()
        {
            this.brand = "Rowei RX5";
        }

        public RX5(string driver) : base(driver)
        {
        }

        public override void MakeUp(string brand)
        {
            throw new System.NotImplementedException();
        }


    }
}