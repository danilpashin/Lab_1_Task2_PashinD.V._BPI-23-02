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
        public string selectedFigure;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FigureLoad()
        {
            Area.Content = "Площадь = ";
            Perimeter.Content = "Периметр = ";
            if (selectedFigure == "Круг")
            {
                firstLabel.Content = "Радиус(см)";
                SetVisibilityLabels(Visibility.Visible, Visibility.Hidden, Visibility.Hidden);
                SetVisibility(Visibility.Visible, Visibility.Visible, Visibility.Hidden, Visibility.Hidden);
            }
            else if (selectedFigure == "Прямоугольник")
            {
                firstLabel.Content = "Ширина(см)";
                secondLabel.Content = "Высота(см)";
                SetVisibilityLabels(Visibility.Visible, Visibility.Visible, Visibility.Hidden);
                SetVisibility(Visibility.Visible, Visibility.Visible, Visibility.Visible, Visibility.Hidden);
            }
            else if (selectedFigure == "Треугольник")
            {
                firstLabel.Content = "1 сторона(см)";
                secondLabel.Content = "2 сторона(см)";
                SetVisibilityLabels(Visibility.Visible, Visibility.Visible, Visibility.Visible);
                SetVisibility(Visibility.Visible, Visibility.Visible, Visibility.Visible, Visibility.Visible);
            }
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            double firstF;
            double secondF;
            double thirdF;
            if (selectedFigure == "Круг") 
            {
                if(!string.IsNullOrWhiteSpace(firstField.Text) && double.TryParse(firstField.Text, out firstF))
                {
                    if(firstF > 0)
                    {
                        circleA = new Circle(Convert.ToDouble(firstField.Text));
                        Area.Content = "Площадь = " + Convert.ToString(circleA.getArea());
                        Perimeter.Content = "Периметр = " + Convert.ToString(circleA.getPerimeter());
                    }
                    else
                    {
                        MessageBox.Show("Число меньше или равно нулю!");
                    }
                }
                else
                {
                    MessageBox.Show("Поле пустое или не содержит число!");
                }
            }
            else if(selectedFigure == "Прямоугольник")
            {
                if (!string.IsNullOrWhiteSpace(firstField.Text) && double.TryParse(firstField.Text, out firstF) 
                    && !string.IsNullOrWhiteSpace(secondField.Text) && double.TryParse(secondField.Text, out secondF))
                {
                    if (firstF > 0 && secondF > 0)
                    {
                        rectangleA = new Rectangle(Convert.ToDouble(firstField.Text), Convert.ToDouble(secondField.Text));
                        Area.Content = "Площадь = " + Convert.ToString(rectangleA.getArea());
                        Perimeter.Content = "Периметр = " + Convert.ToString(rectangleA.getPerimeter());
                    }
                    else
                    {
                        MessageBox.Show("Числа меньше или равны нулю!");
                    }
                }
                else
                {
                    MessageBox.Show("Поля пустые или не содержат числа!");
                }
            }
            else if(selectedFigure == "Треугольник")
            {
                if (!string.IsNullOrWhiteSpace(firstField.Text) && double.TryParse(firstField.Text, out firstF)
                       && !string.IsNullOrWhiteSpace(secondField.Text) && double.TryParse(secondField.Text, out secondF)
                       && !string.IsNullOrWhiteSpace(thirdField.Text) && double.TryParse(thirdField.Text, out thirdF))
                {
                    if (firstF > 0 && secondF > 0 && thirdF > 0)
                    {
                        triangleA = new Triangle(Convert.ToDouble(firstField.Text), Convert.ToDouble(secondField.Text), Convert.ToDouble(thirdField.Text));
                        Area.Content = "Площадь = " + Convert.ToString(triangleA.getArea());
                        Perimeter.Content = "Периметр = " + Convert.ToString(triangleA.getPerimeter());
                    }
                    else
                    {
                        MessageBox.Show("Числа меньше или равны нулю!");
                    }
                }
                else
                {
                    MessageBox.Show("Поля пустые или не содержат числа!");
                }
            }    
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                selectedFigure = item.Content.ToString();
            }
            FigureLoad();
        }

        private void SetVisibility(Visibility labels, Visibility firstFieldA, Visibility secondFieldA, Visibility thirdFieldA)
        {
            Fields.Visibility = Visibility.Visible;
            CalcData.Visibility = Visibility.Visible;
            LabelData.Visibility = labels;
            firstField.Visibility = firstFieldA;
            secondField.Visibility = secondFieldA;
            thirdField.Visibility = thirdFieldA;
        }

        private void SetVisibilityLabels(Visibility firstL, Visibility secondL, Visibility thirdL)
        {
            firstLabel.Visibility = firstL;
            secondLabel.Visibility = secondL;
            thirdLabel.Visibility = thirdL;
        }
    }
}
