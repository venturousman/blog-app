namespace Blog.Core.Entities;

public abstract class BaseEntity<T>
{
    public T Id { get; protected set; }
}
