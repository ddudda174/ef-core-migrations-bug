namespace EFCoreOwnedType.Entities;

public abstract class BaseEntity
{
    public DbId Id        { get; private set; }
    public bool IsDeleted { get; set; }

    protected BaseEntity() { }

    protected BaseEntity(DbId id)
    {
        Id = id;
    }
}
