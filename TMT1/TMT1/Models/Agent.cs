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
        private string nickname;
        private int age;
        private string townid;
       
        public Agent()
        {
            Criminals = new HashSet<Criminal>();
        }

        public Agent(string agentName, string agentNickName, int agentAge, int townId)
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
                if (value.Length >= 5)
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

        public string Nickname
        {
            get { return this.nickname; }
            set
            {
                if (value.Length >= 3)
                {
                    this.name = name;
                }
                else
                {
                    throw new ArgumentException("Nickname is too short!!!");
                }
            }
        }

        public int? Age
        {
            get { return this.age; }
            set
            {
                if (value >=1)
                {
                    this.age= age;
                }
                else
                {
                    throw new ArgumentException("Age are incorrect!!!");
                }
            }
        }

        public int? TownId
        {
            get { return this.TownId; }
            set
            {
                if (value >= 1)
                {
                    this.TownId = TownId;
                }
                else
                {
                    throw new ArgumentException("TownId is incorrect!!!");
                }
            }
        }

        public virtual Town Town
        {
            get;
            set;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Criminal> Criminals { get; set; }
    }
}
