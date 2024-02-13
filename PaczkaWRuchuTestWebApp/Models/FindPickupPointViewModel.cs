using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PaczkaWRuchuTestWebApp.Models
{
    public class FindPickupPointViewModel
    {
        [DisplayName("Miasto")]
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        public string City { get; set; }
    }
}
