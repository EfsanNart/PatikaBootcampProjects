
using Abstraction.Concrete;

ProjectManager projectManager = new ProjectManager("Ela","Güngören", "Bilgi Teknolojileri (IT)");
projectManager.EmployeeTask();

Console.WriteLine("------------------------------------------------------------------------------------------------------------");

SalesRep salesRep = new SalesRep("Hakan","Alkan","Satış ve Pazarlama");
salesRep.EmployeeTask();
Console.WriteLine("-------------------------------------------------------------------------------------------------------");

SoftwareDeveloper softwareDeveloper=new SoftwareDeveloper("Efşan","Nart","Bilgi Teknolojileri(IT)");    
softwareDeveloper.EmployeeTask();