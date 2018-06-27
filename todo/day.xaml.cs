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

namespace todo
{
    /// <summary>
    /// day.xaml 的互動邏輯
    /// </summary>
    public partial class day : Window
    {
        private string nowText;

        private void Textarea_TextChanged(object sender, TextChangedEventArgs e)
        {
            nowText = Textarea.Text;
        }
        public day()
        {
            
        }

        private void dayBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void addNoteBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
