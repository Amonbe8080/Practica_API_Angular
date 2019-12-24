using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore1.Models
{
    [Table("tbl_carreras")]
    public class Carreras
    {
        [Key]
        public int codigo_carrera { get; set; }
        public string nombre_carrera { get; set; }
        public int cantidad_asignaturas { get; set; }
    }
}
