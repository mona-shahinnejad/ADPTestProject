using ADPTestProject.Business.Dto;
using ADPTestProject.Business.IService;
using ADPTestProject.Data;
using ADPTestProject.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADPTestProject.Business.Service
{
    public class ContactService : IContactService
    {
        private readonly IMapper _mapper;

        public ContactService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public ContactDto AddContact(ContactDto contact)
        {
            if (contact != null)
            {
                var addContact = _mapper.Map<Contact>(contact);

                addContact.CreatedBy = 1; //User From Authentication
                addContact.CreateOn = DateTime.Now;
                addContact.ModifiedBy = 1; //User From Authentication
                addContact.ModifiedOn = DateTime.Now;

                using (var db = new ADPTestProjectDatabaseContext())
                {
                    db.Contacts.Add(addContact);
                    db.SaveChanges();

                    return _mapper.Map<ContactDto>(addContact);
                }
            }

            return null;
        }

        public ContactDto EditContact(ContactDto contact)
        {
            if (contact != null && contact.Id != 0)
            {
                var editContact = _mapper.Map<Contact>(contact);

                editContact.ModifiedBy = 1; //User From Authentication
                editContact.ModifiedOn = DateTime.Now;

                using (var db = new ADPTestProjectDatabaseContext())
                {
                    db.Contacts.Attach(editContact);
                    db.SaveChanges();

                    return _mapper.Map<ContactDto>(editContact);
                }
            }

            return null;
        }
    }
}
