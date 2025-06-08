namespace farm_manager.Domain.Entities
{
    // Zbiór plonów
    public class Yield
    {
        public Guid Id { get; private set; }
        public Guid CropId { get; private set; }
        public DateTime DateHarvested { get; private set; }
        public double AmountTons { get; private set; }
        public string? QualityNotes { get; private set; }

        private Yield() { }

        public Yield(Guid id, Guid cropId, DateTime dateHarvested, double amountTons, string? qualityNotes = null)
        {
            Id = id;
            CropId = cropId;
            DateHarvested = dateHarvested;
            AmountTons = amountTons;
            QualityNotes = qualityNotes;
        }
    }
}
