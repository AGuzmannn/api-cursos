using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cursos.Models
{
    [Table("Setores")]
    public class Setor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NomeSetor { get; set; }

        [Required]
        public int GestaoEventoId { get; set; }

        public GestaoEvento GestaoEvento { get; set; }
}

}
