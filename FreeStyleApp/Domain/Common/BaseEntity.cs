namespace Domain.Common;

public abstract class BaseEntity : AuditableEntity
{
    /// <summary>
    /// Gets or sets a value indicating whether the entity is soft deleted.
    /// </summary>
    public bool IsDeleted { get; set; }
}

/// <summary>
/// Base entity class providing common properties for all domain entities.
/// </summary>
public abstract class BaseEntity<T> : BaseEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the entity.
    /// </summary>
    public T Id { get; set; } = default!;
}