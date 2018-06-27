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

namespace todo
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        private int a;

        private void dayBtn_Click(object sender, RoutedEventArgs e)
        {
            
            a = 1;
            MainWindow day = new MainWindow ();
            this.Close();
            day.Show();

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)//偵測視窗有沒有被關掉
        {
            if (a != 1)
                Application.Current.Shutdown();
        }
       
    }
}
