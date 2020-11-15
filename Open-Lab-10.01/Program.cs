using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.SetBook("Plebovia a ich vyskyt", 888);
            Console.ReadKey();
        }
    }
    class Book
    {
        public string title;
        private int pages;
        public void SetBook(string title, int pages)
        {
            Console.Write("Book " + title + " has " + pages + " pages.");
            
        }
    }

}
