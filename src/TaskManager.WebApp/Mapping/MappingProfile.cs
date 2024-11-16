using AutoMapper;
using TaskManager.Entities;
using TaskManager.Entities.Views;
using TaskManager.ViewModels;

namespace TaskManager.WebApp.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<RegisterVM, User>()
                .ForMember(user => user.UserName, opt => opt.MapFrom(src => src.Login))
                .ForMember(user => user.DisplayName, opt => opt.MapFrom(src => src.Name))
                .ForMember(user => user.CreatedDateTimeUTC, opt => opt.MapFrom(dto => DateTime.UtcNow))
                .ForMember(user => user.UpdatedDateTimeUTC, opt => opt.MapFrom(dto => DateTime.UtcNow));

            CreateMap<WorkTaskView, WorkTaskTableVM>()
                .ForMember(dto => dto.CreatedDateTimeUTC, opt => opt.MapFrom(src => src.CreatedDateTimeUTC.ToShortDateString()))
                .ForMember(dto => dto.ClosedDateTimeUTC, opt =>
                    opt.MapFrom(src => src.ClosedDateTimeUTC.HasValue ? src.ClosedDateTimeUTC.Value.ToShortDateString() : "Not closed yet"))
                .ForMember(dto => dto.FactedTimeSpan, opt =>
                    opt.MapFrom(src => src.FactedTimeSpan.HasValue ? src.FactedTimeSpan.Value.TotalHours.ToString("0.00") : "-"));
        }
    }
}
