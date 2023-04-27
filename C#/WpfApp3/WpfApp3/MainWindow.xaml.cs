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

namespace WpfApp3
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Binding bind = new Binding();
            //bind.Source = txt1;
            //bind.Path = new PropertyPath(TextBox.TextProperty);
            //SetBinding의 첫 번째 인자는 DependencyProperty 타입이 되어야 한다.
            //그러므로 타겟의 속성은 의존 속성의 지원을 받는 속성이 되야한다.
            //label.SetBinding(Label.ContentProperty, bind);
        }
    }
}
