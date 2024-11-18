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
            CreateMap<User, UserGetVM>().ReverseMap();
            CreateMap<RegisterVM, User>()
                .ForMember(user => user.UserName, opt => opt.MapFrom(src => src.Login))
                .ForMember(user => user.DisplayName, opt => opt.MapFrom(src => src.Name))
                .ForMember(user => user.CreatedDateTimeUTC, opt => opt.MapFrom(dto => DateTime.UtcNow))
                .ForMember(user => user.UpdatedDateTimeUTC, opt => opt.MapFrom(dto => DateTime.UtcNow));


            CreateMap<WorkTaskView, WorkTaskTableGetVM>()
                .ForMember(dto => dto.CreatedDateTime, opt => opt.MapFrom(src => src.CreatedDateTimeUTC.ToLocalTime().ToShortDateString()))
                .ForMember(dto => dto.ClosedDateTime, opt =>
                    opt.MapFrom(src => src.ClosedDateTimeUTC.HasValue ? src.ClosedDateTimeUTC.Value.ToLocalTime().ToShortDateString() : "Not closed yet"))
                .ForMember(dto => dto.FactedTimeSpan, opt =>
                    opt.MapFrom(src => src.FactedTimeSpan.HasValue ? src.FactedTimeSpan.Value.TotalHours.ToString("0.00") : "-"));

            CreateMap<WorkTaskStatus, WorkTaskStatusGetVM>().ReverseMap();
            CreateMap<WorkTask, WorkTaskGetVM>()
                .ForMember(dto => dto.Title, opt => opt.MapFrom(src => src.Name))
                .ForMember(dto => dto.Author, opt => opt.MapFrom(src => src.User.UserName))
                .ForMember(dto => dto.CreatedDateTime, opt => opt.MapFrom(src => src.CreatedDateTimeUTC.ToLocalTime().ToShortDateString()))
                .ForMember(dto => dto.ClosedDateTime, opt =>
                    opt.MapFrom(src => src.ClosedDateTimeUTC.HasValue ? src.ClosedDateTimeUTC.Value.ToLocalTime().ToShortDateString() : "Not closed"))
                .ForMember(dto => dto.PlannedDateTime, opt =>
                    opt.MapFrom(src => src.PlannedDateTimeUTC.HasValue ? src.PlannedDateTimeUTC.Value.ToLocalTime().ToShortDateString() : "Not assigned"))
                .ForMember(dto => dto.FactedTimeSpan, opt =>
                    opt.MapFrom(src => src.FactedTimeSpan.HasValue ? src.FactedTimeSpan.Value.TotalHours.ToString("0.00") : "Not assigned"));

            CreateMap<WorkTaskCreateVM, WorkTask>()
                .ForMember(task => task.Name, opt => opt.MapFrom(dto => dto.Title))
                .ForMember(task => task.ClosedDateTimeUTC, opt => opt.Ignore())
                .ForMember(task => task.PlannedDateTimeUTC, opt =>
                    opt.MapFrom(dto => dto.PlannedDateTime.HasValue ? dto.PlannedDateTime.Value.ToUniversalTime() : new Nullable<DateTime>()))
                .ForMember(task => task.FactedTimeSpan, opt =>
                    opt.MapFrom(dto => dto.FactedTimeSpan.HasValue ? TimeSpan.FromHours((double)dto.FactedTimeSpan) : new Nullable<TimeSpan>()));

            CreateMap<WorkTask, WorkTaskUpdateVM>()
                .ForMember(dto => dto.Title, opt => opt.MapFrom(src => src.Name))
                .ForMember(dto => dto.PlannedDateTime, opt =>
                    opt.MapFrom(src => src.PlannedDateTimeUTC.HasValue ? src.PlannedDateTimeUTC.Value.ToLocalTime() : new Nullable<DateTime>()))
                .ForMember(dto => dto.FactedTimeSpan, opt =>
                    opt.MapFrom(src => src.FactedTimeSpan.HasValue ? Math.Round(src.FactedTimeSpan.Value.TotalHours, 2) : new Nullable<double>()));
            CreateMap<WorkTaskUpdateVM, WorkTask>()
                .ForMember(task => task.Name, opt => opt.MapFrom(dto => dto.Title))
                .ForMember(task => task.ClosedDateTimeUTC, opt => opt.UseDestinationValue())
                .ForMember(task => task.CreatedDateTimeUTC, opt => opt.UseDestinationValue())
                .ForMember(task => task.PlannedDateTimeUTC, opt =>
                    opt.MapFrom(dto => dto.PlannedDateTime.HasValue ? dto.PlannedDateTime.Value.ToUniversalTime() : new Nullable<DateTime>()))
                .ForMember(task => task.FactedTimeSpan, opt =>
                    opt.MapFrom(dto => dto.FactedTimeSpan.HasValue ? TimeSpan.FromHours((double)dto.FactedTimeSpan) : new Nullable<TimeSpan>()));

            CreateMap<WorkTaskCommentCreateVM, WorkTaskComment>();
            CreateMap<WorkTaskComment, WorkTaskCommentGetVM>()
                .ForMember(dto => dto.CreatedDateTime, opt => opt.MapFrom(src => 
                    string.Join(" ", src.CreatedDateTimeUTC.ToLocalTime().ToLongDateString(), src.CreatedDateTimeUTC.ToLocalTime().ToLongTimeString())))
                .ForMember(dto => dto.UserName, opt => opt.MapFrom(src => src.User.UserName));
        }
    }
}
