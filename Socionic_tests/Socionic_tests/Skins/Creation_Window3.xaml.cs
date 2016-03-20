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
using System.Text.RegularExpressions;

namespace Socionic_tests.Skins
{
    /// <summary>
    /// Interaction logic for Creation_Window3.xaml
    /// </summary>
    public partial class Creation_Window3 : Window
    {
        public Creation_Window3()
        {
            InitializeComponent();
            //подписываем textBox на событие PreviewTextInput, 
            //с помощью которого можно обрабатывать вводимый текст
            textBox1.PreviewTextInput += new TextCompositionEventHandler(textBox_PreviewTextInput);
        }

        //создаем регулярное выражение, описывающее правило ввода
        //в данном случае, это символы от 0 до 9
        Regex inputRegex = new Regex(@"^[0-9]$");

        //сам обработчик события PreviewTextInput для элемента textBox
        void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //проверяем или подходит введенный символ нашему правилу
            Match match = inputRegex.Match(e.Text);
            //и проверяем или выполняется условие
            //если количество символов в строке больше или равно трем либо
            //если введенный символ не подходит нашему правилу
            if ((sender as TextBox).Text.Length >= 3 || !match.Success)
            {
                //то обработка события прекращается и ввода неправильного символа не происходит
                e.Handled = true;
            }
        }

    }
}
