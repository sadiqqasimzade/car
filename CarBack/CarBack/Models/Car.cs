using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBack.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        [Required]
        public bool AutoTransmission { get; set; }
        [Required]
        public bool AirCondition { get; set; }

        [Required]
        public int Luggage { get; set; }
        [Required]
        public int Seats { get; set; }
        [Required]
        public int Doors { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Model { get; set; }

        public string Img { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
    }
}
