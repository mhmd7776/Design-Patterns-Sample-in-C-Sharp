using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Slide
    {
        private readonly string _text;

        public Slide(string text)
        {
            _text = text;
        }

        public string GetSlideText()
        {
            return _text;
        }
    }
}
