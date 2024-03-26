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
    // Класс генерации прямоугольника
    internal class Rectangle : IShape
    {
        public object showShape()
        {
            Random random = new Random();
            int side_top = random.Next(1, 200);
            int side_left = random.Next(1, 200);
            Console.WriteLine("Визуализация прямоугольника");
            Border rectangle = new Border()
            {
                Background = new SolidColorBrush(Colors.Green),
                Width = side_top,
                Height = side_left,
                VerticalAlignment = System.Windows.VerticalAlignment.Center,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
            }; ;
            return rectangle;
        }

    }
}
