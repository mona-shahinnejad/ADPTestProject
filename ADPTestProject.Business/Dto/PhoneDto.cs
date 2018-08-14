using ADPTestProject.Common.Enums;

namespace ADPTestProject.Business.Dto
{
    public class PhoneDto
    {
        public long Id { get; set; }

        public string PhoneNumber { get; set; }

        public PhoneTypes PhoneType { get; set; }

        public long ContactId { get; set; }
    }
}