using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class NullConditionalOperators
    {
        public void Test()
        {
            string[] asdf = null;
            // c は int?
            var c = asdf?.Count();
            var a = asdf?[0];
        }
    }
}
