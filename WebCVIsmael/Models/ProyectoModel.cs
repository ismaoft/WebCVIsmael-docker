namespace WebCVIsmael.Models
{
    public class ProyectoModel
    {
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public List<string>? Tecnologias { get; set; }
        public string? EnlaceGitHub { get; set; }
        public string? EnlaceDemo { get; set; } // Opcional
        public string? ImagenUrl { get; set; }  // Opcional
    }

}
