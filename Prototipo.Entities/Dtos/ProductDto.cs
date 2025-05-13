namespace Prototipo.Entities.Dtos;
public class ProductDto(string id, string name, decimal price, int existence, bool discontinued)
{
    public string Id => id;
    public string Name => name;
    public decimal Price => price;
    public int Existence => existence;
    public bool Discontinued => discontinued;
}
