namespace BlazorApp.Model
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? CourseName { get; set; }

        //kapcsolat kiépítése
        public virtual List<Student> Students { get; set; } = new List<Student>();
        //ICollection, IEnumerable, List
    }
}
