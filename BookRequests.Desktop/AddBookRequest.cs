using BookRequests.Desktop.Enums;
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
    public partial class AddBookRequest : Form
    {
        BookContext ctx = new BookContext();

        public AddBookRequest()
        {
            InitializeComponent();
        }

        private void AddBookRequest_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookRequest bookRequest = new BookRequest();
            Student student = new Student();
            Book book = new Book();
            
            bookRequest.Note = Note.Text;
            bookRequest.Priority = (Priority)Enum.Parse(typeof(Priority), priorty.SelectedText);
            bookRequest.Status = (Status)Enum.Parse(typeof(Status), priorty.SelectedText);
            bookRequest.RequestType = (RequestType)Enum.Parse(typeof(RequestType), priorty.SelectedText);
            bookRequest.RequestDate = requestdate.Value;
            bookRequest.StimateDate = stimateDate.Value;
            bookRequest.Student = student;
            bookRequest.Book = book;
            bookRequest.DateOfScan = scanDate.Value;
            bookRequest.DateOfPrint = printDate.Value;
            ctx.BookRequests.Add(bookRequest);
            ctx.SaveChanges();
        }
    }
}
