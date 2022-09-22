using System;
using System.Collections.Generic;

namespace DBFirst
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Login { get; set; }
        public int? SectionId { get; set; }
        public int? YearResult { get; set; }
        public string CourseId { get; set; } = null!;

        public virtual Section? Section { get; set; }

        public void Create()
        {
            using (DBSlideContext dc = new DBSlideContext())
            {

                dc.Students.Add(this);
                dc.SaveChanges();
            }
        }

        public void Update()
        {
            using (DBSlideContext dc = new DBSlideContext())
            {
                dc.Update(this);
                dc.SaveChanges();
            }
        }

        public void Read()
        {
            foreach (var prop in this.GetType().GetProperties())
            {
                Console.WriteLine($"{prop.Name} : {prop.GetValue(this)}");
            }
        }

        public void Delete()
        {
            using (DBSlideContext dc = new DBSlideContext())
            {
                dc.Remove(this);
                dc.SaveChanges();
            }
        }

    }
}
