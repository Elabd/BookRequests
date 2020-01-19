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
            // TODO: This line of code loads data into the 'bookDBDataSet2.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.bookDBDataSet2.Students);
            // TODO: This line of code loads data into the 'bookDBDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.bookDBDataSet.Books);
            Status.Items.Add(Enums.Status.Done);
            Status.Items.Add(Enums.Status.Cancel);
            Status.Items.Add(Enums.Status.Waiting);

            priorty.Items.Add(Priority.High);
            priorty.Items.Add(Priority.Low);


            requestType.Items.Add(RequestType.Pdf);
            requestType.Items.Add(RequestType.Word);

            var books = ctx.Books.ToList();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            BookRequest bookRequest = new BookRequest();
            Student student = new Student();
            Book book = new Book();
            book = ctx.Books.FirstOrDefault(b=>b.Id==Book.SelectedIndex);
            student = ctx.Students.FirstOrDefault(s => s.Id == Student.SelectedIndex);
            bookRequest.Note = Note.Text;
            bookRequest.Priority = (Priority)Enum.Parse(typeof(Priority), priorty.SelectedItem.ToString());
            bookRequest.Status = (Status)Enum.Parse(typeof(Status), Status.SelectedItem.ToString());
            bookRequest.RequestType = (RequestType)Enum.Parse(typeof(RequestType), requestType.SelectedItem.ToString());
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
