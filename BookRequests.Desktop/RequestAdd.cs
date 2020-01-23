using BookRequests.Desktop.Enums;
using BookRequests.Desktop.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BookRequests.Desktop
{
    public partial class RequestAdd : Form
    {
        private int _id = 0;
        public RequestAdd(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void RequestAdd_Load(object sender, EventArgs e)
        {
            using (var ctx = new BookContext())
            {
                if (_id > 0)
                {


                    var request = ctx.BookRequests.Where(r => r.Id == _id).FirstOrDefault();
                    if (request != null)
                        txtNote.Text = request.Note;


                }
                else
                {
                    BookRequest bookRequest = new BookRequest();
                    Student student = new Student();
                    Book book = new Book();
                    book = ctx.Books.FirstOrDefault(b => b.Id == comboBoxBooks.SelectedIndex);
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
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_id > 0)
            {
                using (var ctx = new BookContext())
                {

                    var request = ctx.BookRequests.Where(r => r.Id == _id).FirstOrDefault();
                    if (request != null)
                    {
                        request.Note = txtNote.Text;
                        ctx.SaveChanges();
                        MessageBox.Show("updated Successfully");
                    }


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GridTest request = new GridTest();
            request.Show();
            this.Hide();

        }
    }
}
