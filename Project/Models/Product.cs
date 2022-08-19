namespace Project;

public class Product
{
    public bool IsDeleted { get; set; }
    
    public string Name { get; set; }

    public bool InStock { get; set; }

    public int? Amount
    {
        get => SizesAvailable?.Sum(kv => kv.Value);
    }
    
    public Dictionary<Size, int> SizesAvailable { get; set; }

    public Guid Id { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Id}";
    }
}

public enum Size
{
    XXXS, XXS, XS, S, M, L, XL, XXL, XXXL
}