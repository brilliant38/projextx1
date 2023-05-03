using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFBoardSample3.Models;

namespace WPFBoardSample3.ViewModels
{
    public class BoardViewModel
    {
        private readonly BoardModelList board;


        //생성자
        public BoardViewModel()
        {
            this.board = new BoardModelList();
        }

        //필드
        public BoardModelList Board
        {
            get { return this.board; }
        }
    }
}
