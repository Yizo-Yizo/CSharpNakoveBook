using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Book
    {
        // Ch 14 No. 20
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string IsbnNumber { get; set; }

        public Book(string title, string author, string publisher, DateTime releaseDate, string isbnNumber)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            IsbnNumber = isbnNumber;
        }

        // Method to display information about the book
        public string DisplayBookInfo()
        {
            return $"Title: {Title}\n" +
                   $"Author: {Author}\n" +
                   $"Publisher: {Publisher}\n" +
                   $"Release Date: {ReleaseDate.ToShortDateString()}\n" +
                   $"ISBN Number: {IsbnNumber}\n";
        }
    }
}

