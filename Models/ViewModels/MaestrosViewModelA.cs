using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mantenimiento.Models.ViewModels
{
    public class MaestrosViewModelA
    {
            public int id { get; set; }
            [Required]
            [StringLength(30)]
            [Display(Name = "apellido")]
            public string apellido { get; set; }
            [Required]
            [StringLength(30)]
            [Display(Name = "nombre")]
            public string nombre { get; set; }
        }
    
}