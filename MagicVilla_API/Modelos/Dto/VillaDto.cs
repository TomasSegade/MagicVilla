using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Modelos.Dto
{
    public class VillaDto
    {
        //En esta clase pongo los datos que quiero exponer cuando llamo al controlador
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }

        public int Ocupantes { get; set; }
        public int MetrosCuadrados { get; set; }
    }
}
