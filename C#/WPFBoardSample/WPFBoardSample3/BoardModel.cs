using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBoardSample3.Models
{
    public class Board
    {
        public int No { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Writer { get; set; }
        public string WriteDate { get; set; }
        public int Hit { get; set; }
        public string PassWord { get; set; }

        public Board(int No, string Title, string Writer, int Hit)
        {
            this.No = No;
            this.Title = Title;
            this.Writer = Writer;
            this.Hit = Hit;
        }
    }
    public class BoardModel
    {
        private static object _threadLock = new Object();
        private static BoardModel current = null;

        public static BoardModel Current
        {
            get
            {
                lock (_threadLock)
                {
                    if (current == null) { current = new BoardModel(); }
                }
                return current;
            }
        }

        private BoardModel()
        {

        }

        public void AddBoard(int No, string Title, string Writer, int Hit)
        {
            Board New_Board = new Board(No, Title, Writer, Hit);
            Add(New_Board);

        }

    }


}
