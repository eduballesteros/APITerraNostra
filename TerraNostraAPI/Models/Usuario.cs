using System;
using System.ComponentModel.DataAnnotations;

namespace TerraNostraAPI.Models
{
    /// <summary>
    /// Esta clase contiene información detallada del modelo de usuario
    /// <author>ebp- 17/12/2024</author>
    /// </summary>
    public class Usuario
    {
        /*
         - id: Identificador único del usuario, es la clave primaria y se genera automáticamente.
         - nombre:Es el nombre completo del usuario. Este campo es obligatorio.
         - correo: Es la dirección de correo electrónico del usuario, que debe ser única en la base de datos. Este campo es obligatorio 
         - contrasena: Es la contraseña cifrada del usuario. Este campo no debe ser nullable = false ya que es un dato crucial para la seguridad del usuario.Este campo es obligatorio.
         - direccion: Es la dirección principal del usuario. Es un campo opcional. 
         - telefono:Número de teléfono del usuario, Este campo es opcional.
         - puntosFidelidad: Número de puntos que el usuario ha acumulado a través de compras.
         - perfilUrl:URL que apunta a la imagen de perfil del usuario. Este campo es opcional.
         - fechaRegistro: Marca el momento en que el usuario fue registrado.
         - esAdmin: Campo booleano para identificar si el usuario tiene privilegios de administrador.
         - activo: Campo booleano que marca si el usuario está activo o desactivado.
         - verificado: Este campo es false cuando el usuario se registra y se marca como true una vez que el usuario confirma su correo electrónico.
         - tokenVerificacion: Es un token único que se genera y se envía al usuario para verificar su correo.
         - fechaTokenExpiracion: Es la fecha en la que el token de verificación expirará y ya no podrá ser utilizado.
         - intentosFallidos: Contabiliza los intentos fallidos de inicio de sesión para implementar mecanismos de seguridad, como bloquear la cuenta después de varios intentos fallidos.

         */

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre de usuario es obligatorio.")]
        public required string Nombre { get; set; }

        [Required(ErrorMessage ="El correo electrónico es obligatorio")]
        [EmailAddress(ErrorMessage ="El correo de electrónico no tiene un formato válido.")]
        public required string Correo { get; set; }

        [Required(ErrorMessage ="La contraseña es obligatoria.")]
        public required string contrasena { get; set; }

        public string? Direccion { get; set; }

        public string? Telefono { get; set; }

        public string? DireccionEntrega { get; set; }

        public int PuntosFidelidad { get; set; }

        public string? PerfilUrl { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public bool EsAdmin { get; set; }

        public bool Activo { get; set; } = true;

        public bool Verificado { get; set; } = false;

        public string? TokenVerificacion { get; set; }

        public DateTime? FechaTokenExpiracion { get; set; }

        public int IntentosFallidos { get; set; }


    }
}
