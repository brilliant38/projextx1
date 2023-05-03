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
using WPFBoardSample3.Models;

namespace WPFBoardSample3
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
            var jsonReqData = " \"actID\" : \"BRBoard_sel\",\"inDTName\":\"\",\"outDTName\":\"OUT_BRBoard_sel\",\"refDS\" :{ \"REQ_IN_DATA\":[{ }]}} ";
            Console.WriteLine(jsonReqData);
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
                //this.txtRepData.Text = jsonResult.ToString();

                var datas = JsonConvert.DeserializeObject(jsonResult);
                JObject jObject = JObject.Parse(jsonResult);

                //Console.WriteLine("jObject 체크 :" + jObject.ToString());

                //리스트 뷰 초기화
                uiLv_Main.ItemsSource = null;

                // Refresh
                
                JArray array = JArray.Parse(jObject["result"]["OUT_BRBoard_sel"].ToString());
                foreach (JObject itemObj in array)
                {
                    Add(new BoardModel()
                    {
                        No = Int32.Parse(itemObj["NO"].ToString()),
                        Title = itemObj["TITLE"].ToString(),
                        Hit = Int32.Parse(itemObj["HIT"].ToString())
                    });
                }

                uiLv_Main.ItemsSource = ParseComment(responseData);

            }
        }
    }
}
