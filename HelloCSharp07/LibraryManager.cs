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
    public partial class LibraryManager : Form
    {
        public LibraryManager()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            if(DataManager.Books.Count>0)
                dataGridView1.DataSource = DataManager.Books;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // 책 추가 button_add
        private void button1_Click(object sender, EventArgs e)
        {
            bool existBook = false;
            foreach(var item in DataManager.Books)
            {
                // C#은 equals 대신 ==으로 string 비교 가능
                // java는 버전에 따라, 상황에 따라 다르다.
                if(item.isbn == textBox1.Text)
                {
                    existBook = true;
                    break;
                }
            }
            if (existBook)
            {
                MessageBox.Show("이미 있음");
            }
            else
            {
                Book book = new Book();
                book.isbn = textBox1.Text;
                book.name = textBox2.Text;
                book.publisher = textBox3.Text;
                int.TryParse(textBox4.Text, out int page);
                book.page = page;
                if(page <= 0)
                {
                    MessageBox.Show("Page가 이상해요");
                    return;
                }
                DataManager.Books.Add(book);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.Books;
                DataManager.Save();
                //book.page = textBox3.Text
            }
        }

        // 책 수정 button_edit
        private void button2_Click(object sender, EventArgs e)
        {

        }

        // 책 삭제 button_delete
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
