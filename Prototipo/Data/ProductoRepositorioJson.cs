namespace Prototipo.Data
{
    public class ProductoRepositorioJson : IProductoRepositorio
    {
        private readonly string _rutaArchivo;
        private readonly List<Producto> _listProductos;
        public ProductoRepositorioJson()
        {
            _rutaArchivo = Path.Combine(AppContext.BaseDirectory, "Content", "Productos.json");
            var contenido = File.ReadAllText(_rutaArchivo);
            var productos = JsonSerializer.Deserialize<List<Producto>>(contenido);
            _listProductos = productos?? new List<Producto>();
        }
        public void Agregar(Producto producto)
        {
            _listProductos.Add(producto);
            string json = JsonSerializer.Serialize(_listProductos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_rutaArchivo, json);
        }

        public bool Existe(string id)
        {
            return _listProductos.Any(x => x.Id.ToUpper() == id.ToUpper());
        }
    }
}
