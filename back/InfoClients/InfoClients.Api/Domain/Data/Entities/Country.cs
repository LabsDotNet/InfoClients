namespace InfoClients.Api.Domain.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Country
    {
        public Country()
        {
            States = new HashSet<State>();
        }

        [Key]
        public int IdCountry { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<State> States { get; set; }
    }
}
