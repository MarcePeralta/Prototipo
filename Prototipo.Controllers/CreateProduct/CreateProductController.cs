namespace Prototipo.Controllers.CreateProduct
{
    public class CreateProductController(IProductValidator productValidator,
        IProductRepository productRepository) : ICreateProduct
    {
        public bool CreateProduct(ProductDto product)
        {
            var resultado = false;
            try
            {
                var responde = productValidator.Validate(product);
                if (!responde)
                    return resultado;
                        
                if(!productRepository.Existe(product.Id))
                {
                    var newProduct = new Product
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Price = product.Price,
                        Existence = product.Existence,
                        Discontinued = product.Discontinued
                    };
                    productRepository.Agregar(newProduct);
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
