using farm_manager.Application.Features.Fields.Dtos;
using MediatR;

namespace farm_manager.Application.Features.Fields.Queries.GetFieldById
{
    public record GetFieldByIdQuery(
        Guid Id
    ) : IRequest<FieldDto?>;
}
