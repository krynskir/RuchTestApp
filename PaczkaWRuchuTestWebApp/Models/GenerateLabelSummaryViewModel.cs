using System.ComponentModel;

namespace PaczkaWRuchuTestWebApp.Models
{
    public class GenerateLabelSummaryViewModel
    {
        [DisplayName("Etykieta")]
        public byte[] LabelData { get; set; }
    }
}