using CreateClassWithOOP;

public class Program
{
    static void Main(string[] args)
    {
        Person ögrenci = new Person();
        ögrenci.Ad = "Efşan";
        ögrenci.Soyad = "Nart";
        ögrenci.DogumTarihi = new DateTime(2001, 3, 17);
        ögrenci.Sınıf = "Back-End Web Developer ";
        ögrenci.Ogrenciİnfo();



        Person ögretmen = new Person();
        ögretmen.Ad = "Sertan";
        ögretmen.Soyad = "Bozkuş";
        ögretmen.DogumTarihi = new DateTime(1996, 7, 12);
        ögretmen.Branş = "Yazılım";
        ögretmen.Ogretmenİnfo();
    }
}