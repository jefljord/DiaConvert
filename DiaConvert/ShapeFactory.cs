/*
 * Author: Jeffrey Jordan
 * Date: 9/17/19
 * File: ShapeFactory.cs
 * Description: Draws out a shape
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaConvert
{
    
    class ShapeFactory : Program, IGeometricShape
    {
        ShapeType b;
        public void getShape(ShapeType a)
        {

            b = a;
            if (a == ShapeType.Triangle)
            {
                Console.WriteLine("Triangle isn't implemented");
            }

            draw();
                        
        }
        public void draw()
        {
            if (b == ShapeType.Line)
            {
                Console.WriteLine("Line has been drawn.");
            }
            if (b == ShapeType.Circle)
            {
                Console.WriteLine("Circle has been drawn.");
            }
            if (b == ShapeType.Rectangle)
            {
                Console.WriteLine("Rectangle has been drawn.");
            }

        }

}
}
