namespace TMT1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Criminal
    {
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
    }
}
