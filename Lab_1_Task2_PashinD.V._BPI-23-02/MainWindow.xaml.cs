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

namespace Lab_1_Task2_PashinD.V._BPI_23_02
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Circle circleA;
        public Rectangle rectangleA;
        public Triangle triangleA;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void getArea(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            switch(pressed.Content.ToString())
            {
                case "Круг":
                    CircleData.Visibility = Visibility.Hidden;
                    RectangleData.Visibility = Visibility.Hidden;
                    TriangleData.Visibility = Visibility.Visible;
                    break;
                case "Прямоугольник":
                    break;
                case "Треугольник":
                    break;
                default:
                    break;
            }
        }
    }
}
