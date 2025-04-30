
namespace Prototipo.Validador
{
    public class ProductoValidador : IProductoValidador
    {
        public bool EsValido(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Id))
                return false;

            if(producto.Id.Trim().Length < 4)
                return false;

            return true;
        }
    }
}
