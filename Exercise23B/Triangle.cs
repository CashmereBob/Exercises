using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise23B
{
    class Triangle
    {
        public Coordinate? _AB;
        public Coordinate? _BC;
        public Coordinate? _CA;

        public Triangle(Coordinate? AB, Coordinate? BC, Coordinate? CA)
        {
            _AB = AB;
            _BC = BC;
            _CA = CA;

        }
    }
}
