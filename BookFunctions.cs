using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate string FuncDelagate(Book book);
    internal class BookFunctions :Book 
    {
        public BookFunctions(string iSBN, string title, string[] authors, DateTime publishDate, decimal price):base(iSBN,title,authors,publishDate,price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublishDate = publishDate;
            Price = price;
        }
        
        public static string GetTitle(Book book)
        {
            return book.Title;
        }
        public static string GetAuthors(Book book)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < book.Authors?.Length; i++)
                list.Add(book.Authors[i]);
            if (list is not null)
                return list.ToString();
            else
                return "0";
        }

        public static string GetPrice(Book book)
        {
            return book.Price.ToString();
        }

    }
}
