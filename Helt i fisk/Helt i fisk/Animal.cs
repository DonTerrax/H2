using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helt_i_fisk
{
    class Animal
    {
        public string Name { get;}
        public string Length { get; set; }
        public string Weight { get; set; }
        public string ImageSource { get; set; }

        public Animal(string name,string length,string weight,string imageSource)
        {
            Name = name;
            Length = length;
            Weight = weight;
            ImageSource = imageSource;
        }
    }
}
