using System.ComponentModel.DataAnnotations;

namespace databases.Entities;
public class Movie
{
    [Required]
    public string? Title { get; set; }

    [Required]
    public DateTime ReleaseDate { get; set; }

    [Required]
    public Guid Id { get; set; }

    [Required]
    public EGenre Genre { get; set; }

    public string? Description { get; set; }
    
    [Required]
    public double Imdb { get; set; }

    public int  Viewed { get; set; }
    public IFormFile? Image { get; set; }


}