namespace StudentManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public ICollection<StuCrsRes> Results { get; set; }
            = new List<StuCrsRes>();
    }
}