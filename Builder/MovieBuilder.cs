using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MovieBuilder : IPresentationBuilder
    {
        private readonly Movie _movie = new();

        public void AddSlide(Slide slide)
        {
            _movie.AddFrame(slide.GetSlideText(), 10);
        }

        public Movie GetExportedMovie()
        {
            return _movie;
        }
    }
}
