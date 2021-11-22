using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ples_Claudiu_Lab8.Pages.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
