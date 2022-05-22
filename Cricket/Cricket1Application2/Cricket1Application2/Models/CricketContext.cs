using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Cricket1Application2.Models
{
    public partial class CricketContext : DbContext
    {
        public CricketContext()
        {
        }

        public CricketContext(DbContextOptions<CricketContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Matches> Matches { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Stadium> Stadium { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Cricket;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContinentName)
                    .HasColumnName("continent_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasColumnName("country_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Matches>(entity =>
            {
                entity.HasKey(e => e.MatchId);

                entity.ToTable("matches");

                entity.Property(e => e.MatchId).HasColumnName("match_id");

                entity.Property(e => e.DateTime)
                    .HasColumnName("date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StadiumId).HasColumnName("stadium_id");

                entity.Property(e => e.Team1).HasColumnName("team1");

                entity.Property(e => e.Team2).HasColumnName("team2");

                entity.Property(e => e.WasMatchPlayed)
                    .HasColumnName("Was_Match_Played")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Stadium)
                    .WithMany(p => p.Matches)
                    .HasForeignKey(d => d.StadiumId)
                    .HasConstraintName("FK__matches__stadium__6477ECF3");

                entity.HasOne(d => d.Team1Navigation)
                    .WithMany(p => p.MatchesTeam1Navigation)
                    .HasForeignKey(d => d.Team1)
                    .HasConstraintName("FK__matches__team1__656C112C");

                entity.HasOne(d => d.Team2Navigation)
                    .WithMany(p => p.MatchesTeam2Navigation)
                    .HasForeignKey(d => d.Team2)
                    .HasConstraintName("FK__matches__team2__66603565");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("player");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PlayerAge).HasColumnName("player_age");

                entity.Property(e => e.PlayerCountryid).HasColumnName("player_countryid");

                entity.Property(e => e.PlayerName)
                    .HasColumnName("player_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.PlayerCountry)
                    .WithMany(p => p.Player)
                    .HasForeignKey(d => d.PlayerCountryid)
                    .HasConstraintName("FK__player__player_c__5EBF139D");
            });

            modelBuilder.Entity<Stadium>(entity =>
            {
                entity.ToTable("stadium");

                entity.Property(e => e.StadiumId).HasColumnName("stadium_id");

                entity.Property(e => e.StadiumCountry).HasColumnName("stadium_country");

                entity.Property(e => e.StadiumMatches).HasColumnName("stadium_matches");

                entity.Property(e => e.StadiumName)
                    .HasColumnName("stadium_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.StadiumCountryNavigation)
                    .WithMany(p => p.Stadium)
                    .HasForeignKey(d => d.StadiumCountry)
                    .HasConstraintName("FK__stadium__stadium__619B8048");
            });
        }
    }
}
