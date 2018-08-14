using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using ADPTestProject.Business.Dto;

namespace ADPTestProject.WebApi.Tests.Controllers
{
    /// <summary>
    /// Summary description for ContactApiServiceTests
    /// </summary>
    [TestClass]
    public class ContactApiServiceTests
    {
        private const string serverAddress = "http://localhost:55050/";
        private const string addContactAddress = "api/contact/add";

        [TestMethod]
        public void AddContactApiTest()
        {
            var contactDto = new ContactDto
            {
                FirstName = "FirstName",
                LastName = "LastName",
                DateOfBirth = new DateTime(1990, 1, 1)
            };

            var addUrl = serverAddress + addContactAddress;
            var httpClient = new HttpClient();

            var response = httpClient.PostAsJsonAsync(addUrl, contactDto);

            response.Result.EnsureSuccessStatusCode();

            string content = response.Result.Content.ReadAsStringAsync().Result;

            Assert.IsTrue(!string.IsNullOrWhiteSpace(content) && content.Contains("FirstName"));
        }
    }
}
