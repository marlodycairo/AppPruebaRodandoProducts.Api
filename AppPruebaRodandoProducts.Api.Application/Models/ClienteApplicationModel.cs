﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppPruebaRodandoProducts.Api.Application.Models
{
    public class ClienteApplicationModel
    {
        [Required(ErrorMessage = "Campo obligatorio. Debe ingresar un nombre.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio. Debe ingresar un apellido.")]
        public string Apellido { get; set; }

        [Key]
        [Required(ErrorMessage = "Campo obligatorio. Debe ingresar una identificación")]
        public int Identificacion { get; set; }
        public string Direccion { get; set; }
    }
}
