using System;
namespace Printable
{
    interface Printable
    {
        void print();
    }
    class Book : Printable
    {
        string book;
        public Book(string book)
        {
            this.book = book;
        }
        public void print()
        {
            Console.WriteLine(book);
        }
        static void printBooks(Printable[] printabl)
        {

        }
    }
    class Magazine : Printable
    {
        string magazine;
        public Magazine(string magazine)
        {
            this.magazine = magazine;
        }
        public void print()
        {
            Console.WriteLine(magazine);
        }
        static void printMagazines(Printable[] printabl)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Повелитель тайн");
            Book book2 = new Book("Магический Трон Арканы");
            Magazine magazine1 = new Magazine("Человек-бензопила");
            Magazine magazine2 = new Magazine("Человек-бензопила 2");
            Printable[] literature = {book1, book2, magazine1, magazine2};
            foreach (Printable element in literature)
            {
                element.print();
            }
        }
    }
}