using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMMAModel
{
    internal class Reading
    {
        public int IdReading { get; set; }
        public DateAndTime CreationDate { get; set; }
        public string Description { get; set; }
        public string Humor { get; set; }
    }
}
