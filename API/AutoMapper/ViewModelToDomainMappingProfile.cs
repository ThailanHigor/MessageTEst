using AutoMapper;
using MessageTest.Domain.Entities;
using API.ViewModels;

namespace API.AutoMapper
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