namespace InfoClients.Api.Domain.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class State
    {
        public State()
        {
            Cities = new HashSet<City>();
            Clients = new HashSet<Client>();
        }

        [Key]
        public int IdState { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int IdCountry { get; set; }

        public virtual ICollection<City> Cities { get; set; }

        public virtual ICollection<Client> Clients { get; set; }

        public virtual Country Country { get; set; }
    }
}
