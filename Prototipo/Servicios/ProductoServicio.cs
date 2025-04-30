namespace Prototipo.Servicios
{
    public class ProductoServicio : IProductoServicio
    {
        private readonly IProductoRepositorio _productoRepositorio;
        private readonly IProductoValidador _productoValidador;
        public ProductoServicio(IProductoRepositorio productoRepositorio,
            IProductoValidador productoValidador)
        {
            _productoRepositorio = productoRepositorio;
            _productoValidador = productoValidador;
        }
        public bool CrearProducto(Producto producto)
        {
            var resultado = false;
            try
            {
                if(_productoValidador.EsValido(producto) && !_productoRepositorio.Existe(producto.Id))
                {
                    _productoRepositorio.Agregar(producto);
                    resultado = true;
                }
            }
            catch (Exception ex) 
            {
            }
            return resultado;
        }
    }
}
