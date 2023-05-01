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

namespace WPFBoardSample
{
    // 관련 없는 로직
    //public class BookMasterInfo
    //{
    //    //BOOKID String
    //    //BOOKNM String
    //    //AUTHOR String
    //    //PUBLER String
    //    //KEYWORD String
    //    private string BookId;
    //    private string BookNm;
    //    private string Author;
    //    private string Publer;
    //    private string Keyword;

    //    public string BookId1 { get => BookId; set => BookId = value; }
    //    public string BookNm1 { get => BookNm; set => BookNm = value; }
    //    public string Author1 { get => Author; set => Author = value; }
    //    public string Publer1 { get => Publer; set => Publer = value; }
    //    public string Keyword1 { get => Keyword; set => Keyword = value; }
    //}
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetBoardListInfo_Click(object sender, RoutedEventArgs e)
        {
            // 참고 사이트 
            // https://m.blog.naver.com/xqnstk/221807573691
            // http://kusa104.egloos.com/v/3418199
            // https://s-engineer.tistory.com/337
            // https://wookoa.tistory.com/87
            // https://ehpub.co.kr/grid-cs-wpf/

            // 숙제
            //  1. header 타이틀에 데이터가 겹쳐서 출력되는 현상 수정
            //  2. 서버에서 reply 받은 데이터 모두를 grid에 표기 (지금은 1건만 조회하도록 되어있음)
            //  3. 조회 기능 외에 기능 추가/삭제/수정 기능까지 추가


            // 서버 URL
            string apiUrl = "http://localhost:18080/bizarest";

            // 사용자 입력한 JSON 형식 데이터를 받아옴
            var jsonReqData = this.txtReqData.Text;

            // 서버에 입력된 JSON 데이터 전송 
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
            request.Method = "POST";
            request.ContentType = "application/json; utf-8";

            using (var streamWriter = new StreamWriter(request.GetRequestStream())) //전송
            {
                streamWriter.Write(jsonReqData);
            }

            // 서버로 부터 응답 데이터 수신
            //  - 데이터 수신 후 GRID에 데이터 출력을 위한 처리
            var response = (HttpWebResponse)request.GetResponse(); //응답
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var jsonResult = streamReader.ReadToEnd();
                Console.WriteLine(jsonResult.ToString());
                // 서버 응답 데이터를 TextBox에 뿌리기
                this.txtRepData.Text = jsonResult.ToString();

                var datas = JsonConvert.DeserializeObject(jsonResult);
                JObject jObject = JObject.Parse(jsonResult);

                
                // Header를 위한 Row 추가 
                RowColumDefinitions(this.gridBoardList);
                // Header의 Title 추가
                GridHeadAdd(this.gridBoardList);
                // 게시물 데이터를 위한 Row 추가
                RowColumDefinitions(this.gridBoardList);
                // 게시물 데이터 표기
                ChildrenAdd(this.gridBoardList, jObject);






                // -- 관련 없는 로직
                //this.gridBoardList.Children.Add(txtblkBookId);


                //List<BookMasterInfo> lstBookMasterInfo = JsonConvert.DeserializeObject<List<BookMasterInfo>>(jsonResult);

                //foreach(BookMasterInfo bookMastInfo in lstBookMasterInfo)
                //{
                //    TextBlock txtblkBookId = new TextBlock()
                //    {
                //        Text = bookMastInfo.BookId1
                //    };

                //    this.gridBoardList.Children.Add(txtblkBookId);
                //}

            }

        }

        /// <summary>
        /// Grid에 신규 Row를 추가 합니다.
        /// </summary>
        /// <param name="grid"></param>
        private void RowColumDefinitions(Grid grid)
        {
            RowDefinition rd1 = new RowDefinition();
            rd1.Height = new GridLength(40, GridUnitType.Pixel);            
            grid.RowDefinitions.Add(rd1);            
        }

        /// <summary>
        /// Grid 에 신규 Header를 추가 합니다.
        /// </summary>
        /// <param name="grid"></param>
        private void GridHeadAdd(Grid grid)
        {

            TextBox tbox_bookid = new TextBox();
            tbox_bookid.Text = "Book ID";
            tbox_bookid.Background = Brushes.Cyan;
            tbox_bookid.Margin = new Thickness(2, 2, 2, 2);
            Grid.SetColumn(tbox_bookid, 0);
            Grid.SetRow(tbox_bookid, 0);
            grid.Children.Add(tbox_bookid);

            TextBox tbox_booknm = new TextBox();
            tbox_booknm.Text = "Book Name";
            tbox_booknm.Background = Brushes.Cyan;
            tbox_booknm.Margin = new Thickness(2, 2, 2, 2);
            Grid.SetColumn(tbox_booknm, 1);
            Grid.SetRow(tbox_bookid, 0);
            grid.Children.Add(tbox_booknm);


            TextBox tbox_publer = new TextBox();
            tbox_publer.Text = "Publer";
            tbox_publer.Background = Brushes.Cyan;
            tbox_publer.Margin = new Thickness(2, 2, 2, 2);
            Grid.SetColumn(tbox_publer, 2);
            Grid.SetRow(tbox_bookid, 0);
            grid.Children.Add(tbox_publer);

        }

        /// <summary>
        /// Grid 에 지정된 데이터를 표기합니다.
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="jObject"></param>
        private void ChildrenAdd(Grid grid, JObject jObject)
        {

            TextBox tbox_bookid  = new TextBox();
            tbox_bookid.Text = jObject["result"]["BookInfo"][0]["BOOKID"].ToString();
            tbox_bookid.Background = Brushes.Cyan;
            tbox_bookid.Margin = new Thickness(2, 2, 2, 2);            
            Grid.SetColumn(tbox_bookid, 0);
            Grid.SetRow(tbox_bookid, grid.RowDefinitions.Count);
            grid.Children.Add(tbox_bookid);

            TextBox tbox_booknm = new TextBox();
            tbox_booknm.Text = jObject["result"]["BookInfo"][0]["BOOKNM"].ToString();
            tbox_booknm.Background = Brushes.Cyan;
            tbox_booknm.Margin = new Thickness(2, 2, 2, 2);
            Grid.SetColumn(tbox_booknm, 1);
            Grid.SetRow(tbox_bookid, grid.RowDefinitions.Count);
            grid.Children.Add(tbox_booknm);


            TextBox tbox_publer = new TextBox();
            tbox_publer.Text = jObject["result"]["BookInfo"][0]["PUBLER"].ToString();
            tbox_publer.Background = Brushes.Cyan;
            tbox_publer.Margin = new Thickness(2, 2, 2, 2);
            Grid.SetColumn(tbox_publer, 2);
            Grid.SetRow(tbox_bookid, grid.RowDefinitions.Count);
            grid.Children.Add(tbox_publer);

        }

        private void textEmail_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtEmail.Focus();
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtEmail.Text) && txtEmail.Text.Length > 0)
            {
                textEmail.Visibility = Visibility.Collapsed;
            }
            else
            {
                textEmail.Visibility = Visibility.Visible;
            }
        }

        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPassword.Focus();
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Password) && txtPassword.Password.Length > 0)
            {
                textPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                textPassword.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Successfully Signed In");
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        
    }
}
