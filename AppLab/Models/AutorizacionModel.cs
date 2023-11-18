public class AutorizacionModel
{
    public string NOMBREUSUARIO { get; set; }
    public string PERFIL { get; set; } // Aunque es null en la respuesta, se incluye por si acaso
    public string OBSERVACION { get; set; }
    public string CODIGOPERFIL { get; set; } // Aunque es null en la respuesta, se incluye por si acaso
    public string ESTADO { get; set; } // Aunque es null en la respuesta, se incluye por si acaso
    public string COMPANIA { get; set; } // Aunque es null en la respuesta, se incluye por si acaso
    public string Emisor { get; set; } // Aunque es null en la respuesta, se incluye por si acaso
    public string Cargo { get; set; } // Aunque es null en la respuesta, se incluye por si acaso
    public string NOMBREEMISOR { get; set; } // Aunque es null en la respuesta, se incluye por si acaso
    public string NOMBRECOMPANIA { get; set; } // Aunque es null en la respuesta, se incluye por si acaso
    public string USUARIOCLIENTE { get; set; } // Aunque es null en la respuesta, se incluye por si acaso
    public string RucUsuario { get; set; } // Aunque es null en la respuesta, se incluye por si acaso
}
