using System;
using System.Collections.Generic;

namespace DBFirst
{
    public partial class Section
    {
        public Section()
        {
            Professors = new HashSet<Professor>();
            Students = new HashSet<Student>();
        }

        public int SectionId { get; set; }
        public string? SectionName { get; set; }
        public int? DelegateId { get; set; }

        public virtual ICollection<Professor> Professors { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
