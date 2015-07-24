using static System.Console;
using static System.DateTime;

namespace ConsoleApplication1
{
    public class UsingStaticSample
    {
        public void Echo(string a)
        {
            // System.Console.WriteLine
            WriteLine(a);
            // System.Console.WriteLine(DateTime.UtcNow)
            Write(UtcNow);

        }
    }
}
