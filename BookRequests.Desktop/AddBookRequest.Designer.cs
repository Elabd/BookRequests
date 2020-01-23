namespace BookRequests.Desktop
{
    partial class AddBookRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.TextBox();
            this.requestdate = new System.Windows.Forms.DateTimePicker();
            this.scanDate = new System.Windows.Forms.DateTimePicker();
            this.printDate = new System.Windows.Forms.DateTimePicker();
            this.stimateDate = new System.Windows.Forms.DateTimePicker();
            this.arrivedDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStudents = new System.Windows.Forms.ComboBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookDBDataSet2 = new BookRequests.Desktop.BookDBDataSet2();
            this.bookDBDataSet = new BookRequests.Desktop.BookDBDataSet();
            this.comboBoxBooks = new System.Windows.Forms.ComboBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxrequestTypes = new System.Windows.Forms.ComboBox();
            this.comboBoxPriorties = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.booksTableAdapter = new BookRequests.Desktop.BookDBDataSetTableAdapters.BooksTableAdapter();
            this.studentsTableAdapter = new BookRequests.Desktop.BookDBDataSet2TableAdapters.StudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Book ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Request Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date Of Scan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date Of Print";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Stimate Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Arrived Date";
            // 
            // Note
            // 
            this.Note.Location = new System.Drawing.Point(434, 12);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(260, 20);
            this.Note.TabIndex = 0;
            // 
            // requestdate
            // 
            this.requestdate.Location = new System.Drawing.Point(434, 101);
            this.requestdate.Name = "requestdate";
            this.requestdate.Size = new System.Drawing.Size(200, 20);
            this.requestdate.TabIndex = 11;
            // 
            // scanDate
            // 
            this.scanDate.Location = new System.Drawing.Point(434, 147);
            this.scanDate.Name = "scanDate";
            this.scanDate.Size = new System.Drawing.Size(200, 20);
            this.scanDate.TabIndex = 12;
            // 
            // printDate
            // 
            this.printDate.Location = new System.Drawing.Point(434, 191);
            this.printDate.Name = "printDate";
            this.printDate.Size = new System.Drawing.Size(200, 20);
            this.printDate.TabIndex = 13;
            // 
            // stimateDate
            // 
            this.stimateDate.Location = new System.Drawing.Point(434, 217);
            this.stimateDate.Name = "stimateDate";
            this.stimateDate.Size = new System.Drawing.Size(200, 20);
            this.stimateDate.TabIndex = 14;
            // 
            // arrivedDate
            // 
            this.arrivedDate.Location = new System.Drawing.Point(434, 257);
            this.arrivedDate.Name = "arrivedDate";
            this.arrivedDate.Size = new System.Drawing.Size(200, 20);
            this.arrivedDate.TabIndex = 15;
            // 
            // comboBoxStudents
            // 
            this.comboBoxStudents.DataSource = this.studentsBindingSource;
            this.comboBoxStudents.DisplayMember = "StudentName";
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Location = new System.Drawing.Point(434, 38);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStudents.TabIndex = 16;
            this.comboBoxStudents.ValueMember = "Id";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.bookDBDataSet2;
            // 
            // bookDBDataSet2
            // 
            this.bookDBDataSet2.DataSetName = "BookDBDataSet2";
            this.bookDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookDBDataSet
            // 
            this.bookDBDataSet.DataSetName = "BookDBDataSet";
            this.bookDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxBooks
            // 
            this.comboBoxBooks.DataSource = this.booksBindingSource;
            this.comboBoxBooks.DisplayMember = "BookName";
            this.comboBoxBooks.FormattingEnabled = true;
            this.comboBoxBooks.Location = new System.Drawing.Point(434, 65);
            this.comboBoxBooks.Name = "comboBoxBooks";
            this.comboBoxBooks.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBooks.TabIndex = 17;
            this.comboBoxBooks.ValueMember = "Id";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.bookDBDataSetBindingSource;
            // 
            // bookDBDataSetBindingSource
            // 
            this.bookDBDataSetBindingSource.DataSource = this.bookDBDataSet;
            this.bookDBDataSetBindingSource.Position = 0;
            // 
            // comboBoxrequestTypes
            // 
            this.comboBoxrequestTypes.FormattingEnabled = true;
            this.comboBoxrequestTypes.Location = new System.Drawing.Point(434, 283);
            this.comboBoxrequestTypes.Name = "comboBoxrequestTypes";
            this.comboBoxrequestTypes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxrequestTypes.TabIndex = 18;
            // 
            // comboBoxPriorties
            // 
            this.comboBoxPriorties.FormattingEnabled = true;
            this.comboBoxPriorties.Location = new System.Drawing.Point(434, 310);
            this.comboBoxPriorties.Name = "comboBoxPriorties";
            this.comboBoxPriorties.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPriorties.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Request Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Priority";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(434, 343);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(362, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Status";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // AddBookRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxPriorties);
            this.Controls.Add(this.comboBoxrequestTypes);
            this.Controls.Add(this.comboBoxBooks);
            this.Controls.Add(this.comboBoxStudents);
            this.Controls.Add(this.arrivedDate);
            this.Controls.Add(this.stimateDate);
            this.Controls.Add(this.printDate);
            this.Controls.Add(this.scanDate);
            this.Controls.Add(this.requestdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Note);
            this.Name = "AddBookRequest";
            this.Text = "AddBookRequest";
            this.Load += new System.EventHandler(this.AddBookRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Note;
        private System.Windows.Forms.DateTimePicker requestdate;
        private System.Windows.Forms.DateTimePicker scanDate;
        private System.Windows.Forms.DateTimePicker printDate;
        private System.Windows.Forms.DateTimePicker stimateDate;
        private System.Windows.Forms.DateTimePicker arrivedDate;
        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.ComboBox comboBoxBooks;
        private System.Windows.Forms.ComboBox comboBoxrequestTypes;
        private System.Windows.Forms.ComboBox comboBoxPriorties;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bookDBDataSetBindingSource;
        private BookDBDataSet bookDBDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private BookDBDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private BookDBDataSet2 bookDBDataSet2;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private BookDBDataSet2TableAdapters.StudentsTableAdapter studentsTableAdapter;
    }
}