using AutoMapper;
using MessageTest.Domain.Entities;
using Site.ViewModels;

namespace Site.AutoMapper
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