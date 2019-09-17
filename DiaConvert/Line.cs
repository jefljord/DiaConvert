using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaConvert
{
    class Line : IGeometricShape
    {
        void IGeometricShape.draw()
        {
        }
        protected void draw()
        {
            Console.WriteLine("Line has been drawn");
        }
    }
}
