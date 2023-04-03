using Day02.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class DatabaseContext:DbContext
    {
        
        public DatabaseContext() : base("Data Source=localhost\\SQLEXPRESS;Initial Catalog=studentDB;Integrated Security=True")
        {

        }
        public DbSet<student> students { get; set; }
        public DbSet<teacher> teachers { get; set; }
        public DbSet<course> courses { get; set; }
        public DbSet<Score> scores { get; set; }
        public DbSet<admin> admins { get; set; }
       /* protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Score>()
                .HasRequired(s => s.Student) // Each score has one student
                .WithMany(s => s.Score) // Each student can have many scores
                .HasForeignKey(s => s.StudentId); // Define the foreign key property

            modelBuilder.Entity<Sc>()
                .HasRequired(s => s.Course) // Each score has one course
                .WithMany(c => c.Scores) // Each course can have many scores
                .HasForeignKey(s => s.CourseId); // Define the foreign key property
        }*/

    }

}

