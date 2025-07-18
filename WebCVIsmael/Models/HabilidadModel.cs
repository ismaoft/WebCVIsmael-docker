namespace WebCVIsmael.Models
{
    public class HabilidadModel
    {
        public string? Nombre { get; set; }
        public string? Categoria { get; set; } // Ej: Backend, Frontend, DevOps
        public int Nivel { get; set; } // De 1 a 100 para graficar una barra de progreso
    }

}
