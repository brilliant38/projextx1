// MainWindow.cs
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace WPF_ListviewJson
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            //게시판 리스트 출력
            lview_Data.ItemsSource = new BoardModelDao().BoardList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //게시판 리스트 출력
            lview_Data.ItemsSource = new BoardModelDao().BoardList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Write
            new InsertWindow().Show();

        }

        private void BoardView(object sender, MouseButtonEventArgs e)
        {
            ////View
            
            BoardModel Model = new BoardModel();
            Console.WriteLine("========================================");
            Console.WriteLine("BoardMain Test" + BoardMain.Columns[0].CellTemplate.); 

            new ViewWindow(Model).Show();

        }
    }

}