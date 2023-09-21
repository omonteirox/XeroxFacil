using xeroxFacil.Models.Validators;

namespace xeroxFacil.Models
{
    public abstract class Job : Entity
    {
        public DateTime InitialDate { get; private set; } = DateTime.UtcNow;
        public DateTime? FinalDate { get; set; }
        public bool isDone { get; set; } = false;
        public decimal TotalValue { get; set; }
        public decimal TotalPaid { get; set; }
        public string Description { get; set; }
        public Person Person { get; set; }
        public string ClientCode { get; set; } = String.Empty;

        public void generateClientCode()
        {
            var clientCode = Person.Name[..3] + Id;
            ClientCode = clientCode;
        }
    }
}