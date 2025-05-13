HostApplicationBuilder Builder = Host.CreateApplicationBuilder();
Builder.Services.AddSingleton(typeof(IRepository<>),typeof(Repository<>));
Builder.Services.AddSingleton<IProductRepository, ProductoRepositorioJson>();
Builder.Services.AddSingleton<IProductValidator, ProductValidator>();
Builder.Services.AddSingleton<ICreateProduct, CreateProductController>();

using IHost AppHost = Builder.Build();
var productoServicio = AppHost.Services.GetRequiredService<ICreateProduct>();
ProductDto product = new ProductDto(id: "AB12345", name: "Taza", price: 120, existence: 20, discontinued: false);

NuevoProducto(product);
NuevoProducto(product);

void NuevoProducto(ProductDto producto)
{
    var creado = productoServicio.CreateProduct(producto);
    Console.WriteLine(creado);
}
AppHost.Run();