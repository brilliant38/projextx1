using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ListviewJson
{
    internal class BizActorCon
    {
        public HttpWebRequest BizActorConnection { get; }

        public BizActorCon()
        {
            string responseData = String.Empty;
            string apiUrl = "http://localhost:18080/bizarest";

            // 서버에 입력된 JSON 데이터 전송 
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
            request.Method = "POST";
            request.ContentType = "application/json; utf-8";

            this.BizActorConnection = request;
        }
    }
}
