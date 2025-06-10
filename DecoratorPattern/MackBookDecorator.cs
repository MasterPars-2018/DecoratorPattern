public abstract class MackBookDecorator(IMacBook component) : IMacBook
{
    protected IMacBook _component = component;

    public virtual string GetDescription()
    {
      return   _component.GetDescription();
    }

    public virtual decimal GetPrice()
    {
        return _component.GetPrice();
    }

    public virtual int GetRamSize()
    {
        return _component.GetRamSize();
    }

    public virtual int GetSSDSize()
    {
      return  _component.GetSSDSize();
    }
    public override string ToString()
    {
        return $"{GetDescription()}, {GetRamSize()}GB Unified Memory, {GetSSDSize()}GB SSD Storage, Price: ${GetPrice()}  \n\n";
    }
}
