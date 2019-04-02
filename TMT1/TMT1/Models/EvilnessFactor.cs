namespace TMT1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EvilnessFactor
    {
        private string name;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        public EvilnessFactor()
        {
            Criminals = new HashSet<Criminal>();
        }

        public int Id { get; set; }

        [StringLength(30)]

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length >= 3)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name is too short!!!");
                }
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual ICollection<Criminal> Criminals { get; set; }
    }
}
