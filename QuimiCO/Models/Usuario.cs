namespace QuimiCO.Models
{
    public class Usuario
    {
        public int idU { get; set; }
        public string nombreU { get; set; }
        public string rut { get; set; }
        public TipoUsuario tipoUsuario { get; set; }
        public string correo { get; set; }
        public string password { get; set; }
    }
    public enum TipoUsuario { ADMINISTRADOR, USUARIO };
}
