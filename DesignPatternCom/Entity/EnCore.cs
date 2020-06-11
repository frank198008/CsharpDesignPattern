namespace DesignPatternCom.Entity
{
    public class EnCore : SUV
    {
        public EnCore()
        {
            this.brand = "Buick EnCore";
        }

        public EnCore(string driver) : base(driver)
        {
        }

        public override void MakeUp(string brand)
        {
            throw new System.NotImplementedException();
        }
    }
}