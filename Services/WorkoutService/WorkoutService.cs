using GymNotes.Data;
using GymNotes.Models;
using Microsoft.EntityFrameworkCore;

namespace GymNotes.Services.WorkoutService
{
    public class WorkoutService : IWorkoutService
    {   
        private readonly DataContext _dataContext;

        public WorkoutService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        // Workout
        public Workout CreateWorkout(Workout workout)
        {
            _dataContext.Workouts.Add(workout);
            _dataContext.SaveChanges();
            return workout;
        }
        public List<Workout> GetWorkoutsByUserId(int userId)
        {
            var workouts = _dataContext.Workouts.Include(w => w.User).Where(w => w.User.Id == userId);
            return workouts.ToList();
        }
        public void RemoveWorkoutById(int workoutId)
        {
            var workout = _dataContext.Workouts.Find(workoutId);

            if (workout != null)
            {
                _dataContext.Remove(workout);
                _dataContext.SaveChanges();
            }
        }

        // Excercise
        public List<Excercise> GetExcercises()
        {
            var excercises = _dataContext.Excercises.ToList();
            return excercises;
        }
        public void RemoveExcerciseById(int excerciseId)
        {
            var excercise = _dataContext.Excercises.Find(excerciseId);
            if (excercise != null)
            {
                _dataContext.Remove(excercise);
                _dataContext.SaveChanges();
            }
        }
        public Excercise AddExcercise(ExcerciseDto excerciseDto)
        {
            var excercise = new Excercise { Name = excerciseDto.Name, BodyPart = excerciseDto.BodyPart, Description = excerciseDto.Description};
            _dataContext.Excercises.Add(excercise);
            _dataContext.SaveChanges();
            return excercise;
        }

        // ExcerciseRecord
        public ExcerciseRecord AddExcerciseRecord(ExcerciseRecord excercise)
        {
            _dataContext.ExcerciseRecords.Add(excercise);
            _dataContext.SaveChanges();
            return excercise;
        }
        public void RemoveExcerciseRecordById(int excerciseId)
        {
            var excerciseRecord = _dataContext.ExcerciseRecords.Find(excerciseId);
            
            if (excerciseRecord != null)
            {
                _dataContext.Remove(excerciseRecord);
                _dataContext.SaveChanges();
            }
        }

        // ExcerciseSet
        public ExcerciseSet AddExcerciseSet(ExcerciseSet excerciseSet)
        {
            _dataContext.ExcerciseSets.Add(excerciseSet);
            _dataContext.SaveChanges();
            return excerciseSet;
        }
        public void RemoveExcerciseSetById(int excerciseSetId)
        {
            var excerciseSet = _dataContext.ExcerciseSets.Find(excerciseSetId);

            if (excerciseSet != null)
            {
                _dataContext.Remove(excerciseSet);
                _dataContext.SaveChanges();
            }
        }
    }
}
