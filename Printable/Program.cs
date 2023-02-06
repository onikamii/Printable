using System;
namespace Printable
{
    interface Printable
    {
        void print();
    }
    class Book: Printable
    {
        public void print()
        {
            
        }
        static void printBooks(Printable[] printable)
        {
            Console.WriteLine(printable);
        }
    }
    class Magazine : Printable
    {
        public void print()
        {
            
        }
        static void printMagazines(Printable[] printable)
        {
            Console.WriteLine(printable);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Magazine magazine = new Magazine();
            Printable[] massiv = { };
            foreach (Printable i in massiv)
            {
                book.print();
                magazine.print();
            }
        }
    }
}