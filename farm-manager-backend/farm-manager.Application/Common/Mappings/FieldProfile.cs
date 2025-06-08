using AutoMapper;
using farm_manager.Application.Features.Fields.Dtos;
using farm_manager.Domain.Entities;

namespace farm_manager.Application.Common.Mappings
{
    public class FieldProfile : Profile
    {
        public FieldProfile()
        {
            CreateMap<Field, FieldDto>();
        }
    }
}
