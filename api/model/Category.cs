using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }

        public virtual List<Movie> Movies { get; set; }
    }
}