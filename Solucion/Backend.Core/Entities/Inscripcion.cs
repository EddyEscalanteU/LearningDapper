using System;


namespace Backend.Core.Entities
{
    public class Inscripcion
    {
        public int IdInscripcion { get; set; }
        public int IdMateria { get; set; }
        public int IdEstudiante { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
