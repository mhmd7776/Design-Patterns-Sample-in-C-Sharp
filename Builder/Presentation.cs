using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Presentation
    {
        private readonly List<Slide> _slides = new ();

        public void AddSlide(Slide slide)
        {
            _slides.Add(slide);
        }

        public void Export(IPresentationBuilder builder)
        {
            foreach (var slide in _slides)
            {
                builder.AddSlide(slide);
            }

            builder.AddSlide(new Slide("Copyright reserved"));
        }
    }
}
