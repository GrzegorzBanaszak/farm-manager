using farm_manager.Application.Interfaces.Persistence;
using farm_manager.Domain.Entities;
using MediatR;

namespace farm_manager.Application.Features.Fields.Commands.CreateField
{
    public class CreateFieldCommandHandler : IRequestHandler<CreateFieldCommand, Guid>
    {
        private readonly IFieldRepository _repository;

        public CreateFieldCommandHandler(IFieldRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateFieldCommand request, CancellationToken cancellationToken)
        {
            var field = new Field(
            id: Guid.NewGuid(),
            name: request.Name,
            areaHa: request.AreaHa,
            location: request.Location,
            soilType: request.SoilType,
            notes: request.Notes
            );


            await _repository.AddAsync(field);
            await _repository.SaveChangesAsync(cancellationToken);
            return field.Id;
        }
    }
}
