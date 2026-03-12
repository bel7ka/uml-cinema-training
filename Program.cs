using System.Collections.Specialized;
using System.Data.Common;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace uml_cinema_training;

class Program
{
    static void Main(string[] args)
    {
        movie m1 = new movie();
        m1.title = "lord of the rings";
        m1.duration = "3h 30m";
        m1.Display();

        director.d1 = new director("peter jackson", "new zealand");
        d1.Display();
    }
}
