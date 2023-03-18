using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyGeneradorC.Models
{
    [Table("t_taller")]   
    public class Taller
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        public string? nombre { get; set; }

        public string? Descripcion { get; set; }

        public string? horario { get; set; }

        public Decimal PorcentajeDescuento { get; set; }

        public string? ImageName { get; set; }

        public string? Status { get; set; }




    }
}