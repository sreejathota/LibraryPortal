namespace CSharpFinalProject
{
    partial class ViewIssuedBooks
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
            this.ViewIssuedBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewIssuedBooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewIssuedBooksDataGridView
            // 
            this.ViewIssuedBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewIssuedBooksDataGridView.Location = new System.Drawing.Point(55, 12);
            this.ViewIssuedBooksDataGridView.Name = "ViewIssuedBooksDataGridView";
            this.ViewIssuedBooksDataGridView.Size = new System.Drawing.Size(336, 306);
            this.ViewIssuedBooksDataGridView.TabIndex = 0;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(55, 325);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(35, 13);
            this.ErrorLabel.TabIndex = 1;
            this.ErrorLabel.Text = "label1";
            // 
            // ViewIssuedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 367);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ViewIssuedBooksDataGridView);
            this.Name = "ViewIssuedBooks";
            this.Text = "ViewIssuedBooks";
            this.Load += new System.EventHandler(this.ViewIssuedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewIssuedBooksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewIssuedBooksDataGridView;
        private System.Windows.Forms.Label ErrorLabel;
    }
}