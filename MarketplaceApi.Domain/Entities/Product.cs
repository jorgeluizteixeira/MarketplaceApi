namespace MarketplaceApi.Domain.Entities;

public sealed class Product
{
  public int Id { get; private set; } = 0;
  public string Name { get; private set; } = "";
  public string Description { get; private set; } = "";
  public decimal Price { get; private set; } = 0;
  public int Stock { get; private set; } = 0;
  public string Image { get; private set; } = "";
  public int CategoryId { get; private set; } = 0;

  public Product(string name, string description, decimal price, int stock, string image, int categoryId) {
    Name = name;
    Description = description;
    Price = price;
    Stock = stock;
    Image = image;
    CategoryId = categoryId;
  }

}