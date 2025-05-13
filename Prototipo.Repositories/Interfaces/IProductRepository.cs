namespace Prototipo.Repositories.Interfaces;
public interface IProductRepository
{
    bool Existe(string id);
    void Agregar(Product product);
}
