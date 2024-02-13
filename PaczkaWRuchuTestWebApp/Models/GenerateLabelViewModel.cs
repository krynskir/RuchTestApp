using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PaczkaWRuchuTestWebApp.Models
{
    public class GenerateLabelViewModel
    {
        [DisplayName("Punkt odbioru")]
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        public string PickupPoint {  get; set; }

        [DisplayName("Imię")]
        [StringLength(30)]
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        public string FirstName { get; set; }

        [DisplayName("Nazwisko")]
        [StringLength(30)]
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        public string LastName { get; set; }

        [DisplayName("Numer telefonu")]
        [StringLength(9)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        public string PhoneNumber { get; set; }

        [DisplayName("Adres e-mail")]
        [StringLength(60)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        public string SenderEMail { get; set; }

        [DisplayName("Imię")]
        [StringLength(30)]
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        public string SenderFirstName { get; set; }

        [DisplayName("Nazwisko")]
        [StringLength(30)]
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        public string SenderLastName { get; set; }

        [DisplayName("Ulica")]
        [StringLength(30)]
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        public string SenderStreetName { get; set; }

        [DisplayName("Numer budynku")]
        [StringLength(10)]
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        public string SenderBuildingNumber { get; set; }

        [DisplayName("Miasto")]
        [StringLength(30)]
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        public string SenderCity { get; set; }

        [DisplayName("Kod pocztowy")]
        [StringLength(6)]
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        public string SenderPostCode { get; set; }

        [DisplayName("Numer telefonu")]
        [StringLength(9)]
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        public string SenderPhoneNumber { get; set; }

        [DisplayName("Adres do wydruku")]
        [StringLength(1)]
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        public string PrintAdress { get; set; }

        [DisplayName("Wybór etykiety")]
        [StringLength(1)]
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        public string PrintType { get; set; }
    }
}