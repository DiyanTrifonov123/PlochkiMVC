using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plochki.Views
{
    public class PlochkiDisplay
    {
        public int N { get; set; }
        public double W { get; set; }
        public double L { get; set; }
        public int M { get; set; }
        public int O { get; set; }
        public double tilesNeeded { get; set; }
        public double timeNeeded { get; set; }

        public void Input()
        {
            Console.Write("Въведи страна на площадката: ");
            this.N = int.Parse(Console.ReadLine());
            Console.Write("Въведи широчина на плочка: ");
            this.W = double.Parse(Console.ReadLine());
            Console.Write("Въведи дължина на плочка: ");
            this.L = double.Parse(Console.ReadLine());
            Console.Write("Въведи широчина на пейка: ");
            this.M = int.Parse(Console.ReadLine());
            Console.Write("Въведи дължина на пейка: ");
            this.O = int.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"Брой нужни плочки: {this.tilesNeeded}");
            Console.WriteLine($"Нужно време: {this.timeNeeded}");
        }
    }
}
