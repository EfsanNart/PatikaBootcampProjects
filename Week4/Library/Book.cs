using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{   //Book class: A template for creating book objects
    internal class Book
    {   //Encapsulation
        private string _name;
        private string _writerName;
        private string _writerSurname;
        private int _numberOfPages;
        private string _publisher;
        private DateTime _dateOfRecord;

        //Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string WriterName
        {
            get { return _writerName; }
            set { _writerName = value; }
        }
        public string WriterSurname
        {
            get { return _writerSurname; }
            set { _writerSurname = value; }
        }
        public int NumberOfPages
        {
            get { return _numberOfPages; }
            set { _numberOfPages = value; }
        }
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }
        public DateTime DateOfRecord
        {
            get { return _dateOfRecord; }
            set { _dateOfRecord = value; }
        }
        //default constructor:Method that works without taking any parameters and assigns default values
        public Book()
        {
            DateOfRecord = DateTime.Now;
        }

        //parameterized constructor:Takes book information as parameters when creating the object
        public Book(string name, string writerName, int numberOfPages, string publisher)
        {
            Name = name;
            WriterName = writerName;
            NumberOfPages = numberOfPages;
            Publisher = publisher;
            DateOfRecord = DateTime.Now;

        }
        public void Bookİnfo()
        {

            Console.WriteLine($"{Name} adlı kitap, {WriterName} {WriterSurname} tarafından yazılmıştır.");
            Console.WriteLine($"{NumberOfPages} sayfa, {Publisher} yayınevinden {DateOfRecord.ToShortDateString()} tarihinde kaydedildi.");
        }
    }
}
