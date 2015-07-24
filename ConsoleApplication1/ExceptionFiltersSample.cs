using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ExceptionFiltersSample
    {
        public void Test()
        {
            try { /*処理*/ }
            catch (Exception e) when (e.Message.Contains("asdf")) { }
            catch (Exception e) when (e.Message.Contains("qwer")) { }
            catch (Exception e) when (ToLog(e)) { }
        }

        private bool ToLog(Exception e)
        {
            Console.WriteLine(e.Message);
            return e.Message.Contains("zxcv");
        }
    }
}
