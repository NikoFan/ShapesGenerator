using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapeCreator
{
    // Класс генерации треугольника
    internal class Triangle : IShape
    {
        public object showShape()
        {
            Random rand = new Random();
            Console.WriteLine("Визуализация Треугольника");
            Polygon triangle = new Polygon()
            {
                Fill = new SolidColorBrush(Colors.Red),
                Points = new PointCollection() { }
            };
            // точка 1
            triangle.Points.Add(new Point(rand.Next(50, 105), rand.Next(50, 105)));
            // точка 2
            triangle.Points.Add(new Point(rand.Next(75, 200), rand.Next(75, 200)));
            // точка 3
            triangle.Points.Add(new Point(rand.Next(75, 390), rand.Next(75, 390)));
            return triangle;
        }



    }
}
