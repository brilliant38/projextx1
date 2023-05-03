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
    /// UpdateWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UpdateWindow : Window
    {
        public UpdateWindow()
        {
            InitializeComponent();
        }

        private void Posting_Okay(object sender, RoutedEventArgs e)
        {
            //글 등록 okay

            BoardModel boardModel = new BoardModel();
            boardModel.Title = Title.Text;
            boardModel.Content = Content.Text;
            boardModel.Pw = Password.Password;

            //글 쓰기 실행
            new BoardModelDao().BoardUpdate(boardModel);

            //새 리스트 불러오기
            new BoardModelDao().BoardList();

            Close();
        }

        private void Posting_Cancel(object sender, RoutedEventArgs e)
        {
            //글 등록 취소
            Close();
        }
    }
}
