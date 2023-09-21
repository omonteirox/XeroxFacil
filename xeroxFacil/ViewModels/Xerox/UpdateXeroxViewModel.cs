using System.ComponentModel.DataAnnotations;

namespace xeroxFacil.ViewModels.Xerox
{
    public class UpdateXeroxViewModel
    {
        public string Description { get; set; }

        public int AmountOfPages { get; set; }

        [Required(ErrorMessage = "O campo {2} é obrigatório.")]
        public decimal TotalValue { get; set; }

        public bool IsColorful { get; set; }
    }
}