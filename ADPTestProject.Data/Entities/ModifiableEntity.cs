using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADPTestProject.Data.Entities
{
    public class ModifiableEntity : BaseEntity
    {
        //It Should be related to Authentication Tables
        [Column(Order =997)]
        public long CreatedBy { get; set; }

        [Column(Order = 998)]
        public DateTime CreateOn { get; set; }

        //It Should be related to Authentication Tables
        [Column(Order = 999)]
        public long ModifiedBy { get; set; }

        [Column(Order = 1000)]
        public DateTime ModifiedOn { get; set; }
    }
}
