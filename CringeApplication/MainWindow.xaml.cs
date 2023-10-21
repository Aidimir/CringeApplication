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

namespace CringeApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button _button;

        private Boolean _isButtonPressed = false;
        private Brush _currentColor => _isButtonPressed ? Brushes.Yellow : Brushes.Transparent;
        public MainWindow()
        {
            InitializeComponent();
            _button = new Button() { Content = "myButton", Background = Brushes.Transparent };
            _button.Click += Button_Click;
            grdMain.Children.Add(_button);

        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine("MOVED MOUSE");
            if (cringeCircle.IsMouseOver && _isButtonPressed)
            {
                cringeCircle.Fill = Brushes.Red;
            }
            else
            {
                cringeCircle.Fill = _currentColor;
            }
        }
        
        private void Button_Click(object sender, RoutedEventArgs e) //Event which will be triggerd on click of ya button
        {
            _isButtonPressed = !_isButtonPressed;
            cringeCircle.Fill = _currentColor;
        }
    }
}
