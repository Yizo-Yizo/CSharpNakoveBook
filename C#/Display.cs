using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Display
    {
        public string Size { get; set; }
        public string Color { get; set; }

        public Display(string size, string color)
        {
            Size = size;
            Color = color;
        }
    }
}
