using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Input;

namespace WPF_ListviewJson
{
    public class BoardModelDao
    {
        public List<BoardModel> BoardList()
        {
            //bizActor 연결
            HttpWebRequest request = new BizActorCon().BizActorConnection;

            // Refresh
            var jsonReqData = "{\"actID\" : \"BRBoard_sel\",\"inDTName\":\"\",\"outDTName\":\"OUT_BRBoard_sel\",\"refDS\" :{\"REQ_IN_DATA\":[{}]}}";

            using (var streamWriter = new StreamWriter(request.GetRequestStream())) //전송
            {
                streamWriter.Write(jsonReqData);
            }

            // 서버로 부터 응답 데이터 수신
            //  - 데이터 수신 후 GRID에 데이터 출력을 위한 처리
            var response = (HttpWebResponse)request.GetResponse(); //응답
            JObject jObject = null;

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var jsonResult = streamReader.ReadToEnd();
                Console.WriteLine(jsonResult.ToString());

                var datas = JsonConvert.DeserializeObject(jsonResult);
                jObject = JObject.Parse(jsonResult);
            }
            return BoardParse(jObject);
        }


        public List<BoardModel> BoardView(BoardModel Model)
        {
            //bizActor 연결
            HttpWebRequest request = new BizActorCon().BizActorConnection;

            // Refresh
            var jsonReqData = "{\"actID\" : \"BRBoard_view\",\"inDTName\":\"IN_DATA\",\"outDTName\":\"OUT_DATA\",\"refDS\" :{\"IN_DATA\":[{\"NO\":\""+ Model.No+"\"}]}}";

            using (var streamWriter = new StreamWriter(request.GetRequestStream())) //전송
            {
                streamWriter.Write(jsonReqData);
            }

            // 서버로 부터 응답 데이터 수신
            //  - 데이터 수신 후 GRID에 데이터 출력을 위한 처리
            var response = (HttpWebResponse)request.GetResponse(); //응답
            JObject jObject = null;

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var jsonResult = streamReader.ReadToEnd();
                Console.WriteLine(jsonResult.ToString());

                var datas = JsonConvert.DeserializeObject(jsonResult);
                jObject = JObject.Parse(jsonResult);
            }
            return BoardParse(jObject);
        }


        public void BoardWrite(BoardModel Model)
        {
            //bizActor 연결
            HttpWebRequest request = new BizActorCon().BizActorConnection;


            // Write
            var jsonReqData = "{\"actID\" : \"BRBoard_add\",\"inDTName\":\"IN_DATA\",\"outDTName\":\"\",\"refDS\" :" +
                "{\"IN_DATA\":[{\"TITLE\":\"" +Model.Title+ "\",\"CONTENT\":\"" +Model.Content+ "\",\"WRITER\":\"" +Model.Writer+ "\",\"PW\":\"" +Model.Pw+ "\"}]}}";
            

            using (var streamWriter = new StreamWriter(request.GetRequestStream())) //전송
            {
                streamWriter.Write(jsonReqData);
            }

            // 서버로 부터 응답 데이터 수신
            //  - 데이터 수신 후 GRID에 데이터 출력을 위한 처리
            var response = (HttpWebResponse)request.GetResponse();

        }

        public void BoardUpdate(BoardModel Model) 
        {
            //bizActor 연결
            HttpWebRequest request = new BizActorCon().BizActorConnection;


            // Update
            var jsonReqData = "{\"actID\" : \"BRBoard_upd\",\"inDTName\":\"IN_DATA\",\"outDTName\":\"\",\"refDS\" :" +
                "{\"IN_DATA\":[{\"TITLE\":\"" + Model.Title + "\",\"CONTENT\":\"" + Model.Content + "\",\"NO\":\"" + Model.No + "\",\"PW\":\"" + Model.Pw + "\"}]}}";


            using (var streamWriter = new StreamWriter(request.GetRequestStream())) //전송
            {
                streamWriter.Write(jsonReqData);
            }

            // 서버로 부터 응답 데이터 수신
            //  - 데이터 수신 후 GRID에 데이터 출력을 위한 처리
            var response = (HttpWebResponse)request.GetResponse();
        }

        public void BoardDelete(BoardModel Model)
        {
            //bizActor 연결
            HttpWebRequest request = new BizActorCon().BizActorConnection;


            // Delete
            var jsonReqData = "{\"actID\" : \"BRBoard_del\",\"inDTName\":\"IN_DATA\",\"outDTName\":\"\",\"refDS\" :" +
                "{\"IN_DATA\":[{\"NO\":\""+ Model.No +"\",\"PW\":\"" + Model.Pw + "\"}]}}";


            using (var streamWriter = new StreamWriter(request.GetRequestStream())) //전송
            {
                streamWriter.Write(jsonReqData);
            }

            // 서버로 부터 응답 데이터 수신
            //  - 데이터 수신 후 GRID에 데이터 출력을 위한 처리
            var response = (HttpWebResponse)request.GetResponse();
        }

        List<BoardModel> BoardParse(JObject jsonData)
        {
            List<BoardModel> BoardList = new List<BoardModel>();

            foreach (JObject item in jsonData["result"]["OUT_BRBoard_sel"])
            {
                BoardModel board = new BoardModel()
                {
                    No = int.Parse(item["NO"].ToString()),
                    Hit = int.Parse(item["HIT"].ToString()),
                    Title = item["TITLE"].ToString(),
                    WriteDate = item["WRITEDATE"].ToString(),
                    Writer = item["WRITER"].ToString()
                };
                BoardList.Add(board);
            }

            return BoardList;

        }
    }
}
