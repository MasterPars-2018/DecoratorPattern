public class BaseMacBook16Ram256SSD : IMacBook
{
    public string GetDescription()
    {
        return """
            Apple 2025 MacBook Air 13-inch Laptop with M4 chip: Built for Apple Intelligence,
            13.6-inch Liquid Retina Display
            """;
    }

    public decimal GetPrice()
    {
        return 1800m;
    }

    public int GetRamSize()
    {
        return 16;
    }

    public int GetSSDSize()
    {
        return 256;
    }

    public override string ToString()
    {
        return $"{GetDescription()}, {GetRamSize()}GB Unified Memory, {GetSSDSize()}GB SSD Storage, ${GetPrice()}  \n\n";
    }
}
