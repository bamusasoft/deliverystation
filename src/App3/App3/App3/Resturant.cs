using System;
using System.Collections.Generic;
using System.Text;

namespace App3
{
    public class Resturant
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
