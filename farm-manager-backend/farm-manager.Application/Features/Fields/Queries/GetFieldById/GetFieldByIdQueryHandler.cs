using AutoMapper;
using farm_manager.Application.Features.Fields.Dtos;
using farm_manager.Application.Interfaces.Persistence;
using MediatR;

namespace farm_manager.Application.Features.Fields.Queries.GetFieldById
{
    public class GetFieldByIdQueryHandler : IRequestHandler<GetFieldByIdQuery, FieldDto?>
    {
        private readonly IFieldRepository _repository;
        private readonly IMapper _mapper;

        public GetFieldByIdQueryHandler(IFieldRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<FieldDto?> Handle(GetFieldByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetByIdAsync(request.Id);

            return result == null ? null : _mapper.Map<FieldDto>(result);

        }
    }
}
