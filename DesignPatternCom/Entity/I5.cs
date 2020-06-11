namespace DesignPatternCom.Entity
{
    public class I5 : Sedan
    {
        public I5()
        {
            this.brand = "Rowei I5";
        }

        public I5(string driver) : base(driver)
        {
        }

        public override void MakeUp(string brand)
        {
            throw new System.NotImplementedException();
        }
    }
}