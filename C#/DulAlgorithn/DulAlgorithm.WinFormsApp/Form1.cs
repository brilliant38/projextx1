using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DulAlgorithm.WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //[1] input
            int[] data = { 1, 4, 3, 2, 5 };

            //[2] Process //참조 한 라이브러리의 기능 사용
            int[] numbers = DulAlgorithm.Algorithm.SelectionSort(data);

            //[3] output
            MessageBox.Show(data[0].ToString()); //4
        }
    }
}
