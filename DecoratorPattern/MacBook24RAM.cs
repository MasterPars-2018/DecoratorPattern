public class MacBook24RAM(IMacBook macBook) : MackBookDecorator(macBook)
{
    public override string GetDescription()
    {
        return base.GetDescription() ;
    }

    public override decimal GetPrice()
    {
        return base.GetPrice()+900;
    }

    public override int GetRamSize()
    {
        return base.GetRamSize() + 8;
    }

    public override int GetSSDSize()
    {
        return base.GetSSDSize();
    }

    public override string ToString()
    {
        return $"{base.GetDescription()}, {GetRamSize()}GB Unified Memory, {GetSSDSize()}GB SSD Storage, Price: ${GetPrice()} \n\n";
    }
}