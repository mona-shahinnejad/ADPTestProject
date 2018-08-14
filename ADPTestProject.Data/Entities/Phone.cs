using ADPTestProject.Common.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADPTestProject.Data.Entities
{
    public class Phone : ModifiableEntity
    {
        public string PhoneNumber { get; set; }

        public PhoneTypes PhoneType { get; set; }

        public long ContactId { get; set; }

        [ForeignKey(nameof(ContactId))]
        public Contact Contact { get; set; }
    }
}
