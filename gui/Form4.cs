using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui
{
    public partial class Form4 : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source = HPI5\SQLEXPRESS; Initial Catalog = library; Integrated Security = True");
        private Panel panel2;
        private DataGridView bookstable;
        private Label label2;
        private Panel panel1;
        private TextBox TXTID;
        private Label label6;
        private TextBox TXTISBN;
        private Label label4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox TXTAUTHOR;
        private TextBox TXTTITLE;
        private Label label3;
        private Label label1;
        private TextBox RemoveID;
        private Label label5;
        private FlowLayoutPanel addbookimage;

        public Form4()
        {
            InitializeComponent();
            LoadData();
        }

        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.bookstable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TXTAUTHOR = new System.Windows.Forms.TextBox();
            this.TXTTITLE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addbookimage = new System.Windows.Forms.FlowLayoutPanel();
            this.RemoveID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookstable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.bookstable);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(546, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 400);
            this.panel2.TabIndex = 4;
            // 
            // bookstable
            // 
            this.bookstable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookstable.Location = new System.Drawing.Point(18, 55);
            this.bookstable.Name = "bookstable";
            this.bookstable.RowHeadersWidth = 51;
            this.bookstable.RowTemplate.Height = 24;
            this.bookstable.Size = new System.Drawing.Size(603, 325);
            this.bookstable.TabIndex = 1;
            this.bookstable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookstable_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "All Issued Books";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RemoveID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TXTID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TXTISBN);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TXTAUTHOR);
            this.panel1.Controls.Add(this.TXTTITLE);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addbookimage);
            this.panel1.Location = new System.Drawing.Point(207, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 624);
            this.panel1.TabIndex = 3;
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(112, 269);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(122, 22);
            this.TXTID.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Book ID:";
            // 
            // TXTISBN
            // 
            this.TXTISBN.Location = new System.Drawing.Point(112, 402);
            this.TXTISBN.Name = "TXTISBN";
            this.TXTISBN.Size = new System.Drawing.Size(122, 22);
            this.TXTISBN.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "ISBN:";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Teal;
            this.button3.Location = new System.Drawing.Point(164, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(26, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Remove Book";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(26, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXTAUTHOR
            // 
            this.TXTAUTHOR.Location = new System.Drawing.Point(102, 358);
            this.TXTAUTHOR.Name = "TXTAUTHOR";
            this.TXTAUTHOR.Size = new System.Drawing.Size(122, 22);
            this.TXTAUTHOR.TabIndex = 8;
            // 
            // TXTTITLE
            // 
            this.TXTTITLE.Location = new System.Drawing.Point(112, 306);
            this.TXTTITLE.Name = "TXTTITLE";
            this.TXTTITLE.Size = new System.Drawing.Size(122, 22);
            this.TXTTITLE.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book Tittle:";
            // 
            // addbookimage
            // 
            this.addbookimage.BackColor = System.Drawing.Color.Gray;
            this.addbookimage.Location = new System.Drawing.Point(39, 44);
            this.addbookimage.Name = "addbookimage";
            this.addbookimage.Size = new System.Drawing.Size(193, 194);
            this.addbookimage.TabIndex = 2;
            this.addbookimage.Paint += new System.Windows.Forms.PaintEventHandler(this.addbookimage_Paint);
            // 
            // RemoveID
            // 
            this.RemoveID.Location = new System.Drawing.Point(112, 526);
            this.RemoveID.Name = "RemoveID";
            this.RemoveID.Size = new System.Drawing.Size(122, 22);
            this.RemoveID.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Book ID:";
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(1401, 667);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookstable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = TXTID.Text;
            string title = TXTTITLE.Text;
            string author = TXTAUTHOR.Text;
            string isbn = TXTISBN.Text;

            SqlConnection connect = new SqlConnection("     ");
            connect.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO LMS (ID, Title, Author, ISBN) VALUES (@ID, @Title, @Author, @ISBN)", connect);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Author", author);
            cmd.Parameters.AddWithValue("@ISBN", isbn);

            // Execute the SQL command
            cmd.ExecuteNonQuery();

            // Optionally, display a success message
            MessageBox.Show("Book added successfully.");

            LoadData(); // Refresh the DataGridView

            connect.Close();
        }

        private void LoadData()
        {
            SqlConnection connect = new SqlConnection("Data Source=HPI5\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");
            // Fetch book details from the database
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT ID, Title, Author, ISBN FROM LMS", connect);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Assuming you have a DataGridView named 'bookstable'
            bookstable.DataSource = dataTable;
        }

        private void bookstable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addbookimage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("Data Source=HPI5\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");
            connect.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM LMS WHERE ID = @ID", connect);
            cmd.Parameters.AddWithValue("@ID", RemoveID.Text);
            cmd.ExecuteNonQuery();
            // Optionally, display a success message
            MessageBox.Show("Book removed successfully.");

            // Refresh the DataGridView
            LoadData();
            connect.Close ();

        }
    }
}
