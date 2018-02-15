using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if BRIDGE
using static Retyped.jquery;
#endif

namespace RetypedBridgeBug
{
    public class Program
    {
        public static void Main()
        {
            DoSomething();
        }
        public static void DoSomething()
        {
#if BRIDGE
            jQuery.ajax("Localhost/test.php");
#endif
        }
    }
}
