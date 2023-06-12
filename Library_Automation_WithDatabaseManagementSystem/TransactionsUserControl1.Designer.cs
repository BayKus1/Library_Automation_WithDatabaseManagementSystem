namespace Library_Automation_WithDatabaseManagementSystem
{
    partial class TransactionsUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsUserControl1));
            this.ClearButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.IssueButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BookNoTextBox = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.BorrowerNoTextBox = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TransactionTextBox = new System.Windows.Forms.TextBox();
            this.br_id = new System.Windows.Forms.Label();
            this.issueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.returnDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.extendDatePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
            this.ClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearButton.Location = new System.Drawing.Point(629, 527);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(172, 53);
            this.ClearButton.TabIndex = 68;
            this.ClearButton.Text = "  Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ReturnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReturnButton.ForeColor = System.Drawing.Color.Black;
            this.ReturnButton.Image = global::Library_Automation_WithDatabaseManagementSystem.Properties.Resources.book1;
            this.ReturnButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReturnButton.Location = new System.Drawing.Point(348, 527);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(172, 53);
            this.ReturnButton.TabIndex = 67;
            this.ReturnButton.Text = "       Return Book";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // IssueButton
            // 
            this.IssueButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IssueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.IssueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IssueButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IssueButton.Image = ((System.Drawing.Image)(resources.GetObject("IssueButton.Image")));
            this.IssueButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IssueButton.Location = new System.Drawing.Point(52, 527);
            this.IssueButton.Name = "IssueButton";
            this.IssueButton.Size = new System.Drawing.Size(172, 53);
            this.IssueButton.TabIndex = 66;
            this.IssueButton.Text = "     Issue Book";
            this.IssueButton.UseVisualStyleBackColor = true;
            this.IssueButton.Click += new System.EventHandler(this.IssueButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(785, 200);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(185, 388);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 2);
            this.panel4.TabIndex = 88;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(186, 332);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(183, 2);
            this.panel7.TabIndex = 81;
            // 
            // BookNoTextBox
            // 
            this.BookNoTextBox.BackColor = System.Drawing.Color.DimGray;
            this.BookNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookNoTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookNoTextBox.Location = new System.Drawing.Point(185, 366);
            this.BookNoTextBox.Name = "BookNoTextBox";
            this.BookNoTextBox.Size = new System.Drawing.Size(184, 23);
            this.BookNoTextBox.TabIndex = 87;
            this.BookNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Phone.Location = new System.Drawing.Point(71, 364);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(101, 25);
            this.Phone.TabIndex = 86;
            this.Phone.Text = "Book No :";
            // 
            // BorrowerNoTextBox
            // 
            this.BorrowerNoTextBox.BackColor = System.Drawing.Color.DimGray;
            this.BorrowerNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BorrowerNoTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BorrowerNoTextBox.Location = new System.Drawing.Point(185, 309);
            this.BorrowerNoTextBox.Name = "BorrowerNoTextBox";
            this.BorrowerNoTextBox.Size = new System.Drawing.Size(184, 23);
            this.BorrowerNoTextBox.TabIndex = 85;
            this.BorrowerNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name.Location = new System.Drawing.Point(33, 307);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(139, 25);
            this.Name.TabIndex = 84;
            this.Name.Text = "Borrower No :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(185, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 2);
            this.panel2.TabIndex = 80;
            // 
            // TransactionTextBox
            // 
            this.TransactionTextBox.BackColor = System.Drawing.Color.DimGray;
            this.TransactionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransactionTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransactionTextBox.Location = new System.Drawing.Point(185, 256);
            this.TransactionTextBox.Name = "TransactionTextBox";
            this.TransactionTextBox.Size = new System.Drawing.Size(184, 23);
            this.TransactionTextBox.TabIndex = 83;
            this.TransactionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // br_id
            // 
            this.br_id.AutoSize = true;
            this.br_id.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.br_id.Location = new System.Drawing.Point(15, 256);
            this.br_id.Name = "br_id";
            this.br_id.Size = new System.Drawing.Size(157, 25);
            this.br_id.TabIndex = 82;
            this.br_id.Text = "Transaction No :";
            // 
            // issueDatePicker
            // 
            this.issueDatePicker.Location = new System.Drawing.Point(584, 252);
            this.issueDatePicker.Name = "issueDatePicker";
            this.issueDatePicker.Size = new System.Drawing.Size(250, 27);
            this.issueDatePicker.TabIndex = 92;
            // 
            // returnDatePicker
            // 
            this.returnDatePicker.Location = new System.Drawing.Point(584, 306);
            this.returnDatePicker.Name = "returnDatePicker";
            this.returnDatePicker.Size = new System.Drawing.Size(250, 27);
            this.returnDatePicker.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(497, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 94;
            this.label2.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(431, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 95;
            this.label3.Text = "Return Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(431, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 96;
            this.label4.Text = "Date Extend :";
            // 
            // extendDatePicker
            // 
            this.extendDatePicker.Location = new System.Drawing.Point(584, 400);
            this.extendDatePicker.Name = "extendDatePicker";
            this.extendDatePicker.Size = new System.Drawing.Size(250, 27);
            this.extendDatePicker.TabIndex = 97;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Library_Automation_WithDatabaseManagementSystem.Properties.Resources.extended;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(629, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 53);
            this.button1.TabIndex = 98;
            this.button1.Text = "       Date Extend";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TransactionsUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.extendDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.returnDatePicker);
            this.Controls.Add(this.issueDatePicker);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.BookNoTextBox);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.BorrowerNoTextBox);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TransactionTextBox);
            this.Controls.Add(this.br_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.IssueButton);
            this.Size = new System.Drawing.Size(837, 645);
            this.Load += new System.EventHandler(this.TransactionsUserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button ClearButton;
        private Button ReturnButton;
        private Button IssueButton;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Panel panel7;
        private TextBox BookNoTextBox;
        private Label Phone;
        private TextBox BorrowerNoTextBox;
        private Label Name;
        private Panel panel2;
        private TextBox TransactionTextBox;
        private Label br_id;
        private DateTimePicker issueDatePicker;
        private DateTimePicker returnDatePicker;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker extendDatePicker;
        private Button button1;
    }
}
