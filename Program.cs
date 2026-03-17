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
        Movie m1 = new Movie();
        m1.SetTitle("lord of the rings\n");
        m1.SetDuration("3h 30m");

        Director d1 = new Director("peter.", "jackson", "new zealand");
        m1.SetDirector(d1);

        Console.WriteLine($"\nDirector&: {d1.GetFirstName()} {d1.GetLastName()}, Title: {m1.GetTitle()}");
        m1.Display();
        d1.Display();

    }
}
