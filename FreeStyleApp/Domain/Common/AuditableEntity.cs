namespace Domain.Common;


/// <summary>
/// Base class for entities that require audit tracking.
/// </summary>
public abstract class AuditableEntity
{
    /// <summary>
    /// Gets or sets the timestamp when the entity was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the timestamp when the entity was last updated.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user who created the entity.
    /// </summary>
    public string? CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user who last updated the entity.
    /// </summary>
    public string? UpdatedBy { get; set; }
}
