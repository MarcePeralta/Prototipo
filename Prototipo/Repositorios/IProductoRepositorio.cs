namespace Prototipo.Repositorio
{
    public interface IProductoRepositorio
    {
        bool Existe(string id);
        void Agregar(Producto producto);
    }
}
