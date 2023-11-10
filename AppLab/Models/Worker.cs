namespace AppLab.Models
{
    public class Worker
    {
        public int COMP_Codigo { get; set; }
        public int Id_Trabajador { get; set; }
        public string Tipo_trabajador { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombres { get; set; }
        public string Identificacion { get; set; }
        // ... Agrega el resto de las propiedades según la respuesta de la API.
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaCese { get; set; }
        // ... Agrega el resto de las propiedades de fecha y otros tipos según la respuesta de la API.
    }
}
