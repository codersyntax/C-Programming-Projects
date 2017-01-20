using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    struct BookList
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;

        public void getValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }
        public void display()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Book_id :{0}", book_id);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BookList Book1 = new BookList();   /* Declare Book1 of type Book */
            Book1.getValues("Harry Potter and the Cursed Child", "J.K. Rowling", "Fiction", 6495407); /* book 1 specification */
            Book1.display(); /* print Book1 info */

            BookList Book2 = new BookList();   /* Declare Book2 of type Book */
            Book2.getValues("End of Watch", "Stephen King", "Fiction", 6495700); /* book 2 specification */
            Book2.display();/* print Book2 info */

            Console.ReadKey();
        }
    }
}
