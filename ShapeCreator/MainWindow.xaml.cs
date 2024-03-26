using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Windows.Media.Media3D;

namespace ShapeCreator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IshapeCreator shapeCreator;
        IShape shape;
        


        public MainWindow()
        {
            InitializeComponent();
        }
        
        public void createShape(object sender,  RoutedEventArgs e)
        {
            ShapeShower.Children.Clear();
            // Выявляем нажатую кнопку
            switch ((sender as Button).Name.ToString())
            {
                // Если нажали на создание Квадрата
                case("SquareCreator"):
                    shapeCreator = new SquareCreator();
                    shape = shapeCreator.generateShape();
                    ShapeShower.Children.Add((shape.showShape() as Border));
                    break;
                // Если нажали на создание Треугольника
                case ("TriangleCreator"):
                    shapeCreator = new TriangleCreator();
                    shape = shapeCreator.generateShape();
                    ShapeShower.Children.Add((shape.showShape() as Polygon));
                    break;
                // Если нажали на создание Прямоугольника
                case ("RectangleCreator"):
                    shapeCreator = new RectangleCreator();
                    shape = shapeCreator.generateShape();
                    ShapeShower.Children.Add((shape.showShape() as Border));
                    break;
                // Если нажали на создание Круга
                case ("CircleCreator"):
                    shapeCreator = new CircleCreator();
                    shape = shapeCreator.generateShape();
                    ShapeShower.Children.Add((shape.showShape() as Ellipse));
                    break;

                // Если нажали на создание Звезды
                case ("StarCreator"):
                    shapeCreator = new StarCreator();
                    shape = shapeCreator.generateShape();
                    ShapeShower.Children.Add((shape.showShape() as Polyline));
                    break;
            }
            
            
        }

        
    }
}
