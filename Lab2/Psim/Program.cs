using System;
using Psim.Geometry2D;
using Psim.Particles;

namespace Psim
{
    class Program
    {
        static void Main(string[] args)
        {
            Phonon p = new Phonon(1);
            Console.WriteLine(p);

            Point point = p.Position;
            point.SetCoords(100, 100);
            Console.WriteLine(p);
        }
    }
}
