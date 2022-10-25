using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Filter(string fileName)
        {
            Console.WriteLine("Applying Black And White filter");
        }
    }
}
