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
        public async Task<ActionResult> ManyToManyInsert([FromBody] Movie movie)
        {
            await this._context.Movies.AddAsync(movie);
            await this._context.SaveChangesAsync();
            return Ok();
        }
    }
}