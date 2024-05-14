public class Tree : Plant
{
    public double TreeHeight { get; set; }  // Height in meters

    public override string ToString()
    {
        return base.ToString() + $", Height: {TreeHeight} meters";
    }
}
