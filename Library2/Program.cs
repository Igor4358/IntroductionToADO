using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Library2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Library.GetAuthorID("Bjarne Stroustrup"));
            //Library.InsertBook(7, "C++ Programming Language", 331, "1986-01-29", "Bjarne Stroustrup");
            Library.Select("author_id,firs_name,last_name", "Authors");
            Library.Select
                (
                    "book_id,book_title,publish_date,[Author]=firs_name+' '+last_name",
                    "Books,Authors",
                    "author=author_id;",
                    32
                );
        }
    }
}
