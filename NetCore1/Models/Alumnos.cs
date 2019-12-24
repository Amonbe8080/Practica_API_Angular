using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore1.Models
{
    [Table("tbl_alumnos")]
    public class Alumnos
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public char genero { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public string estado { get; set; }
        public int codigo_carrera { get; set; }
        public int codigo_centro { get; set; }
    }
}
