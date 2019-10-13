using AutoMapper;
using MessageTest.Domain.Entities;
using Site.ViewModels;

namespace Site.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Message, MessageViewModel>();
        }
    }
}