using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TodoApp.Models
{
    public class TodoRepositoryJson : ITodoRepository
    {
        private readonly string _filePath;
        private static List<Todo> _todos = new List<Todo>();


        public TodoRepositoryJson(string filePath = @"C:\sw\Todos.json")
        {
            this._filePath = filePath;
            var todos = File.ReadAllText(filePath, Encoding.Default);
            _todos = JsonConvert.DeserializeObject<List<Todo>>(todos); //Json 파일을 역직렬화 함.
        }

        // 인 메모리 데이터 베이스 사용 영역
        /*public void Add(Todo model)
        {
            model.Id = _todos.Max(t => t.Id) + 1;
            _todos.Add(model);
        }*/

        //파일 참조 영역
        public void Add(Todo model)
        {
            model.Id = _todos.Max(t => t.Id) + 1;
            _todos.Add(model);

            //Json 파일 저장
            string json = JsonConvert.SerializeObject(_todos, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        public List<Todo> GetAll()
        {
            return _todos.ToList();
        }
    }
}
