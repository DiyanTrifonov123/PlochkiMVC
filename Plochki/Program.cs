using Plochki.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plochki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlochkiController controller = new PlochkiController();
            controller.Start();
        }
    }
}
