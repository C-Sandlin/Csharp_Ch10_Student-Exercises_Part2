using System;
using System.Collections.Generic;

namespace NSSFolks
{
    class Cohort
    {
        public string CohortName { get; set; }
        public List<Student> StudentList { get; set; } = new List<Student>();
        public List<Instructor> InstructorList { get; set; } = new List<Instructor>();

        public Cohort(string cohortname)
        {
            CohortName = cohortname;
        }
    }
}