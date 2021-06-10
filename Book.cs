using System;

namespace C_
{
    //Class example
    public class Book
    {
        public string title, author;
        public int pages;

        public Book(){
            Console.WriteLine("Book object created with no params");
        }

        public Book(string name){
            Console.WriteLine("Constructor: Creating book " + name);

        }

        public Book(string name, string aTitle, string aAuthor, int aPages){
            Console.WriteLine("Constructor: Creating book " + name);
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }




    }


}