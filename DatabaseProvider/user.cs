namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Uid { get; set; }

        public int Pwd { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }
    }
}
