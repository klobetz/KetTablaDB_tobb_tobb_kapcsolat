namespace BlazorApp.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }

        //kapcsolat kiépítése
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
