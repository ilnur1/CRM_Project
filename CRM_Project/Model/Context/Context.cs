using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CRM_Project.Model.Context
{
    class Context: DbContext
    {
        public Context()
            : base ("") //тут надо будет указать название строки подключения в app.config
        {
            Database.SetInitializer<Context>(null);
        }

        public virtual DbSet<Note> Note { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected void ExtOnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>()
                .HasRequired(x => x.User)
                .WithMany(x => x.Notes);

            modelBuilder.Entity<Project>()
                .HasRequired(x => x.User)
                .WithMany(x => x.Projects);

            modelBuilder.Entity<TeamProjectMM>()
                .HasRequired(x => x.Team)
                .WithMany(x => x.TeamProjectMMs);

            modelBuilder.Entity<TeamProjectMM>()
                .HasRequired(x => x.Project)
                .WithMany(x => x.TeamProjectMMs);

            modelBuilder.Entity<TeamUserMM>()
                .HasRequired(x => x.Team)
                .WithMany(x => x.TeamUserMMs);

            modelBuilder.Entity<TeamUserMM>()
                .HasRequired(x => x.User)
                .WithMany(x => x.TeamUserMMs);
                
        }
    }
}
