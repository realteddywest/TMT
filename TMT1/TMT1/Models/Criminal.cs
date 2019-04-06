namespace TMT1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Criminal
    {
        private string name;
        private string nickname;
        private string crime;
        private string sentence;
        private string status;
      
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
            this.Crime = crime;
            this.Sentence = sentence;
            this.Status = status;
            this.EvilnessFactor = EvilnessFactor;

            Agents = new HashSet<Agent>();
        }

        public int Id { get; set; }

        [StringLength(50)]

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length >= 5)
                {
                    this.name = value;
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
                    this.nickname = value;
                }
                else
                {
                    throw new ArgumentException("Nickname is too short!!!");
                }
            }
        }

        public int? TownId { get; set; }

        [StringLength(100)]

        public string Crime
        {
            get { return this.crime; }
            set
            {
                crime = value; 
            }
        }

        [StringLength(100)]

        public string Sentence
        {
            get { return this.sentence; }
            set
            {
                sentence = value; 
            }
        }

        [StringLength(50)]

        public string Status {
            get { return this.status; }
            set
            {
                if (value.Length >= 3)
                {
                    this.status = value;
                }
                else
                {
                    throw new ArgumentException("This status is  incorrex!!!");
                }
            }
        }

        public int? EvilnessFactorId { get; set; }

        public virtual Town Town { get; set; }

        public virtual EvilnessFactor EvilnessFactor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual ICollection<Agent> Agents { get; set; }
    }
}
