public class MacBookWithAppleCare(IMacBook macBook) : MackBookDecorator(macBook)
{
    public override string GetDescription()
    {
        return base.GetDescription();
    }

    public override decimal GetPrice()
    {
        return base.GetPrice()+330;
    }

    public override int GetRamSize()
    {
        return base.GetRamSize();
    }

    public override int GetSSDSize()
    {
        return base.GetSSDSize();
    }

    public override string ToString()
    {
        return $"{GetDescription()}, {GetRamSize()}GB Unified Memory, {GetSSDSize()}GB SSD Storage, AppleCare+ (3 Years), Price: ${GetPrice()} \n\n";
    }
}