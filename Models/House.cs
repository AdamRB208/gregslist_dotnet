using System.ComponentModel.DataAnnotations;

namespace gregslist_dotnet.Models;

public class House
{
  public int Id { get; set; }

  [Range(0, 30)] public int Sqft { get; set; }

  [Range(0, 25)] public int Bedrooms { get; set; }

  [Range(0, 25)] public int Bathrooms { get; set; }

  [Url] public string ImgUrl { get; set; }

  [MinLength(0), MaxLength(500)] public string Description { get; set; }

  [Range(0, 10000000)] public int Price { get; set; }

  public DateTime CreatedAt { get; set; }

  public DateTime UpdatedAt { get; set; }

  [Range(1000, 2024)] public int Year { get; set; }

  [Range(1, 10)] public int Levels { get; set; }

  public string CreatorId { get; set; }

  public Account Creator { get; set; }
}
