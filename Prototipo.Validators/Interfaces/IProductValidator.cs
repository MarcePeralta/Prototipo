namespace Prototipo.Validation.Interfaces;
public interface IProductValidator
{
    List<ValidationError> Errors { get; }
    bool Validate(ProductDto dto);
}
