using AutoMapper;
using farm_manager.Application.Features.Fields.Dtos;
using farm_manager.Application.Interfaces.Persistence;
using MediatR;

namespace farm_manager.Application.Features.Fields.Queries.GetAllFields
{
    public class GetAllFieldsQueryHandler : IRequestHandler<GetAllFieldsQuery, List<FieldDto>>
    {
        private readonly IFieldRepository _repository;
        private readonly IMapper _mapper;

        public GetAllFieldsQueryHandler(IFieldRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<FieldDto>> Handle(GetAllFieldsQuery request, CancellationToken cancellationToken)
        {
            var fields = await _repository.GetAllAsync(cancellationToken);
            return _mapper.Map<List<FieldDto>>(fields);
        }
    }
}
