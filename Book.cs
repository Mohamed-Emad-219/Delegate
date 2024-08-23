using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Book
    {
        

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublishDate { get; set; }
        public decimal Price { get; set; }


        public Book(string iSBN, string title, string[] authors, DateTime publishDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublishDate = publishDate;
            Price = price;
        }
        public override string ToString()
        {
            return $"{ISBN} , {Title} , {Authors} , {PublishDate} , {Price}";
        }
    }
}
