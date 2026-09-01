namespace QuimiCO.Models
{
    public class RegistroAsistencia
    {
        public int idRA { get; set; }
        public DateTime fecha { get; set; }
        public Horario horario { get; set; }
        public int idUsuario { get; set; }
    }
    public enum Horario { ENTRADA, SALIDA };
}
