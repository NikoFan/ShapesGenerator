using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCreator
{
    internal class RectangleCreator : IshapeCreator
    {
        public IShape generateShape()
        {
            return new Rectangle();
        }
    }
}
