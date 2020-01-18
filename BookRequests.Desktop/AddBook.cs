using BookRequests.Desktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRequests.Desktop
{
    public partial class AddBook : Form
    {
        BookContext ctx= new BookContext(); 
        public AddBook()
        {
            InitializeComponent();
            Initialize();
        }
        private void Initialize()
        {
          //  stateComboBox.DataSource = StateArray.Abbreviations();
           // PopulateContactListBox();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Arabic");
            comboBox1.Items.Add("English");     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.BookName = textBox1.Text;
            book.NumberOfPage = int.Parse(textBox2.Text);
            book.Language = comboBox1.SelectedItem.ToString();
            ctx.Books.Add(book);
            ctx.SaveChanges();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
