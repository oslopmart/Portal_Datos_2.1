﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalDatos.BL
{
    public class Producto
    {
        public Producto()
        {
            Activo = true;
        }

        public int Id { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Ingrese la Descripcion")]
        [MinLength (3, ErrorMessage = "Ingrese minimo 3 caracteres")]
        [MaxLength (20, ErrorMessage = "Ingrese un maximo de 20 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Ingrese el precio")]
        [Range(0, 1000000, ErrorMessage = "Ingrese un precio entre 0 y 1000000")]
        public double Precio { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }


        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }



        public bool Activo { get; set; }

    }
}
