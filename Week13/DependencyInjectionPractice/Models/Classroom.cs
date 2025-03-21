using DependencyInjectionPractice.Interfaces;

namespace DependencyInjectionPractice.Models
{
    public class Classroom
    {
        private readonly ITeacher _teacher;
        public Classroom(ITeacher teacher)//teacher nesnesini bağımlılk olarak alıyoruz (Constructor Injection)
        {
            _teacher = teacher;
        }
        public string GetTeacherInfo()//Teacher nesnesinin GetInfo metodunu çağırıyoruz
        {
            return _teacher.GetInfo();
        }
    }
}
