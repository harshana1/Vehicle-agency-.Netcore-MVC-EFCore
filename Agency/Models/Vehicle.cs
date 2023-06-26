using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Agency.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name ="Vehicle Name")]
        [DataType(DataType.Text)]

        public string? VehicleName { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Brand Name")]
        [DataType(DataType.Text)]
        public string Brand { get; set; }

        [Required]
        [Display(Name = "Vehicle Value")]
        [DataType(DataType.Currency)]
        public int Value { get; set; }
    }
}
