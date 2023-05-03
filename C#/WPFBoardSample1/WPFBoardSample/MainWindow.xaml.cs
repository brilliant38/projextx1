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
                //Console.WriteLine(jsonResult.ToString());
                // 서버 응답 데이터를 TextBox에 뿌리기
                //this.txtRepData.Text = jsonResult.ToString();

                var datas = JsonConvert.DeserializeObject(jsonResult);
                JObject jObject = JObject.Parse(jsonResult);

                //Console.WriteLine("jObject 체크 :" + jObject.ToString());


                // Header를 위한 Row 추가 
                RowColumDefinitions(this.gridBoardList);
                // Header의 Title 추가
                GridHeadAdd(this.gridBoardList);
                // 게시물 데이터를 위한 Row 추가
                //RowColumDefinitions(this.gridBoardList);
                
                // 게시물 데이터 표기
                ChildrenAdd(this.gridBoardList, jObject);

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

            TextBox tbox_BoardNo = new TextBox();
            tbox_BoardNo.Text = "NO";
            tbox_BoardNo.Background = Brushes.Cyan;
            tbox_BoardNo.Margin = new Thickness(2, 2, 2, 2);
            Grid.SetColumn(tbox_BoardNo, 0);
            Grid.SetRow(tbox_BoardNo, 0);
            grid.Children.Add(tbox_BoardNo);

            TextBox tbox_BoardTitle = new TextBox();
            tbox_BoardTitle.Text = "TITLE";
            tbox_BoardTitle.Background = Brushes.Cyan;
            tbox_BoardTitle.Margin = new Thickness(2, 2, 2, 2);
            Grid.SetColumn(tbox_BoardTitle, 1);
            Grid.SetRow(tbox_BoardTitle, 0);
            grid.Children.Add(tbox_BoardTitle);


            TextBox tbox_BoardWriter = new TextBox();
            tbox_BoardWriter.Text = "WRITER";
            tbox_BoardWriter.Background = Brushes.Cyan;
            tbox_BoardWriter.Margin = new Thickness(2, 2, 2, 2);
            Grid.SetColumn(tbox_BoardWriter, 2);
            Grid.SetRow(tbox_BoardWriter, 0);
            grid.Children.Add(tbox_BoardWriter);

            TextBox tbox_BoardHit = new TextBox();
            tbox_BoardHit.Text = "HIT";
            tbox_BoardHit.Background = Brushes.Cyan;
            tbox_BoardHit.Margin = new Thickness(2, 2, 2, 2);
            Grid.SetColumn(tbox_BoardHit, 3);
            Grid.SetRow(tbox_BoardHit, 0);
            grid.Children.Add(tbox_BoardHit);



        }

        /// <summary>
        /// Grid 에 지정된 데이터를 표기합니다.
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="jObject"></param>
        private void ChildrenAdd(Grid grid, JObject jObject)
        {
            //Console.WriteLine($"bizActor로부터 받아온 객체 : \n grid : {grid} + \n Jobject: {jObject}");


            foreach (var item in jObject["result"]["OUT_BRBoard_sel"])
            {
                

                RowDefinition boardList = new RowDefinition();
                boardList.Height = new GridLength(40, GridUnitType.Pixel);
                grid.RowDefinitions.Add(boardList);

                TextBox BoardNo = new TextBox();
                BoardNo.Text = item["NO"].ToString();
                BoardNo.Background = Brushes.Cyan;
                BoardNo.Margin = new Thickness(2, 2, 2, 2);
                Grid.SetColumn(BoardNo, 0);
                Grid.SetRow(BoardNo, grid.RowDefinitions.Count);
                grid.Children.Add(BoardNo);

                TextBox BoardTitle = new TextBox();
                BoardTitle.Text = item["TITLE"].ToString();
                BoardTitle.Background = Brushes.Cyan;
                BoardTitle.Margin = new Thickness(2, 2, 2, 2);
                Grid.SetColumn(BoardTitle, 1);
                Grid.SetRow(BoardTitle, grid.RowDefinitions.Count);
                grid.Children.Add(BoardTitle);

                TextBox BoardWriter = new TextBox();
                BoardWriter.Text = item["WRITER"].ToString();
                BoardWriter.Background = Brushes.Cyan;
                BoardWriter.Margin = new Thickness(2, 2, 2, 2);
                Grid.SetColumn(BoardWriter, 2);
                Grid.SetRow(BoardWriter, grid.RowDefinitions.Count);
                grid.Children.Add(BoardWriter);
                
                TextBox BoardHit = new TextBox();
                BoardHit.Text = item["HIT"].ToString();
                BoardHit.Background = Brushes.Cyan;
                BoardHit.Margin = new Thickness(2, 2, 2, 2);
                Grid.SetColumn(BoardHit, 3);
                Grid.SetRow(BoardHit, grid.RowDefinitions.Count);
                grid.Children.Add(BoardHit);

            }






            




        }
    }
}
