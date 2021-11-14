using System.Collections.Generic;
using System.Threading.Tasks;
using api.Data;
using api.Model;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        
        private readonly DataContext _context;

        public MovieController(DataContext context)
        {
            this._context = context;
        } 

        [HttpPost]
        public async Task<ActionResult> Post(Movie movie)
        {

                movie.Nome = "teste";
                movie.Category = new Category();
                movie.Category.Name = "Category 1";
                await this._context.Movies.AddAsync(movie);
                await this._context.SaveChangesAsync();
                return Ok();
        }

        [HttpPost("categories")]
        public async Task<ActionResult> Post2(Category category)
        {

                category.Name = "Terror";
                category.Movies = new List<Movie>() {
                    new Movie { Nome = "Gedan", Category = category},
                    new Movie { Nome = "Bruno", Category = category},
                    new Movie { Nome = "Barros", Category = category},
                    new Movie { Nome = "Alan", Category = category}
                };
                
                await this._context.Categories.AddAsync(category);
                await this._context.SaveChangesAsync();
                return Ok();
        }
    }
}