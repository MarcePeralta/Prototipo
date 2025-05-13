namespace Prototipo.Data.DataServices.Product;
public class ProductoRepositorioJson : IProductRepository
{
    private readonly string rutaArchivo;
    private readonly List<Entities.Domain.Product> listProductos;
    public ProductoRepositorioJson()
    {
        rutaArchivo = Path.Combine(AppContext.BaseDirectory, "Content", "Productos.json");
        var contenido = File.ReadAllText(rutaArchivo);
        var productos = JsonSerializer.Deserialize<List<Entities.Domain.Product>>(contenido);
        listProductos = productos ?? new List<Entities.Domain.Product>();
    }

    public void Agregar(Entities.Domain.Product product)
    {
        listProductos.Add(product);
        string json = JsonSerializer.Serialize(listProductos, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(rutaArchivo, json);
    }

    public bool Existe(string id)
    {
        return listProductos.Any(x => x.Id.ToUpper() == id.ToUpper());
    }
}
