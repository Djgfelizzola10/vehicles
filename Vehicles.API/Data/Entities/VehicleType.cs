﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vehicles.API.Data.Entities
{
    public class VehicleType
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de vehiculo")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Description { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }

}

