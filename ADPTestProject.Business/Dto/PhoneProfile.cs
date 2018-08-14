using ADPTestProject.Data.Entities;
using AutoMapper;

namespace ADPTestProject.Business.Dto
{
    public class PhoneProfile : Profile
    {
        public PhoneProfile()
        {
            CreateMap<Phone, PhoneDto>().ReverseMap();
        }
    }
}
