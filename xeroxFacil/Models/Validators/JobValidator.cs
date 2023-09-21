using FluentValidation;

namespace xeroxFacil.Models.Validators
{
    public class JobValidator : AbstractValidator<Job>
    {
        public JobValidator()
        {
            RuleFor(x => x.TotalValue).LessThanOrEqualTo(x => x.TotalPaid).WithMessage("O Total não pode ser menor que o Total Pago");
            RuleFor(x => x.FinalDate).GreaterThanOrEqualTo(DateTime.UtcNow);
            RuleFor(x => x.ClientCode).NotEmpty().WithMessage("O código do cliente não foi gerado");
            RuleFor(x => x.TotalPaid).LessThanOrEqualTo(x => x.TotalValue).WithMessage("O valor pago não pode ser maior que o valor total");
            RuleFor(x => x.isDone).Equal(false).When(x => x.TotalValue != x.TotalPaid).WithMessage("Só pode ser concluído quando estiver 100% pago");
        }
    }
}