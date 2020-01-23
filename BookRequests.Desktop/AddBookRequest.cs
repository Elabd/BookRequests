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
            comboBoxStatus.Items.Add(Enums.Status.Done);
            comboBoxStatus.Items.Add(Enums.Status.Cancel);
            comboBoxStatus.Items.Add(Enums.Status.Waiting);

            comboBoxPriorties.Items.Add(Priority.High);
            comboBoxPriorties.Items.Add(Priority.Low);


            comboBoxrequestTypes.Items.Add(RequestType.Pdf);
            comboBoxrequestTypes.Items.Add(RequestType.Word);

            var books = ctx.Books.ToList();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            BookRequest bookRequest = new BookRequest();
            Student student = new Student();
            Book book = new Book();
            book = ctx.Books.FirstOrDefault(b=>b.Id==comboBoxBooks.SelectedIndex);
            student = ctx.Students.FirstOrDefault(s => s.Id == comboBoxStudents.SelectedIndex);
            bookRequest.Note = Note.Text;
            bookRequest.Priority = (Priority)Enum.Parse(typeof(Priority), comboBoxPriorties.SelectedItem.ToString());
            bookRequest.Status = (Status)Enum.Parse(typeof(Status), comboBoxStatus.SelectedItem.ToString());
            bookRequest.RequestType = (RequestType)Enum.Parse(typeof(RequestType), comboBoxrequestTypes.SelectedItem.ToString());
            bookRequest.RequestDate = requestdate.Value;
            bookRequest.StimateDate = stimateDate.Value;
            bookRequest.Student = student;
            bookRequest.Book = book;
            bookRequest.DateOfScan = scanDate.Value;
            bookRequest.DateOfPrint = printDate.Value;
            ctx.BookRequests.Add(bookRequest);
            ctx.SaveChanges();
            UpdateForm();
        }

        private void UpdateForm()
        {

            GridTest obj = new GridTest();
            obj.Show();
            this.Hide();
            //this.Close();
            //var th = new AddBookRequest();
            //th.Show();
            ////comboBoxStudents.ResetText();
            ////Note.Text = string.Empty;

            //Other updates
        }
    }
}
