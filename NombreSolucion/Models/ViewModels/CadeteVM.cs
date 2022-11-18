

using System.ComponentModel.DataAnnotations;
namespace NombreSolucion.Models
{


    public class CadeteVM
    {

         [Required]
        public int ID;
         [Required] [StringLength(100)]
        public string nombre;
         [StringLength(20)]
        public string Telefono;

    }


}