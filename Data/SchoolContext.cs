using Microsoft.EntityFrameworkCore;
using SchoolNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolNetwork.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Intructors { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Asnwers { get; set; }
        public DbSet<Choice> Choices { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Instructor>().ToTable("Instructor");
            modelBuilder.Entity<Assignment>().ToTable("Assignment");
            modelBuilder.Entity<Question>().ToTable("Question");
            modelBuilder.Entity<Answer>().ToTable("Answer");
            modelBuilder.Entity<Choice>().ToTable("Choice");
            modelBuilder.Entity<Result>().ToTable("Result");
            modelBuilder.Entity<Rating>().ToTable("Rating");
            modelBuilder.Entity<Review>().ToTable("Review");
        }
    }
}
