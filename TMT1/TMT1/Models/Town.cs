namespace TMT1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Town
    {
        private string name;
        private int? countrycode;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        public Town()
        {
            Agents = new HashSet<Agent>();
            Criminals = new HashSet<Criminal>();
        }
        //Comment
        public int Id { get; set; }

        [StringLength(30)]

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length >= 2)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name is too short!!!");
                }
            }
        }

        public int? CountryCode
        {
            get { return this.countrycode; }
            set
            {
                if (value >=1)
                {
                    this.countrycode = value;
                }
                else
                {
                    throw new ArgumentException("Countrycode is invalide!!!");
                }
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual ICollection<Agent> Agents { get; set; }

        public virtual Country Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual ICollection<Criminal> Criminals { get; set; }
    }
}
