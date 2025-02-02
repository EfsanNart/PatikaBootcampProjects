using SchoolDatabase.Models;


public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student(1,"Ali",1),
            new Student(2,"Ayşe",2),
            new Student(3,"Mehmet",1),
            new Student(4,"Fatma",3),
            new Student(5,"Ahmet",2)
        };
        List<Class> classes = new List<Class>
        {
            new Class(1,"Matematik"),
            new Class(2,"Türkçe"),
            new Class(3,"Kimya")
        };
        var groupedData = from cls in classes //classes koleksiyonundan her bir sınıfı (cls) alır.
                          join student in students on cls.ClassId equals student.ClassId into studentGroup //students tablosu ile classes tablosunu ClassId üzerinden birleştirir,Aynı ClassId'ye sahip tüm öğrencileri studentGroup adlı bir koleksiyona gruplandırır
                          select new
                          {
                              ClsName = cls.ClassName,
                              Students = studentGroup
                          };
        // Sonuçları ekrana yazdırma
        foreach (var item in groupedData)
        {
            Console.WriteLine($" {item.ClsName} Dersini Alanlar:");

            foreach (var student in item.Students)
            {
                Console.WriteLine($" {student.StudentName}");
            }

            Console.WriteLine(); // Boşluk bırak


        }
    }
}