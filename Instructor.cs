using System;

namespace NSSFolks
{
    public class Instructor : Person
    {
        public string CurrentClass { get; set; }
        public Instructor(string firstname, string lastname, string title, double monthsatnss, string currentclass)
        {
            FirstName = firstname;
            LastName = lastname;
            Title = title;
            MonthsAtNSS = monthsatnss;
            CurrentClass = currentclass;
        }

        public void AssignExerciseToStudent(Student student, Exercise exerciseName)
        {
            student.ExerciseList.Add(exerciseName);
        }
    }
}
