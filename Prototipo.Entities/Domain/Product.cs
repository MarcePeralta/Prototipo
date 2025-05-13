namespace Prototipo.Entities.Domain;
public class Product : Entity
{
    public string Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Existence { get; set; }
    public bool Discontinued { get; set; }
}
