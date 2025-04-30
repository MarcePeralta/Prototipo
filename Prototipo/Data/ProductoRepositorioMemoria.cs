namespace Prototipo.Data
{
    public class ProductoRepositorioMemoria : IProductoRepositorio
    {
        private readonly List<Producto> _listaProductos;
        public ProductoRepositorioMemoria()
        {
            _listaProductos = new List<Producto>();
        }
        public bool Existe(string id) => _listaProductos.Any(a => a.Id == id);
        public void Agregar(Producto producto) => _listaProductos.Add(producto);

    }
}
