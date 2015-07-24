using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class StringInterpolationSumple
    {
        private string Title { set; get; }
        public void Test()
        {
            var t = $"Title:{Title}";
            var t1 = "Title:" + Title;
            var t2 = string.Format("Title:{0}", Title);
            var t3 = $"Title:{Title.Trim()}";
        }
    }
}
