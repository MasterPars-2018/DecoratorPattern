public class MacBook512SSD(IMacBook macBook) : MackBookDecorator(macBook)
{ 
    public override string GetDescription()
    {
        return  base.GetDescription();
    }

    public override decimal GetPrice()
    {
        return base.GetPrice() + 450m;
    }

    public override int GetRamSize()
    {
        return base.GetRamSize();
    }

    public override int GetSSDSize()
    {
        return base.GetSSDSize() + 256;
    }

    public override string ToString()
    {
        return $"{GetDescription()}, {GetRamSize()}GB Unified Memory, {GetSSDSize()}GB SSD Storage, Price: ${GetPrice()} \n\n";
    }
}
