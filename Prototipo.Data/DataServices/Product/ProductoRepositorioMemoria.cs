namespace Prototipo.Data.DataServices.Product;
public class ProductoRepositorioMemoria(IRepository<Entities.Domain.Product> repository) : IProductRepository
{
    private readonly List<Entities.Domain.Product> ListProducts = new List<Entities.Domain.Product>();
    public void Agregar(Entities.Domain.Product product) 
    {
        repository.Add(product);
        ListProducts.Add(product);
    } 
    public bool Existe(string id)
    {
        return ListProducts.Any(a => a.Id == id);
    } 
}
