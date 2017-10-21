using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Category { Business, Cooking, History, Computers, Detective, Thriller, Kids, Politics, Law, Religion, Romance, Science_Fiction, Health} 

namespace LazyBook.Models
{
    class Book
    {
        private string name;
        private string author;
        private string publisher;
        private int year;
        private Category category;
        private string summary;

        public Book(string name, string author, string publisher, int year, Category category, string summary)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.year = year;
            this.category = category;
            this.summary = summary;
        }
    }
}
