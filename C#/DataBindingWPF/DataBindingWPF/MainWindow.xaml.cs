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

namespace DataBindingWPF
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        ////바인딩 대상 속성들
        //public bool Seoul { get; set; }
        //public bool Jeju { get; set; }
        //public bool Incheon { get; set; }

        public MainWindow()
        {
            this.InitializeComponent();

            //바인딩의 소스객체, UI컨트롤에서 소스 지정없이 사용가능.
            //window의 하위 객체에서 소스 속성으로 사용가능.
            //this.DataContext = this;

            //MyViewModel _viewmodel = new MyViewModel()
            //{
            //    Date = new DateTime(2023, 4, 26),
            //    Title = "WPF User Group"
            //};
            //this.DataContext = _viewmodel;

        }


        //버튼 클릭 이벤트 핸들러
        //private void Summit_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show(string.Format("SEOUL: {0}, JEJU: {1}, INCHEON: {2}", Seoul, Jeju, Incheon));
        //}


    }
}
