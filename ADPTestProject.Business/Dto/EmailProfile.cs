using ADPTestProject.Data.Entities;
using AutoMapper;

namespace ADPTestProject.Business.Dto
{
    public class EmailProfile : Profile
    {
        public EmailProfile()
        {
            CreateMap<Email, EmailDto>().ReverseMap();
        }
    }
}
