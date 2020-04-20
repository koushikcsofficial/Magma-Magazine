namespace Magma.DomainModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BlogReportsMaster")]
    public partial class BlogReportsMaster
    {
        public int Id { get; set; }

        public int Blog_Id { get; set; }

        public int Report_Id { get; set; }

        public int Reported_By { get; set; }

        public DateTime Reported_At { get; set; }

        public byte Report_IsVerified { get; set; }

        public int Report_VerifiedBy { get; set; }

        public DateTime Report_VerifiedAt { get; set; }

        public byte Report_IsValid { get; set; }

        public virtual BlogReportType BlogReportType { get; set; }

        public virtual Blog Blog { get; set; }

        public virtual UserAccount UserAccount { get; set; }

        public virtual UserAccount UserAccount1 { get; set; }
    }
}
