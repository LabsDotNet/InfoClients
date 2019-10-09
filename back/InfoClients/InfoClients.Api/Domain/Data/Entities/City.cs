namespace InfoClients.Api.Domain.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class City
    {
        public City()
        {
            Clients = new HashSet<Client>();
        }

        [Key]
        public int IdCity { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int IdState { get; set; }

        public virtual State State { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
