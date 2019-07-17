using System;
using System.Collections.Generic;

namespace NSSFolks
{
    public class Student : Person
    {
        public string InCohort { get; set; }
        public List<Exercise> ExerciseList = new List<Exercise>();

        public Student(string firstname, string lastname, string cohort, double monthsatnss)
        {
            FirstName = firstname;
            LastName = lastname;
            InCohort = cohort;
            MonthsAtNSS = monthsatnss;
            ExerciseList = new List<Exercise>();
        }
    }
}
