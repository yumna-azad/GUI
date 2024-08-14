namespace gui
{
    partial class Form3
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXTReturnBorrowerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TXTbookId = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTBorrowerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.borrowedBooksTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTReturnBookID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBooksTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.TXTReturnBookID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TXTReturnBorrowerID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TXTbookId);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Return);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TXTBorrowerID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 346);
            this.panel1.TabIndex = 2;
            // 
            // TXTReturnBorrowerID
            // 
            this.TXTReturnBorrowerID.Location = new System.Drawing.Point(91, 189);
            this.TXTReturnBorrowerID.Margin = new System.Windows.Forms.Padding(2);
            this.TXTReturnBorrowerID.Name = "TXTReturnBorrowerID";
            this.TXTReturnBorrowerID.Size = new System.Drawing.Size(92, 20);
            this.TXTReturnBorrowerID.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Member ID:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(17, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 19);
            this.button1.TabIndex = 14;
            this.button1.Text = "Borrow Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXTbookId
            // 
            this.TXTbookId.Location = new System.Drawing.Point(91, 72);
            this.TXTbookId.Margin = new System.Windows.Forms.Padding(2);
            this.TXTbookId.Name = "TXTbookId";
            this.TXTbookId.Size = new System.Drawing.Size(92, 20);
            this.TXTbookId.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(97, 137);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 19);
            this.button2.TabIndex = 0;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Return
            // 
            this.Return.ForeColor = System.Drawing.Color.Teal;
            this.Return.Location = new System.Drawing.Point(24, 268);
            this.Return.Margin = new System.Windows.Forms.Padding(2);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(73, 19);
            this.Return.TabIndex = 8;
            this.Return.Text = "Return Book";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Book ID:";
            // 
            // TXTBorrowerID
            // 
            this.TXTBorrowerID.Location = new System.Drawing.Point(82, 32);
            this.TXTBorrowerID.Margin = new System.Windows.Forms.Padding(2);
            this.TXTBorrowerID.Name = "TXTBorrowerID";
            this.TXTBorrowerID.Size = new System.Drawing.Size(92, 20);
            this.TXTBorrowerID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Member ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.borrowedBooksTable);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(204, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 346);
            this.panel2.TabIndex = 3;
            // 
            // borrowedBooksTable
            // 
            this.borrowedBooksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowedBooksTable.Location = new System.Drawing.Point(22, 42);
            this.borrowedBooksTable.Margin = new System.Windows.Forms.Padding(2);
            this.borrowedBooksTable.Name = "borrowedBooksTable";
            this.borrowedBooksTable.RowHeadersWidth = 51;
            this.borrowedBooksTable.RowTemplate.Height = 24;
            this.borrowedBooksTable.Size = new System.Drawing.Size(518, 245);
            this.borrowedBooksTable.TabIndex = 1;
            this.borrowedBooksTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.borrowedBooksTable_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Issued Books";
            // 
            // TXTReturnBookID
            // 
            this.TXTReturnBookID.Location = new System.Drawing.Point(91, 223);
            this.TXTReturnBookID.Margin = new System.Windows.Forms.Padding(2);
            this.TXTReturnBookID.Name = "TXTReturnBookID";
            this.TXTReturnBookID.Size = new System.Drawing.Size(92, 20);
            this.TXTReturnBookID.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Book ID:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBooksTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TXTbookId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXTBorrowerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTReturnBorrowerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView borrowedBooksTable;
        private System.Windows.Forms.TextBox TXTReturnBookID;
        private System.Windows.Forms.Label label4;
    }
}