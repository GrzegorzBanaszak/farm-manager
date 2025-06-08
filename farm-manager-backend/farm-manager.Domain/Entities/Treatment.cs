namespace farm_manager.Domain.Entities
{
    //Zabieg
    public class Treatment
    {
        public Guid Id { get; private set; }
        public Guid CropId { get; private set; }
        public string TreatmentType { get; private set; }
        public string? Description { get; private set; }
        public DateTime DatePlanned { get; private set; }
        public DateTime? DatePerformed { get; private set; }
        public string? Notes { get; private set; }

        private Treatment() { }

        public Treatment(Guid id, Guid cropId, string treatmentType, DateTime datePlanned, string? description = null, DateTime? datePerformed = null, string? notes = null)
        {
            Id = id;
            CropId = cropId;
            TreatmentType = treatmentType;
            Description = description;
            DatePlanned = datePlanned;
            DatePerformed = datePerformed;
            Notes = notes;
        }
    }
}
