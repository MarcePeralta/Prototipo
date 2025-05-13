namespace Prototipo.ValidatorModel.Validators;
public class ProductValidator : IProductValidator
{
    public List<ValidationError> Errors { get; private set; }

    public bool Validate(ProductDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Id))
        {
            var error = new ValidationError(dto.Id, string.Format(Messages.Required, dto.Id));
            Errors.Add(error);
            return false;
        }


        if (dto.Id.Trim().Length < 4)
        {
            var error = new ValidationError(dto.Id, string.Format(Messages.MaxLength, dto.Id, 4));
            Errors.Add(error);
            return false;
        }

        return true;
    }
}
