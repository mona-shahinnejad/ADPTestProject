using ADPTestProject.Data.Entities;
using AutoMapper;

namespace ADPTestProject.Business.Dto
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<Contact, ContactDto>().ReverseMap();
        }
    }
}
