using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
   public class Context:DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-D6N7I1U;database=DB;integrated security=true;");
        }
        public DbSet<PainScoreEntry> PainScoreEntries { get; set; }
        public DbSet<SurveyQuestion> surveyQuestions { get; set; }
        public DbSet<Choice> Choices { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration of entities and their relationships goes here
            modelBuilder.Entity<SurveyQuestion>()
                .HasMany(sq => sq.Choices)
                .WithOne(c => c.SurveyQuestion)
                .HasForeignKey(c => c.SurveyQuestionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
  
}
