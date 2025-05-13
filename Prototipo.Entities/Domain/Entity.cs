namespace Prototipo.Entities.Domain;
public class Entity
{
    public string CreatedBy { get; set; }
    public string ModifiedBy { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public bool IsDeleted { get; set; }
}
