using System.ComponentModel.DataAnnotations;

namespace xeroxFacil.ViewModels.Xerox
{
    public class CreateXeroxViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "O campo {1} é obrigatório.")]
        public int AmountOfPages { get; set; }

        [Required(ErrorMessage = "O campo {2} é obrigatório.")]
        public decimal TotalValue { get; set; }

        public bool IsColorful { get; set; } = false;

        [Required(ErrorMessage = "O campo {3} é obrigatório.")]
        public string ClientEmail { get; set; }
    }
}