public class Flower : Plant
{
    public string Color { get; set; }
    public bool IsPerennial { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", Color: {Color}, Perennial: {IsPerennial}";
    }
}
