using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.WebApplication
{
    public partial class TodoList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            const string url = "https://localhost:44372/api/todos";


            using (var client = new HttpClient())
            {
                //데이터 전달
                var json = JsonConvert.SerializeObject(new Todo { Title = "HttpClient", IsDone = true }); //새로 던질 데이터의 json타입 직렬화
                var post = new StringContent(json, Encoding.UTF8, "application/json");//post방식으로 데이터 저장

                //client.PostAsync(url, post).Wait();//post로 던짐

                //데이터 수신

                var response = client.GetAsync(url).Result;//
                var result = response.Content.ReadAsStringAsync().Result;
                var todos = JsonConvert.DeserializeObject<List<Todo>>(result);

                //필터링 : LINQ로 함수형 프로그램 스타일 구현
                //SELECT() : MAP()
                /*IEnumerable<Todo> q = from todo in todos
                        select todo;
                //var q = todos.Select(t => t);
                var q = from todo in todos
                        select new TodoViewModel { };*/
                var query = todos.AsQueryable<Todo>();
                
                //조건 처리
                if(DateTime.Now.Second % 2 == 0)
                {
                    query = query.Where(it => it.Id % 2 == 0);// id가 짝수 인 것만
                }
                else
                {
                    query = query.Where(it => it.Id % 2 == 1);// id가 홀수 인 것만
                }
                //조건 처리 2
                query = query.Where(it => it.IsDone == false); // 그 중에서 false 인 것만

                // 정렬
                const string sortOrder = "Title";
                query = (sortOrder == "Title" ? query.OrderBy(it => it.Title) : query);
                var q = query.Select(t => new TodoViewModel 
                { 
                    Title = t.Title, IsDone = t.IsDone
                });


                //데이터 바인딩
                this.GridView1.DataSource = q;
                this.GridView1.DataBind();

                this.GridView2.DataSource = todos
                    .Where(t => t.Id % 2 == 1 && t.IsDone == false)
                    .OrderByDescending(t=> t.Title)
                    .Select(t=> new { 제목 = t.Title, 완료여부 = t.IsDone})
                    .ToList(); //결과에 대해 메서드 체이닝.
                this.GridView2.DataBind();
            }
        }
    }
    public class TodoViewModel //변경해서 출력할 데이터 형식
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }

    public class Todo //받을 데이터 형식
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}