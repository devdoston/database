using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace databases.Dtos; 

public class Movie
{
    [MaxLength(255)]
    public string? Title { get; set; }

    [Range(typeof(DateTime), "1/7/1958","1/7/2023")]
    public DateTime ReleaseDate { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public EGenre Genre { get; set; }
    
    [MaxLength(1024)]
    public string? Description { get; set; }
    
    [Range(1.0,10.0)]
    public double Imdb { get; set; }

    public IFormFile? Image { get; set; }
}