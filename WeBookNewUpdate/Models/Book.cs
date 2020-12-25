using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeBookNewUpdate.Controllers
{
    public class  Book 
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public double BookPrice { get; set; }
        public string Descrebtion { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }

    }
}