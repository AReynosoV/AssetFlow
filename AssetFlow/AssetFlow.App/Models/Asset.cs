using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AssetFlow.App.Models
{
    public class Asset
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Nombre del Activo")]
        public string Name { get; set; }


        [Required]
        [DisplayName("Categoria")]

        public int CategoryId { get; set; }

        [Required]
        [DisplayName("Fecha de Compra")]
        public DateTime PurchaseDate
        {
            get; set;
        }

        [Required]
        [DisplayName("Estado")]
        public string Status { get; set; }

        [Required]
        [DisplayName("Costo")]
        public decimal Cost { get; set; }


    }
}
