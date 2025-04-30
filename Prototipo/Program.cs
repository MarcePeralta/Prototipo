var services = new ServiceCollection().AddServices();
var serviceProvider = services.BuildServiceProvider();
var productoServicio = serviceProvider.GetRequiredService<IProductoServicio>();

Producto producto = new Producto { Id = "AB12345", Nombre="Taza", Precio=120, Existencia =20, Descontinuada = false };

NuevoProducto(producto);
NuevoProducto(producto);

void NuevoProducto(Producto producto)
{
    var creado = productoServicio.CrearProducto(producto);
    Console.WriteLine(creado);
}


