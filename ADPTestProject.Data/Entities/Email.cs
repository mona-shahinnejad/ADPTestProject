using ADPTestProject.Common.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADPTestProject.Data.Entities
{
    public class Email : ModifiableEntity
    {
        public string EmailAddress { get; set; }

        public EmailTypes EmailTypes { get; set; }

        public long ContactId { get; set; }

        [ForeignKey(nameof(ContactId))]
        public Contact Contact { get; set; }
    }
}