using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapeCreator
{
    internal class Star : IShape
    {
        public object showShape()
        {
            Random random = new Random();
            int startPoint = random.Next(50, 130);
            Console.WriteLine("Визуализация Круга");
            Polyline Star = new Polyline()
            {
                Stroke = new SolidColorBrush(Colors.Pink),
                StrokeThickness = 4
            };
            Star.Points.Add(new Point(startPoint, startPoint*3));

            Star.Points.Add(new Point(startPoint*2, startPoint));
            Star.Points.Add(new Point(startPoint*3, startPoint * 3));
            Star.Points.Add(new Point(startPoint, startPoint + startPoint / 2));

            Star.Points.Add(new Point(startPoint * 3, startPoint + startPoint / 2));
            Star.Points.Add(new Point(startPoint, startPoint * 3));



            return Star;
        }
    }
}
