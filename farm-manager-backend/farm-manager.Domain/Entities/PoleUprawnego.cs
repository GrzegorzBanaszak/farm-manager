namespace farm_manager.Domain.Entities
{
    public class PoleUprawnego
    {
        public Guid Id { get; set; }
        public string Nazwa { get; set; } = default!;
        public double PowierzchniaHa { get; set; }
        public string? Opis { get; set; }
    }
}
