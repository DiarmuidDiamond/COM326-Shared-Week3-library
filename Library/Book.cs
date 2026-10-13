using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        //private fields
        private string title;
        private string author;
        private string isbn;


        public string Title
        {
            get { return title; }

            set
            {
                // Ensure name does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    title = value;
                }
                else
                {
                    Console.WriteLine("Error: Book title cannot be blank or contain numbers.");
                }
            }

        }
        public string Author
        {
            get { return author; }

            set
            {
                // Ensure name does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot be blank or contain numbers.");
                }
            }
        }
        public string ISBN
        {
            get { return isbn; }

            set
            {
                // Ensure name does not contain any numbers
                if (value != "")
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank.");
                }
            }
        }

        //Constructor
        public Book(string title, string author, string isbn)
        {
            this.Author = author;
            this.Title = title;
            this.ISBN = isbn;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
} 
    
