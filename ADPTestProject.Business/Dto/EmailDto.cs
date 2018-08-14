using ADPTestProject.Common.Enums;

namespace ADPTestProject.Business.Dto
{
    public class EmailDto
    {
        public long Id { get; set; }

        public string EmailAddress { get; set; }

        public EmailTypes EmailTypes { get; set; }

        public long ContactId { get; set; }
    }
}