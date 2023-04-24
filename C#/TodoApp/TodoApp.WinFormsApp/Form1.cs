using System;
using System.Windows.Forms;
using TodoApp.Models;

namespace TodoApp.WinFormsApp
{
    public partial class Form1 : Form
    {
        private readonly ITodoRepository _repository;
        public Form1()
        {
            InitializeComponent();
            _repository = new TodoRepositoryJson("C:\\sw\\Todos.json");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            this.dataGridView1.DataSource = _repository.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            bool isDone = checkBox1.Checked;

            var todo = new Todo { Title = title, IsDone = isDone };
            _repository.Add(todo);

            DisplayData();
        }
    }
}
