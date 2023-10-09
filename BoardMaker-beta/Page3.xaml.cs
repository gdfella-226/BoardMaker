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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BoardMaker_beta
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void MailGotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Электронная почта")
            {
                textBox.Text = "";

            }
        }

        private void MailLostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Электронная почта";
                textBox.Foreground = Brushes.Black; // Верните цвет текста обратно в серый
            }
        }

        private void PassGotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Пароль")
            {
                textBox.Text = "";

            }
        }

        private void PassLostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Пароль";
                textBox.Foreground = Brushes.Black; // Верните цвет текста обратно в серый
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page4());
        }
        private void Shablon(object sender, RoutedEventArgs e)
        {
            Window1 newWindow = new Window1(); 
            
            Window window=Window.GetWindow(this);
            window.Close();
            newWindow.Show();
        }
        private void MouseButton(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page5());
        }
    }
}
