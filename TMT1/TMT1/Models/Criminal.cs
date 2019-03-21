namespace TMT1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Criminal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        public Criminal()
        {
            Agents = new HashSet<Agent>();
        }

        public Criminal(string criminalName, string criminalNickName, int townId, string crime, string sentence, string status, string evilnessFactor)
        {
            this.Name = criminalName;
            this.Nickname = criminalNickName;
            this.TownId = townId;
            this.Crime = Crime;
            this.Sentence = Sentence;
            this.Status = Status;
            this.EvilnessFactor = EvilnessFactor;

            Agents = new HashSet<Agent>();
        }

        public int Id { get; set; }

        [StringLength(50)]

        public string Name { get; set; }

        [StringLength(50)]

        public string Nickname { get; set; }

        public int? TownId { get; set; }

        [StringLength(100)]

        public string Crime { get; set; }

        [StringLength(100)]

        public string Sentence { get; set; }

        [StringLength(50)]

        public string Status { get; set; }

        public int? EvilnessFactorId { get; set; }

        public virtual Town Town { get; set; }

        public virtual EvilnessFactor EvilnessFactor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual ICollection<Agent> Agents { get; set; }
    }
}
