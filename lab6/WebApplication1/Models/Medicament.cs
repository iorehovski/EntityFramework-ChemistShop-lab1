﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Medicament
    {
        public Medicament()
        {
            Receptions = new List<Reception>();
            Consumptions = new List<Consumption>();
        }

        public Medicament(string name, string producer, string storage)
        {
            MedicamentName = name;
            Manufacturer = producer;
            Storage = storage;
        }

        public override string ToString()
        {
            return MedicamentName + ";" + Manufacturer + ";" + Storage;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Set Name")]
        public string MedicamentName { get; set; }

        [Required(ErrorMessage = "Set Manufacturer")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Set Storage")]
        public string Storage { get; set; }
        public virtual ICollection<Reception> Receptions { get; set; }
        public virtual ICollection<Consumption> Consumptions { get; set; }
    }
}
