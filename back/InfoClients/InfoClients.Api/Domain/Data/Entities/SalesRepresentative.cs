namespace InfoClients.Api.Domain.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class SalesRepresentative
    {
        public SalesRepresentative()
        {
            Visits = new HashSet<Visit>();
        }

        [Key]
        public int IdSaleRepresentative { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
