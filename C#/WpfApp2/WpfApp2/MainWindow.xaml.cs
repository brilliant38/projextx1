using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //DependencyProperty(MyProperty)를 위한 래퍼속성 MyColor
        public String MyColor
        {
            get { return (String)GetValue(MyProperty); }
            set { SetValue(MyProperty, value); }
        }

        //의존속성 정의
        public static readonly DependencyProperty MyProperty = DependencyProperty.Register(
            "MyColor",           //의존속성으로 등록 될 속성
            typeof(String),
            typeof(MainWindow),
            new FrameworkPropertyMetadata(new PropertyChangedCallback(OnMyPropertyChanged)
            ));

        private static void OnMyPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MainWindow win = d as MainWindow;
            SolidColorBrush brush = (SolidColorBrush)new BrushConverter().ConvertFromString(e.NewValue.ToString());
            win.Background = brush;
            win.Title = (e.OldValue == null) ? "이전배경색 없음" : "배경색:" + e.OldValue.ToString();
            win.textBox1.Text = e.NewValue.ToString();
        }

        private void ContextMenu_Click(object sender, RoutedEventArgs e)
        {
            string str = (e.Source as MenuItem).Header as string;
            MyColor = str;
        }
    }
}
