namespace InfoClients.Api.Domain.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Visit
    {
        [Key]
        public long IdVisit { get; set; }

        public long IdClient { get; set; }

        public int IdSalesRepresentative { get; set; }

        public decimal Net { get; set; }

        public decimal VisitTotal { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual Client Client { get; set; }

        public virtual SalesRepresentative SalesRepresentative { get; set; }
    }
}
