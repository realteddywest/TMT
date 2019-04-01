namespace TMT1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Agent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        private string name;
        public Agent()
        {
            Criminals = new HashSet<Criminal>();
        }

        public Agent(string agentName,string agentNickName,int agentAge,int townId)
        {
            this.Name = agentName;
            this.Nickname = agentNickName;
            this.Age = agentAge;
            this.TownId = townId;
            Criminals = new HashSet<Criminal>();
        }

        public int Id { get; set; }

        [StringLength(30)]

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length>=5)
                {
                    this.name = name;
                }
                else
                {
                    throw new ArgumentException("Name is too short!!!");
                }
            }
        }

        [StringLength(50)]

        public string Nickname { get; set; }

        public int? Age { get; set; }

        public int? TownId { get; set; }

        public virtual Town Town { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Criminal> Criminals { get; set; }
    }
}
