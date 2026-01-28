using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AssetFlow.App.Models
{
    public class Asset
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del activo es obligatorio.")]
        [DisplayName("Nombre del Activo")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Debe asignar una categiría al activo.")]
        [DisplayName("Categoria")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }


        [Required(ErrorMessage = "Indicar la fecha de compra del activo.")]
        [DisplayName("Fecha de Compra")]
        public DateTime PurchaseDate
        {
            get; set;
        }

        [Required(ErrorMessage = "Indicar el estado del activo.")]
        [DisplayName("Estado")]
        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public virtual Status AssetStatus { get; set; }


        [Required(ErrorMessage = "Indicar el estado del activo.")]
        [DisplayName("Costo")]
        public decimal Cost { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
