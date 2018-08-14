using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ADPTestProject.Data.Entities
{
    public class Contact : ModifiableEntity
    {
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(70)]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public ICollection<Email> Emails { get; set; }

        public ICollection<Phone> Phones { get; set; }
    }
}
