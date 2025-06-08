namespace farm_manager.Application.Features.Fields.Dtos
{
    public class FieldDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public double AreaHa { get; set; }
        public string? Location { get; set; }
        public string? SoilType { get; set; }
        public string? Notes { get; set; }
    }
}
