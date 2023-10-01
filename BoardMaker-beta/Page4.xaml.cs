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

namespace BoardMaker_beta
{
    /// <summary>
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        BitmapImage yes = new BitmapImage(new Uri(@"/correct.png", UriKind.Relative));
        BitmapImage no = new BitmapImage(new Uri(@"/remove.png", UriKind.Relative));
        public Page4()
        {
            InitializeComponent();
        }

        private void codeField_Copy1_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if(nameField.Text.Length > 0 && !nameField.Text.Equals("Имя"))
                nameValid.Source = yes;
            else
                nameValid.Source = no;
        }

        private void Enter(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page3());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page1());
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Имя")
                textBox.Text = "";
        }
    }
}
