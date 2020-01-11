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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var ctx = new BookContext())
            {
                var stud = new Student() { StudentName = "Bill" , PhoneNumber="01093133933" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
