using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PdfDocumentBuilder : IPresentationBuilder
    {
        private readonly PdfDocument _document = new();

        public void AddSlide(Slide slide)
        {
            _document.AddPage(slide.GetSlideText());
        }

        public PdfDocument GetExportedPdfDocument()
        {
            return _document;
        }
    }
}
