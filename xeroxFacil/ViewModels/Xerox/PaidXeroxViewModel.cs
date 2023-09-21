using System.ComponentModel.DataAnnotations;

namespace xeroxFacil.ViewModels.Xerox
{
    public class PaidXeroxViewModel
    {
        [Required(ErrorMessage = "Precisa ser pago")]
        public decimal PaidValue { get; set; }
    }
}