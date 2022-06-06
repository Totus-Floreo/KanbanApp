using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KanbanApp.Model
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Kanban> Kanbans { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Tool> Tools { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kanban>()
                .HasMany(e => e.Status)
                .WithRequired(e => e.Kanban)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kanban>()
                .HasMany(e => e.Tasks)
                .WithRequired(e => e.Kanban)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kanban>()
                .HasMany(e => e.Tools)
                .WithRequired(e => e.Kanban)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Tasks)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tool>()
                .HasMany(e => e.Tasks)
                .WithRequired(e => e.Tool)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Kanbans)
                .WithMany(e => e.Users)
                .Map(m => m.ToTable("UsersKanbans").MapLeftKey("userID").MapRightKey("kanbanID"));
        }
    }
}
