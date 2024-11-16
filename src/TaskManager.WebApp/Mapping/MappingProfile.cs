using AutoMapper;
using TaskManager.Entities;
using TaskManager.ViewModels.Account;

namespace TaskManager.WebApp.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<RegisterVM, User>()
                .ForMember(user => user.UserName, opt => opt.MapFrom(src => src.Login))
                .ForMember(user => user.DisplayName, opt => opt.MapFrom(src => src.Name));
        }
    }
}
