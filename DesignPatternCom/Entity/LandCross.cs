namespace DesignPatternCom.Entity
{
    public class LandCross : Sedan
    {
        public LandCross()
        {
            this.brand = "Buick LandCross";
        }

        public LandCross(string driver) : base(driver)
        {
        }

        public override void MakeUp(string brand)
        {
            throw new System.NotImplementedException();
        }
    }
}