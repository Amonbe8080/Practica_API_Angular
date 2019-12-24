using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore1.Models
{
    [Table("tbl_centros_estudio")]
    public class Centro_estudio
    {
        [Key]
        public int codigo_centro { get; set; }
        public string nombre_centro_estudio { get; set; }
    }
}
