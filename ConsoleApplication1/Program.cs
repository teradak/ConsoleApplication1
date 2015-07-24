using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class AutoPropertySample
    {
        public string Aa { get; } = "QWER";
        public string Bb { set; get; } = "ASDF";
        public AutoPropertySample() { }
        public AutoPropertySample(string aa, string bb)
        {
            this.Aa = aa;
            this.Bb = bb;
        }
    }

    public class ExpressionBodiedFunctionMembersSample
    {
        public void methodlike(string msg)
            => Console.WriteLine("{0}-{1}", DateTime.Now, msg);
        public string propertylike => DateTime.Now.Hour.ToString();
    }
}


