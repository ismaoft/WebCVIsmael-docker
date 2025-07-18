using System.ComponentModel.DataAnnotations;

namespace WebCVIsmael.Models
{
public class ContactoModel
{
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
    [EmailAddress(ErrorMessage = "Debe ser un correo válido.")]
    public string Correo { get; set; }

    [Required(ErrorMessage = "El mensaje es obligatorio.")]
    [StringLength(500, ErrorMessage = "El mensaje no puede tener más de 500 caracteres.")]
    public string Mensaje { get; set; }

    public bool Enviado { get; set; } = false;
}

}
