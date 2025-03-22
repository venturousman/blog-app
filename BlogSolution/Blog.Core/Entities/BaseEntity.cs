namespace Blog.Core.Entities;

public abstract class BaseEntity<T>
{
    public T Id { get; protected set; }
    public DateTime CreatedAt { get; protected set; }
    public DateTime? UpdatedAt { get; protected set; }
}
