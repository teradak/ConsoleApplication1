using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class NameofOperatorsSample
    {
        public void Test()
        {
            var asdf = "";
            Console.WriteLine(nameof(asdf));
            Console.WriteLine(nameof(asdf.Length));
            Console.WriteLine(nameof(DateTime));
            
            // Console.WriteLine(nameof("")); // ←はビルドエラー
        }
    }
}
