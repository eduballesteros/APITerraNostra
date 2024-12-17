using System;
using System.ComponentModel.DataAnnotations;

namespace TerraNostraAPI.Models
{  
    /// <summary>
    /// Esta clase contiene información detallada del modelo de producto.
    /// <author>ebp - 17/12/2024</author>
    /// </summary>
    public class Producto
    {
        /*
            - id: Clave primaria con autoincremento.
            - nombre: Nombre del producto (campo obligatorio).
            - descripcion: Descripción opcional del producto.
            - precio: Precio del producto (campo obligatorio).
            - stock: Cantidad disponible en inventario (campo obligatorio).
            - imagenUrl: URL a una imagen del producto.
            - categoria: Categoría del producto (ej., "suplementos", "tés", "vitaminas").
            - fechaCreacion: Fecha en que se crea el producto, asignada automáticamente. 
         */

        public long Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        public required string Nombre { get; set; }

        [Required(ErrorMessage ="El precio del producto es obligatorio.")]
        [Range (0.01,double.MaxValue, ErrorMessage ="El precio debe ser mayor que cero")]
        public required double Precio { get; set; }

        [Range (0, double.MaxValue, ErrorMessage ="El stock debe ser un valor positivo.")]
        public int Stock { get; set; }
        public string? ImagenUrl { get; set; }

        [Required(ErrorMessage ="La categoría del producto es obligatoria.")]
        public required string categoria { get; set; }
        public DateTime fecha { get; set; }   = DateTime.Now; 

    }
}
