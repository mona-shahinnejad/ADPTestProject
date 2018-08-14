using System;
using ADPTestProject.Business.Dto;
using ADPTestProject.Business.Service;
using ADPTestProject.Data.Entities;
using Autofac.Extras.Moq;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ADPTestProject.Business.Test
{
    [TestClass]
    public class ContactServiceTest
    {
        [TestMethod]
        public void TestAddContactMethod()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var contactDto = new ContactDto
                {
                    FirstName = "FirstName",
                    LastName = "LastName",
                    DateOfBirth = new DateTime(1990, 1, 1)
                };

                var contact = new Contact
                {
                    FirstName = "FirstName",
                    LastName = "LastName",
                    DateOfBirth = new DateTime(1990, 1, 1)
                };

                mock.Mock<IMapper>().Setup(m => m.Map<Contact>(contactDto)).Returns(contact);
                mock.Mock<IMapper>().Setup(m => m.Map<ContactDto>(contact)).Returns(contactDto);
                var contactService = mock.Create<ContactService>();

                var addedContactDto = contactService.AddContact(contactDto);

                Assert.IsNotNull(addedContactDto);
            }
        }
    }
}
