using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Model
{

    [Table("TbFile")]
    public class File
    {
        [Key]
        [Column("FileId")]
        public int Id { get; set; }

        [Required(ErrorMessage= "Nome obrigatório")]
        public string FileName { get; set; }

        [Required(ErrorMessage="Url obrigatória")]
        public string FileUrl { get; set; }
    }
}