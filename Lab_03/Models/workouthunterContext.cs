using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Lab_03.Models
{
    public partial class workouthunterContext : DbContext
    {
        public workouthunterContext()
        {
        }

        public workouthunterContext(DbContextOptions<workouthunterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CharacterItemSkill> CharacterItemSkills { get; set; }
        public virtual DbSet<GameProgress> GameProgresses { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Monster> Monsters { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<UserInfo> UserInfos { get; set; }
        public virtual DbSet<UserStatus> UserStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<CharacterItemSkill>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("character_item_skill");

                entity.Property(e => e.Uid)
                    .HasMaxLength(10)
                    .HasColumnName("UID");

                entity.Property(e => e.Items)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Skills)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GameProgress>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("game_progress");

                entity.Property(e => e.Uid)
                    .HasMaxLength(10)
                    .HasColumnName("UID");

                entity.Property(e => e.Cpoint).HasColumnName("CPoint");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.Iid);

                entity.ToTable("item");

                entity.HasIndex(e => e.ItemName, "I_ID")
                    .IsUnique();

                entity.Property(e => e.Iid).HasColumnName("IID");

                entity.Property(e => e.ItemInfo).HasMaxLength(50);

                entity.Property(e => e.ItemName).HasMaxLength(20);

                entity.Property(e => e.ItemPic).HasMaxLength(50);
            });

            modelBuilder.Entity<Monster>(entity =>
            {
                entity.HasKey(e => e.Mid)
                    .HasName("PK__monster__C797348A671D3B69");

                entity.ToTable("monster");

                entity.HasIndex(e => e.MonsterName, "M_ID")
                    .IsUnique();

                entity.Property(e => e.Mid)
                    .ValueGeneratedNever()
                    .HasColumnName("MID");

                entity.Property(e => e.MonsterName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MonsterPic).HasMaxLength(50);
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__skill__CA195970A530EBAD");

                entity.ToTable("skill");

                entity.HasIndex(e => e.SkillName, "S_ID")
                    .IsUnique();

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.Cd).HasColumnName("CD");

                entity.Property(e => e.SkillName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SkillPic).HasMaxLength(50);
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK__user_Inf__C5B19602352F289F");

                entity.ToTable("user_Info");

                entity.Property(e => e.Uid)
                    .HasMaxLength(10)
                    .HasColumnName("UID");

                entity.Property(e => e.Class)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.PassWord)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SignDate).HasColumnType("date");
            });

            modelBuilder.Entity<UserStatus>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK__user_sta__C5B19602CCA1FA1E");

                entity.ToTable("user_status");

                entity.Property(e => e.Uid)
                    .HasMaxLength(10)
                    .HasColumnName("UID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
