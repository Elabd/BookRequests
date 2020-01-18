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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentName = textBox1.Text;
            student.PhoneNumber = textBox2.Text;
            BookContext ctx = new BookContext();
            ctx.Students.Add(student);
            ctx.SaveChanges(); 
        }
    }
}
