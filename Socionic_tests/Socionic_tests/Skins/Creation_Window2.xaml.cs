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
using System.Windows.Shapes;

namespace Socionic_tests.Skins
{
    /// <summary>
    /// Interaction logic for Creation_Window2.xaml
    /// </summary>
    public partial class Creation_Window2 : Window
    {
        public Creation_Window2()
        {
            InitializeComponent();
        }
        private void userInput1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput1.Text))
            {
                userInput1.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedTxt1.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void watermarkedTxt1_GotFocus(object sender, RoutedEventArgs e)
        {

            watermarkedTxt1.Visibility = System.Windows.Visibility.Collapsed;
            userInput1.Visibility = System.Windows.Visibility.Visible;
            userInput1.Focus();

        }

        private void userInput2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput2.Text))
            {
                userInput2.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedTxt2.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void watermarkedTxt2_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedTxt2.Visibility = System.Windows.Visibility.Collapsed;
            userInput2.Visibility = System.Windows.Visibility.Visible;
            userInput2.Focus();
        }

        private void userInput3_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput3.Text))
            {
                userInput3.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedTxt3.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void watermarkedTxt3_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedTxt3.Visibility = System.Windows.Visibility.Collapsed;
            userInput3.Visibility = System.Windows.Visibility.Visible;
            userInput3.Focus();
        }

        private void userInput4_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput4.Text))
            {
                userInput4.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedTxt4.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void watermarkedTxt4_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedTxt4.Visibility = System.Windows.Visibility.Collapsed;
            userInput4.Visibility = System.Windows.Visibility.Visible;
            userInput4.Focus();
        }

        private void userInput5_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput5.Text))
            {
                userInput5.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedtxt5.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void watermarkedtxt5_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedtxt5.Visibility = System.Windows.Visibility.Collapsed;
            userInput5.Visibility = System.Windows.Visibility.Visible;
            userInput5.Focus();
        }

        private void watermarkedTxt6_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedTxt6.Visibility = System.Windows.Visibility.Collapsed;
            userInput6.Visibility = System.Windows.Visibility.Visible;
            userInput6.Focus();
        }

        private void userInput6_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput6.Text))
            {
                userInput6.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedTxt6.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void userInput7_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput7.Text))
            {
                userInput7.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedTxt7.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void watermarkedTxt7_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedTxt7.Visibility = System.Windows.Visibility.Collapsed;
            userInput7.Visibility = System.Windows.Visibility.Visible;
            userInput7.Focus();
        }

        private void watermarkedTxt8_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedTxt8.Visibility = System.Windows.Visibility.Collapsed;
            userInput8.Visibility = System.Windows.Visibility.Visible;
            userInput8.Focus();
        }

        private void userInput8_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput8.Text))
            {
                userInput8.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedTxt8.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void userInput9_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput9.Text))
            {
                userInput9.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedTxt9.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void watermarkedTxt9_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedTxt9.Visibility = System.Windows.Visibility.Collapsed;
            userInput9.Visibility = System.Windows.Visibility.Visible;
            userInput9.Focus();
        }

        private void userInput10_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput10.Text))
            {
                userInput10.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedtxt10.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void watermarkedtxt10_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedtxt10.Visibility = System.Windows.Visibility.Collapsed;
            userInput10.Visibility = System.Windows.Visibility.Visible;
            userInput10.Focus();
        }

        private void userInput11_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput11.Text))
            {
                userInput11.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedTxt11.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void watermarkedTxt11_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedTxt11.Visibility = System.Windows.Visibility.Collapsed;
            userInput11.Visibility = System.Windows.Visibility.Visible;
            userInput11.Focus();
        }

        private void userInput12_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput12.Text))
            {
                userInput12.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedTxt12.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void watermarkedTxt12_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedTxt12.Visibility = System.Windows.Visibility.Collapsed;
            userInput12.Visibility = System.Windows.Visibility.Visible;
            userInput12.Focus();
        }

        private void userInput13_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput13.Text))
            {
                userInput13.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedTxt13.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void watermarkedTxt13_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedTxt13.Visibility = System.Windows.Visibility.Collapsed;
            userInput13.Visibility = System.Windows.Visibility.Visible;
            userInput13.Focus();
        }

        private void userInput14_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput14.Text))
            {
                userInput14.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedtxt14.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void watermarkedtxt14_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedtxt14.Visibility = System.Windows.Visibility.Collapsed;
            userInput14.Visibility = System.Windows.Visibility.Visible;
            userInput14.Focus();
        }

        private void userInput15_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput15.Text))
            {
                userInput15.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedTxt15.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void watermarkedTxt15_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedTxt15.Visibility = System.Windows.Visibility.Collapsed;
            userInput15.Visibility = System.Windows.Visibility.Visible;
            userInput15.Focus();
        }
    }
}