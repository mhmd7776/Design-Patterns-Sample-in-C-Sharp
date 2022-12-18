using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PdfDocument
    {
        public void AddPage(string text)
        {
            Console.WriteLine($"Add new page with text : {text}.");
        }
    }
}
