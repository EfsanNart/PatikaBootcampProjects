using DependencyInjectionPractice.Interfaces;

namespace DependencyInjectionPractice.Services
{
    public class TeacherService : ITeacher
    {
        public string GetInfo()
        {
            return "Teacher:Sertan Bozkuş";
        }
    }
}
