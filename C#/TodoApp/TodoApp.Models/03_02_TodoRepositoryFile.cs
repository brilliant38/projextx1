using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TodoApp.Models
{
    public class TodoRepositoryFile : ITodoRepository
    {   
        private readonly string _filePath;
        private static List<Todo> _todos = new List<Todo>();

        /*public TodoRepositoryInFile()
        {
            _todos = new List<Todo>
            {
                new Todo {Id = 1, Title = "ASP.NET Core 학습", IsDone = false },
                new Todo {Id = 2, Title = "Blazor 학습", IsDone = false },
                new Todo {Id = 3, Title = "C# 학습", IsDone = true }
            };
        }*/

        public TodoRepositoryFile(string filePath = @"C:\sw\Todos.txt")
        {
            this._filePath = filePath;
            string[] todos = File.ReadAllLines(filePath, Encoding.Default);
            foreach (var t in todos)
            {
                string[] line = t.Split(',');//,기준 라인 단위로 구분 필요
                _todos.Add(new Todo { Id = Convert.ToInt32(line[0]), Title = line[1], IsDone = Convert.ToBoolean(line[2]) });
            }
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

            //파일 저장
            string data = "";
            foreach (var t in _todos)
            {
                data += $"{t.Id},{t.Title},{t.IsDone}{Environment.NewLine}";
            }
            using (StreamWriter sw = new StreamWriter(_filePath))
            {
                sw.Write(data);
                sw.Close();
                //sw.Dispose(); using 사용시에는 안 써도 됨. 자동 메모리 해제되므로
            }
        }

        public List<Todo> GetAll()
        {
            return _todos.ToList();
        }
    }
}
