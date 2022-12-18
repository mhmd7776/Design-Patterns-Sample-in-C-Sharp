using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Movie
    {
        public void AddFrame(string text, int duration)
        {
            Console.WriteLine($"Add new frame with text : {text} and duration {duration} seconds.");
        }
    }
}
