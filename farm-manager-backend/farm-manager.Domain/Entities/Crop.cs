namespace farm_manager.Domain.Entities
{
    // Uprawa
    public class Crop
    {
        public Guid Id { get; private set; }
        public Guid FieldId { get; private set; }
        public string PlantName { get; set; } = default!;
        public string? Variety { get; set; }
        public DateTime SowingDate { get; set; }
        public DateTime? ExpectedHarvestDate { get; set; }

        private readonly List<Treatment> _treatments = new();
        public IReadOnlyCollection<Treatment> Treatments => _treatments.AsReadOnly();

        private readonly List<Yield> _yields = new();
        public IReadOnlyCollection<Yield> Yields => _yields.AsReadOnly();


        private Crop() { }

        public Crop(Guid id, Guid fieldId, string plantName, string? variety, DateTime sowingDate, DateTime? expectedHarvestDate)
        {
            Id = id;
            FieldId = fieldId;
            PlantName = plantName;
            Variety = variety;
            SowingDate = sowingDate;
            ExpectedHarvestDate = expectedHarvestDate;
        }

        public void AddTreatment(Treatment treatment) => _treatments.Add(treatment);
        public void AddYield(Yield yield) => _yields.Add(yield);
    }
}
