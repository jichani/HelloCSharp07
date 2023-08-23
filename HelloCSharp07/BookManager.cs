using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp07
{
    public partial class BookManager : Form
    {
        public BookManager()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ShowDialog : 모달
            // 뒤에꺼 클릭 안 되고 코드가 여기서 멈춰있다.
            new UserManager().ShowDialog();
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LibraryManager().ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
