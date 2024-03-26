using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Windows.Shapes;

namespace ShapeCreator
{
    // Класс генерации круга
    internal class Circle : IShape
    {
        public object showShape()
        {
            Random random = new Random();
            int Diameter = random.Next(1, 200);
            Console.WriteLine("Визуализация Круга");
            Ellipse ellipse = new Ellipse()
            {
                Fill = new SolidColorBrush(Colors.Yellow),
                Width = Diameter,
                Height = Diameter,
                VerticalAlignment = System.Windows.VerticalAlignment.Center,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
            };
            return ellipse;
        }

    }
}
