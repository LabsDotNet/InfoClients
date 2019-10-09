namespace InfoClients.Api.Domain.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Client
    {
        public Client()
        {
            Visits = new HashSet<Visit>();
        }

        [Key]
        public long IdClient { get; set; }

        [Required]
        [StringLength(20)]
        public string Nit { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required]
        [StringLength(30)]
        public string Address { get; set; }

        [Required]
        [StringLength(15)]
        public string Phone { get; set; }

        public int IdCity { get; set; }

        public int IdState { get; set; }

        public int IdCountry { get; set; }

        public long CreditLimit { get; set; }

        public long AvailableCredit { get; set; }

        public decimal VisitsPercentage { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual City City { get; set; }

        public virtual State State { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
