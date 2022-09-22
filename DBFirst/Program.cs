using DBFirst;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

using (DBSlideContext dc = new DBSlideContext())
{
    Student stud = (Student)dc.Students.SingleOrDefault(x => x.StudentId == 1);

    stud.Read();
};





