using farm_manager.Application.Features.Fields.Dtos;
using MediatR;

namespace farm_manager.Application.Features.Fields.Queries.GetAllFields
{
    public record GetAllFieldsQuery() : IRequest<List<FieldDto>>;
}