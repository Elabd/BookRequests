using BookRequests.Desktop.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Reflection;

namespace BookRequests.Desktop
{
    public partial class GridTest : Form
    {
        public GridTest()
        {
            InitializeComponent();
        }

        private void GridTest_Load(object sender, EventArgs e)
        {
            FillGrid();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Update")
            {

                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                RequestAdd requestAdd = new RequestAdd(id);
                requestAdd.Show();
                this.Hide();
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                var confirmResult = MessageBox.Show("Are You Sure You Want to Delete This Request", "Delete Confirm", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    using (var ctx = new BookContext())
                    {
                        var btnId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                        var request = ctx.BookRequests.Where(x => x.Id == btnId).FirstOrDefault();
                        if (request != null)
                        {
                            ctx.BookRequests.Remove(request);
                            ctx.SaveChanges();
                            dataGridView1.DataSource = null;
                            FillGrid();
                            MessageBox.Show("Deleted Successfully", "Deleted");
                        }
                        else
                        {
                            MessageBox.Show("Not Found");
                        }


                    }
                }
            }
        }
        private void FillGrid()
        {
            using (var ctx = new BookContext())
            {
                var requests = (from r in ctx.BookRequests.Include(b => b.Book).Include(s => s.Student).AsNoTracking()
                                select new DtoRequest
                                {
                                    Id = r.Id,
                                    Book = r.Book.BookName,
                                    Student = r.Student.StudentName,
                                    Note = r.Note
                                }).OrderByDescending(x => x.Id).ToList();
                //dataGridView1.DataSource = null;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.AutoSize = true;
                dataGridView1.DataSource = requests;
                
                var model = new DtoRequest();
                foreach (PropertyInfo item in model.GetType().GetProperties())
                {
                    DataGridViewColumn column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = item.Name;
                    column.Name = item.Name;
                    if(dataGridView1.Columns[item.Name]== null)
                    {
                        dataGridView1.Columns.Add(column);
                    }
                       
                }
                DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
                btnUpdate.Name = "Update";
                btnUpdate.Text = "Update";
                btnUpdate.UseColumnTextForButtonValue = true;

                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Delete";
                btnDelete.Text = "Delete";
                btnDelete.UseColumnTextForButtonValue = true;
                if (dataGridView1.Columns["Update"] == null)
                {
                    dataGridView1.Columns.Insert(model.GetType().GetProperties().Length, btnUpdate);
                }
                if (dataGridView1.Columns["Delete"] == null)
                {
                    dataGridView1.Columns.Insert(model.GetType().GetProperties().Length+1, btnDelete);
                }

                this.Controls.Add(dataGridView1);
                this.Text = "data grid view";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
