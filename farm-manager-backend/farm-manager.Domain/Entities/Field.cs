namespace farm_manager.Domain.Entities
{
    //Pole uprawne
    public class Field
    {
        public Guid Id { get; private set; }
        public string Name { get; set; } = default!;
        public double AreaHa { get; set; }
        public string? Location { get; set; }
        public string? SoilType { get; set; }
        public string? Notes { get; set; }
        private readonly List<Crop> _crops = new();
        public IReadOnlyCollection<Crop> Crops => _crops.AsReadOnly();

        private Field() { }

        public Field(Guid id, string name, double areaHa, string? location, string? soilType, string? notes)
        {
            Id = id;
            Name = name;
            AreaHa = areaHa;
            Location = location;
            SoilType = soilType;
            Notes = notes;
        }

        public void AddCrop(Crop crop)
        {
            _crops.Add(crop);
        }
    }
}
