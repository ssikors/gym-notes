using GymNotes.Models;

namespace GymNotes.Services.WorkoutService
{
    public interface IWorkoutService
    {
        // Workout
        Workout CreateWorkout(Workout workout);
        List<Workout> GetWorkoutsByUserId(int userId);
        void RemoveWorkoutById(int workoutId);

        // Excercise
        List<Excercise> GetExcercises();
        void RemoveExcerciseById(int excerciseId);
        Excercise AddExcercise(ExcerciseDto excerciseDto);

        // ExcerciseRecord
        ExcerciseRecord AddExcerciseRecord(ExcerciseRecord excercise);
        void RemoveExcerciseRecordById(int excerciseId);

        // ExcerciseSet
        ExcerciseSet AddExcerciseSet(ExcerciseSet excerciseSet);
        void RemoveExcerciseSetById(int excerciseSetId);

    }
}
