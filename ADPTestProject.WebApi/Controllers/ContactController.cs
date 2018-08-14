using ADPTestProject.Business.Dto;
using ADPTestProject.Business.IService;
using System;
using System.Web.Http;

namespace ADPTestProject.WebApi.Controllers
{
    [RoutePrefix("api/contact")]
    public class ContactController : ApiController
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost]
        [Route("add")]
        public IHttpActionResult AddContact([FromBody]ContactDto contact)
        {
            try
            {
                var result = _contactService.AddContact(contact);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    throw new Exception("Data Can Not Be Empty");
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("edit")]
        public IHttpActionResult EditContact([FromBody]ContactDto contact)
        {
            try
            {
                var result = _contactService.EditContact(contact);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    throw new Exception("Data Can Not Be Empty");
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
