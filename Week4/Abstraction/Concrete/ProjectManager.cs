using Abstraction.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Concrete
{
    internal class ProjectManager:BaseCompanyEmployees
    {
        //Constructor
        public ProjectManager(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }
        //Eğer metodu override etmezsek hata verir çünkü Base'den biras alınan classların içerisinde
        //EmployeeTask özelliği/metodu bulunuyor dedik örneğin ProjectManager classımızdan newleme yaparsak
        //Ve EmployeeTask  metodunu kullanırsak gövdeyi  doldurmadığımız için ne yapacagını bilemez
        public override void EmployeeTask()
        {
            Console.WriteLine("Proje yöneticisi olarak çalışıyorum..");
        }
    }
}
