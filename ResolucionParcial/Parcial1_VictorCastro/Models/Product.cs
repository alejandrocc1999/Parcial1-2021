using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Parcial1_VictorCastro.Models
{
    public class Product
    {
        [Key]
        [Range(1,99999)]
        public int ProductId { get; set; }

        [StringLength(30,MinimumLength = 2)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string Description { get; set; }

        [DataType(DataType.Currency)]  
        [Required(ErrorMessage = "You must enter the field {0}")]
        public float Price { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime Date { get; set; }


    }
}