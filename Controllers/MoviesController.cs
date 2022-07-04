using System.Net.Mime;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using databases.Data;
using Microsoft.EntityFrameworkCore;
using databases.Entities;

namespace databases.Controllers;

[ApiController]
[Route("[controller]")]
public class MoviesController : ControllerBase
{
    private readonly AppDbContext _context;
    private ILogger<MoviesController> _logger;

    public MoviesController(ILogger<MoviesController> logger,
                            AppDbContext context)
    {
        _context = context;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _context.Movies.ToListAsync());
    }
    [HttpPost]
    public async Task<IActionResult> Create ([FromForm]Dtos.Movie movie)
    {
        var entity = new Movie()
        {
            Id = Guid.NewGuid(),
            Title = movie.Title,
            ReleaseDate = movie.ReleaseDate,
            Genre = movie.Genre switch
            {
                Dtos.EGenre.Action => EGenre.Action,
                Dtos.EGenre.Adventure => EGenre.Adventure,
                Dtos.EGenre.Comedy => EGenre.Comedy,
                Dtos.EGenre.Fantasy => EGenre.Fantasy,
                Dtos.EGenre.Historical => EGenre.Historical,
                Dtos.EGenre.Horror => EGenre.Horror,
                Dtos.EGenre.Satire => EGenre.Satire,
                Dtos.EGenre.Science_fiction => EGenre.Science_fiction,
                Dtos.EGenre.Thriller => EGenre.Thriller,
            },
            Description = movie.Description,
            Imdb = movie.Imdb,
            };

        await _context.Movies.AddAsync(entity);

        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(Create),movie);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> Get ([FromRoute]Guid Id)
    {
        return Ok(await _context.Movies.FirstOrDefaultAsync(m => m.Id == Id));
    }
     
}