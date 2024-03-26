using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCreator
{
    internal class SquareCreator : IshapeCreator
    {
        public IShape generateShape()
        { 
            return new Square();
        }
    }
}
