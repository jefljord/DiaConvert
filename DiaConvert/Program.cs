/*
 * Author: Jeffrey Jordan
 * Date: 9/17/19
 * File: Program.cs
 * Description: Main Driver
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaConvert
{
    public enum ShapeType //enum of shapetypes
    {
        Line,
        Circle,
        Rectangle,
        Triangle
    };
    class Program 
    {
        static void Main(string[] args)
        {
            ShapeFactory x = new ShapeFactory(); // creates new object

            x.getShape(ShapeType.Line);
            x.getShape(ShapeType.Circle);
            x.getShape(ShapeType.Rectangle);
            x.getShape(ShapeType.Triangle);
            
            Console.ReadKey();
        }
    }
}


