using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Book_Shop
{
    class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author,string title,decimal price)
            : base(author,title, price)
        {
            
        }

        public override decimal Price
        {
            get
            {
                return base.Price * (decimal)1.3;
            }
        }

    }
}
