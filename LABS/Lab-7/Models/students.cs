namespace StudentManagementApi.Models
{
    public class Subject
    {
        public int Id{get ; set;}
        public string Name {get; set;} = string.Empty;
        public string Code{get; set;} = string.Empty;

    }

    public class Student
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Email {get; set;}
        public List<Subject> Subjects {get ; set;} = new List<Subjects>();

    }


}