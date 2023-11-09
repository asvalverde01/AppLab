namespace AppLab.Models
{
    public class UsuarioResponse
    {
        public string NOMBREUSUARIO { get; set; }
        public string PERFIL { get; set; }
        public string OBSERVACION { get; set; }
        public int Emisor { get; set; }
        public string NOMBREEMISOR { get; set; }
        // Agrega el resto de las propiedades según la respuesta de la API.
    }
}
