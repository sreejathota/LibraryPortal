namespace CSharpFinalProject
{
    partial class IssueBookForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IssueBookButton = new System.Windows.Forms.Button();
            this.FindBookButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BooksDataGridView = new System.Windows.Forms.DataGridView();
            this.BookIDTextBox = new System.Windows.Forms.TextBox();
            this.StudentIDTextBox = new System.Windows.Forms.TextBox();
            this.SearchBookIDTextBox = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issue Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Book ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Student ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Issue Date";
            // 
            // IssueBookButton
            // 
            this.IssueBookButton.Location = new System.Drawing.Point(165, 166);
            this.IssueBookButton.Name = "IssueBookButton";
            this.IssueBookButton.Size = new System.Drawing.Size(75, 23);
            this.IssueBookButton.TabIndex = 4;
            this.IssueBookButton.Text = "Issue Book";
            this.IssueBookButton.UseVisualStyleBackColor = true;
            this.IssueBookButton.Click += new System.EventHandler(this.IssueBookButton_Click);
            // 
            // FindBookButton
            // 
            this.FindBookButton.Location = new System.Drawing.Point(340, 284);
            this.FindBookButton.Name = "FindBookButton";
            this.FindBookButton.Size = new System.Drawing.Size(75, 23);
            this.FindBookButton.TabIndex = 5;
            this.FindBookButton.Text = "Find Book ID";
            this.FindBookButton.UseVisualStyleBackColor = true;
            this.FindBookButton.Click += new System.EventHandler(this.FindBookButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Enter Book Title to get ID";
            // 
            // BooksDataGridView
            // 
            this.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDataGridView.Location = new System.Drawing.Point(76, 327);
            this.BooksDataGridView.Name = "BooksDataGridView";
            this.BooksDataGridView.Size = new System.Drawing.Size(380, 150);
            this.BooksDataGridView.TabIndex = 7;
            // 
            // BookIDTextBox
            // 
            this.BookIDTextBox.Location = new System.Drawing.Point(192, 71);
            this.BookIDTextBox.Name = "BookIDTextBox";
            this.BookIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.BookIDTextBox.TabIndex = 8;
            // 
            // StudentIDTextBox
            // 
            this.StudentIDTextBox.Location = new System.Drawing.Point(192, 99);
            this.StudentIDTextBox.Name = "StudentIDTextBox";
            this.StudentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.StudentIDTextBox.TabIndex = 9;
            // 
            // SearchBookIDTextBox
            // 
            this.SearchBookIDTextBox.Location = new System.Drawing.Point(192, 287);
            this.SearchBookIDTextBox.Name = "SearchBookIDTextBox";
            this.SearchBookIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchBookIDTextBox.TabIndex = 11;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker1.Location = new System.Drawing.Point(192, 128);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.DateTimePicker1.TabIndex = 12;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Location = new System.Drawing.Point(44, 210);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(380, 71);
            this.ErrorLabel.TabIndex = 13;
            // 
            // IssueBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 489);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.SearchBookIDTextBox);
            this.Controls.Add(this.StudentIDTextBox);
            this.Controls.Add(this.BookIDTextBox);
            this.Controls.Add(this.BooksDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FindBookButton);
            this.Controls.Add(this.IssueBookButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IssueBookForm";
            this.Text = "IssueBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button IssueBookButton;
        private System.Windows.Forms.Button FindBookButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView BooksDataGridView;
        private System.Windows.Forms.TextBox BookIDTextBox;
        private System.Windows.Forms.TextBox StudentIDTextBox;
        private System.Windows.Forms.TextBox SearchBookIDTextBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Label ErrorLabel;
    }
}