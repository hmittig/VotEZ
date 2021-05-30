using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotEZModels;

namespace VotEZDL
{
    public class VotEZDBContext: DbContext
    {
        public VotEZDBContext(DbContextOptions options) : base(options)
        { }
        public VotEZDBContext()
        { }
        public DbSet<User> User { get; set; }
        public DbSet<Poll> Poll { get; set; }
        public DbSet<PollChoice> PollChoices { get; set; }
        public DbSet<PollVote> PollVote { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(x => x.ID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Poll>()
                .Property(x => x.ID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<PollChoice>()
                .Property(x => x.ID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<PollVote>()
                .Property(x => x.ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Poll>()
                .HasOne(p => p.PollChoice)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
