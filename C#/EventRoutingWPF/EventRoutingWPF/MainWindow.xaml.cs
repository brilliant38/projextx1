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

namespace EventRoutingWPF
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        string mouseActivity = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        //버블링 이벤트 -> button - stackpanel - windows 순으로 상위 진행 됨
        //private void Window_Click(object sender, RoutedEventArgs e)
        //{
        //    txt3.Text = "Click event is bubbled to Window";
        //}

        //private void StackPanel_Click(object sender, RoutedEventArgs e)
        //{
        //    txt2.Text = "Click event is bubbled to Stack Panel";
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    txt1.Text = "Button is Clicked";
        //    e.Handled = true; // 상위 객체로 버블링 되는것을 막음
        //}

        //터널링 이벤트 -> windows - stackpanel - button 순으로 하위 진행 됨
        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            mouseActivity = "PreviewMouseDown Window \n";
            MessageBox.Show(mouseActivity);
        }

        private void StackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            mouseActivity = "PreviewMouseDown StackPanel \n";
            MessageBox.Show(mouseActivity);
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            mouseActivity = "PreviewMouseDown Button \n";
            MessageBox.Show(mouseActivity);
        }
    }
}
