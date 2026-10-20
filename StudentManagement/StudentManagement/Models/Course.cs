namespace StudentManagement.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Degree { get; set; }
        public int MinDegree { get; set; }

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
            = new List<Teacher>();

        public ICollection<StuCrsRes> Results { get; set; }
            = new List<StuCrsRes>();
    }
}