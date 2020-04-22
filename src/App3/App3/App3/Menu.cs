using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App3
{
    public class Menu
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public ImageSource ImageUrl { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
