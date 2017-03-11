namespace CSharpFinalProject
{
    partial class ReturnForm
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
            this.StudentIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchIssuedBooksButton = new System.Windows.Forms.Button();
            this.ReturnBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ReturnIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReturnBookButton = new System.Windows.Forms.Button();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.DateTimePickerReturn = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBooksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student Id";
            // 
            // StudentIdTextBox
            // 
            this.StudentIdTextBox.Location = new System.Drawing.Point(255, 77);
            this.StudentIdTextBox.Name = "StudentIdTextBox";
            this.StudentIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.StudentIdTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Return Book";
            // 
            // SearchIssuedBooksButton
            // 
            this.SearchIssuedBooksButton.Location = new System.Drawing.Point(150, 127);
            this.SearchIssuedBooksButton.Name = "SearchIssuedBooksButton";
            this.SearchIssuedBooksButton.Size = new System.Drawing.Size(147, 23);
            this.SearchIssuedBooksButton.TabIndex = 3;
            this.SearchIssuedBooksButton.Text = "SearchIssuedBooks";
            this.SearchIssuedBooksButton.UseVisualStyleBackColor = true;
            this.SearchIssuedBooksButton.Click += new System.EventHandler(this.SearchIssuedBooksButton_Click);
            // 
            // ReturnBooksDataGridView
            // 
            this.ReturnBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnBooksDataGridView.Location = new System.Drawing.Point(56, 165);
            this.ReturnBooksDataGridView.Name = "ReturnBooksDataGridView";
            this.ReturnBooksDataGridView.Size = new System.Drawing.Size(343, 131);
            this.ReturnBooksDataGridView.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Book ID to Return";
            // 
            // ReturnIDTextBox
            // 
            this.ReturnIDTextBox.Location = new System.Drawing.Point(255, 349);
            this.ReturnIDTextBox.Name = "ReturnIDTextBox";
            this.ReturnIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ReturnIDTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Return Date";
            // 
            // ReturnBookButton
            // 
            this.ReturnBookButton.Location = new System.Drawing.Point(190, 425);
            this.ReturnBookButton.Name = "ReturnBookButton";
            this.ReturnBookButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnBookButton.TabIndex = 9;
            this.ReturnBookButton.Text = "Return Book";
            this.ReturnBookButton.UseVisualStyleBackColor = true;
            this.ReturnBookButton.Click += new System.EventHandler(this.ReturnBookButton_Click);
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.ContainerControl = this;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Location = new System.Drawing.Point(56, 312);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(343, 34);
            this.ErrorLabel.TabIndex = 10;
            // 
            // DateTimePickerReturn
            // 
            this.DateTimePickerReturn.CustomFormat = "yyyy-MM-dd";
            this.DateTimePickerReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerReturn.Location = new System.Drawing.Point(255, 385);
            this.DateTimePickerReturn.Name = "DateTimePickerReturn";
            this.DateTimePickerReturn.Size = new System.Drawing.Size(100, 20);
            this.DateTimePickerReturn.TabIndex = 11;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(509, 484);
            this.Controls.Add(this.DateTimePickerReturn);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ReturnBookButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReturnIDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReturnBooksDataGridView);
            this.Controls.Add(this.SearchIssuedBooksButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentIdTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ReturnForm";
            this.Text = "ReturnForm";
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBooksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StudentIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchIssuedBooksButton;
        private System.Windows.Forms.DataGridView ReturnBooksDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReturnIDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReturnBookButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider1;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.DateTimePicker DateTimePickerReturn;
    }
}