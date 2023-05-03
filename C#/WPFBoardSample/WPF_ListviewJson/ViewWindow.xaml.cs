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

namespace WPF_ListviewJson
{
    /// <summary>
    /// ViewWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ViewWindow : Window
    {

        BoardModel boardModel;

        public BoardModel BoardModel { get; set; }

        public ViewWindow()
        {
            InitializeComponent();
        }


        public ViewWindow(BoardModel boardD) : this()
        {
            BoardModel = boardD;

            this.DataContext = BoardModel;
        }

        private void Posting_Update(object sender, RoutedEventArgs e)
        {   
            Close();
            new UpdateWindow().Show();
        }

        private void Posting_Delete(object sender, RoutedEventArgs e)
        {   
            BoardModel Model = new BoardModel();
            new BoardModelDao().BoardDelete(BoardModel);
            Close();
        }
    }
}
