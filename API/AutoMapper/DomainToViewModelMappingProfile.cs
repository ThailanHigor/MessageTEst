using AutoMapper;
using MessageTest.Domain.Entities;
using API.ViewModels;

namespace API.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings";  }
        }

        public DomainToViewModelMappingProfile()
        {
            CreateMap<MessageViewModel, Message>();
        }

    }
}