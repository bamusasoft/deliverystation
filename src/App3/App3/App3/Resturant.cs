using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App3
{
    public class Resturant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ImageSource ImageUrl { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
