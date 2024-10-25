using GymNotes.Models;
using Microsoft.EntityFrameworkCore;

namespace GymNotes.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Excercise> Excercises { get; set; }
        public DbSet<ExcerciseRecord> ExcerciseRecords { get; set; }
        public DbSet<ExcerciseSet> ExcerciseSets { get; set;}
        public DbSet<Workout> Workouts { get; set; }
    }
}
