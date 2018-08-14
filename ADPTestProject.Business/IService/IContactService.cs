using ADPTestProject.Business.Dto;

namespace ADPTestProject.Business.IService
{
    public interface IContactService
    {
        ContactDto AddContact(ContactDto contact);

        ContactDto EditContact(ContactDto contact);
    }
}
