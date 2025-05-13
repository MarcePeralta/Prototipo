namespace Prototipo.Validation.Interfaces;
public interface IModelValidator<T>
{
    public bool Validate(T model);
    List<ValidationError> Errors { get; }
}
