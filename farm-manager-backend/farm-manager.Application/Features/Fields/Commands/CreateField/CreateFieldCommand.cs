using MediatR;

namespace farm_manager.Application.Features.Fields.Commands.CreateField
{
    public record CreateFieldCommand(
    string Name,
    double AreaHa,
    string? Location,
    string? SoilType,
    string? Notes
) : IRequest<Guid>;
}
