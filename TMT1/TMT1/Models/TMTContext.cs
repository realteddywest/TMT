namespace TMT1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TMTContext : DbContext
    {
        public TMTContext()
            : base("name=TMTContext")
        {
        }

        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Criminal> Criminals { get; set; }
        public virtual DbSet<EvilnessFactor> EvilnessFactors { get; set; }
        public virtual DbSet<Town> Towns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agent>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.Nickname)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Agents)
                .WithOptional(e => e.Country)
                .HasForeignKey(e => e.CountryCode);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Towns)
                .WithOptional(e => e.Country)
                .HasForeignKey(e => e.CountryCode);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.Nickname)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.Crime)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.Sentence)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<EvilnessFactor>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Town>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
