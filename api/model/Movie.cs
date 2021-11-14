using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using api.Model;

namespace api.Model
{
    public class Movie{
        
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
        
        public virtual List<Category> Categories { get; set; }
    }
}