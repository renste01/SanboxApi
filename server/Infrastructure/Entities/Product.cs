using LinqToDB.Mapping;

namespace Infrastructure.Entities;

[Table(Name = "Products")]
public class Product
{
    [PrimaryKey, Identity]
    public int Id { get; set; }
    
    [Column(Name = "Name"), NotNull]
    public string Name { get; set; }
    
    [Column(Name = "Price"), NotNull]
    public decimal Price { get; set; }
}