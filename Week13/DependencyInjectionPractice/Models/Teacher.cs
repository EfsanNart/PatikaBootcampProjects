using DependencyInjectionPractice.Interfaces;

namespace DependencyInjectionPractice.Models
{
    public class Teacher:ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Teacher (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetInfo()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
