using InheritancePractice.StudentTeacherModels;

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student()
        {
            Name = "Ron",
            Surname = "Weasley",
            StudentNumber = 17,
        };
        student.StudentInfo();
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        Teacher teacher = new Teacher()
        {
            Name="Severus",
            Surname="Snape",
            SalaryInfo=60000
        };
        teacher.TeacherInfo();
    }
}