public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Description: {Description}";
    }
}

public class CatFood : Product
{
    public bool IsForKittens { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", IsForKittens: {IsForKittens}";
    }
}

