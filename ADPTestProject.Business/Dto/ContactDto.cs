using ADPTestProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADPTestProject.Business.Dto
{
    public class ContactDto
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<EmailDto> Emails { get; set; }

        public List<PhoneDto> Phones { get; set; }
    }
}
