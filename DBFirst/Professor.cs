using System;
using System.Collections.Generic;

namespace DBFirst
{
    public partial class Professor
    {
        public Professor()
        {
            Courses = new HashSet<Course>();
        }

        public int ProfessorId { get; set; }
        public string ProfessorName { get; set; } = null!;
        public string ProfessorSurname { get; set; } = null!;
        public int SectionId { get; set; }
        public int ProfessorOffice { get; set; }
        public string ProfessorEmail { get; set; } = null!;
        public DateTime ProfessorHireDate { get; set; }
        public int ProfessorWage { get; set; }

        public virtual Section Section { get; set; } = null!;
        public virtual ICollection<Course> Courses { get; set; }
    }
}
