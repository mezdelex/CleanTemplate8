namespace Domain.Entities;

public class Expense : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public double Value { get; set; }
    public Guid CategoryId { get; set; }

    public virtual Category Category { get; set; } = default!;
}
