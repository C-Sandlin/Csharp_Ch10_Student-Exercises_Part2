using System;
using System.Collections.Generic;
using System.Linq;

namespace NSSFolks
{
    class Program
    {
        static void Main(string[] args)
        {

            var Cohort32 = new Cohort("Cohort 32");
            var Cohort33 = new Cohort("Cohort 33");
            var Cohort34 = new Cohort("Cohort 34");
            var Cohort35 = new Cohort("Cohort 35");

            var Jason = new Student("Jason", "Collum", "Cohort 32", 4.5);
            var Nate = new Student("Nate", "Fleming", "Cohort 32", 4.5);
            var Trey = new Student("Trey", "Williams", "Cohort 34", 3);

            var Bryan = new Instructor("Bryan", "Nilsen", "Junior Instructor", 14, "Cohort 34");
            var Robby = new Instructor("Robby", "Hecht", "TA", 6, "Cohort 32");

            var Bangazon = new Exercise("Bangazon", "C#");
            var Nutshell = new Exercise("Nutshell", "Javascript");
            var Kennels = new Exercise("Kennels", "Javascript");

            var topic01 = new Exercise("Test Topic 01", "Javascript");
            Nate.ExerciseList.Add(topic01);

            Bryan.AssignExerciseToStudent(Jason, topic01);
            Robby.AssignExerciseToStudent(Nate, Nutshell);




            // Part TWO
            // Part TWO
            // Part TWO
            List<Student> StudentList = new List<Student>()
            {
                Jason, Nate, Trey
            };

            List<Instructor> InstructorList = new List<Instructor>()
            {
                Bryan, Robby
            };

            List<Exercise> ExerciseList = new List<Exercise>()
            {
                Bangazon, Nutshell, Kennels
            };

            List<Cohort> CohortList = new List<Cohort>()
            {
                Cohort32, Cohort34, Cohort33, Cohort35
            };


            // USING LINQ
            var JsExercises = ExerciseList.Where(ex => ex.Language == "Javascript");
            foreach (var ex in JsExercises)
            {
                Console.WriteLine($"{ex.Name} is a javascript exercise");
            }

            Console.WriteLine("=================================");

            var StudentsIn34 = StudentList.Where(stu => stu.InCohort == "Cohort 32");
            foreach (var ex in StudentsIn34)
            {
                Console.WriteLine($"{ex.FirstName} {ex.LastName} is in Cohort 32");
            }

            Console.WriteLine("=================================");

            var GroupedInstructors = InstructorList.GroupBy(instr => instr.CurrentClass);
            foreach (var cohort in GroupedInstructors)
            {
                Console.WriteLine($"{cohort.Key} has:");
                foreach (var instructor in cohort)
                {
                    Console.WriteLine($"{instructor.FirstName} {instructor.LastName}, {instructor.Title}");
                }
                Console.WriteLine("____");
            }

            var AlphabeticalStudents = StudentList.OrderBy(stu => stu.LastName);
            foreach (var student in AlphabeticalStudents)
            {
                Console.WriteLine($"{student.LastName}, {student.FirstName}");
            }

            var StudentsWithExercises = StudentList.Where(stu => stu.ExerciseList.Count > 0);
            foreach (var student in StudentsWithExercises)
            {
                Console.WriteLine($"{student.FirstName} has been assigned:");
                foreach (var exercise in student.ExerciseList)
                {
                    Console.WriteLine($"{exercise.Name} in the language {exercise.Language}");
                }
            }

            // OR

            // List<Student> noExercises =
            // (from student in StudentList
            //  where student.ExerciseList.Count() == 0
            //  select student
            // ).ToList();

            var BusiestStudent = StudentList.OrderByDescending(stu => stu.ExerciseList.Count);
            Console.WriteLine($"The student with the most exercises is {BusiestStudent.FirstOrDefault().FirstName}, with {BusiestStudent.FirstOrDefault().ExerciseList.Count()}");

            // OR

            // List<Student> mostExercises =
            // (from student in StudentList
            //      //  where student.Exercises.Count()
            //  orderby student.ExerciseList.Count() descending
            //  select student
            // ).ToList();

            // Console.WriteLine($"{mostExercises[0].FirstName} is doing the most exercises");

        }
    }
}

