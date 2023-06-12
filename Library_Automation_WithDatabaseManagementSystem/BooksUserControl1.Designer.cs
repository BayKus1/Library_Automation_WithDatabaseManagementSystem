namespace Library_Automation_WithDatabaseManagementSystem
{
    partial class BooksUserControl1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksUserControl1));
            this.BookID = new System.Windows.Forms.Label();
            this.BookIDTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AccNo = new System.Windows.Forms.Label();
            this.AccNoTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.PublisherTextBox = new System.Windows.Forms.TextBox();
            this.Publisher = new System.Windows.Forms.Label();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.sQLConnectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentIDComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLConnectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BookID
            // 
            this.BookID.AutoSize = true;
            this.BookID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BookID.Location = new System.Drawing.Point(21, 16);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(187, 25);
            this.BookID.TabIndex = 0;
            this.BookID.Text = "Accession Number :";
            // 
            // BookIDTextBox
            // 
            this.BookIDTextBox.BackColor = System.Drawing.Color.DimGray;
            this.BookIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookIDTextBox.Location = new System.Drawing.Point(214, 20);
            this.BookIDTextBox.Name = "BookIDTextBox";
            this.BookIDTextBox.Size = new System.Drawing.Size(454, 20);
            this.BookIDTextBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(214, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 2);
            this.panel2.TabIndex = 7;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(40)))));
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.Color.Transparent;
            this.SearchButton.Image = global::Library_Automation_WithDatabaseManagementSystem.Properties.Resources.search;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(269, 87);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(327, 55);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(785, 188);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddButton
            // 
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Image = global::Library_Automation_WithDatabaseManagementSystem.Properties.Resources.plus;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(30, 390);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(172, 53);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "     Add New";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.Image = global::Library_Automation_WithDatabaseManagementSystem.Properties.Resources.refresh;
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.Location = new System.Drawing.Point(228, 390);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(172, 53);
            this.UpdateButton.TabIndex = 11;
            this.UpdateButton.Text = "     Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteButton.Image = global::Library_Automation_WithDatabaseManagementSystem.Properties.Resources.trash_bin;
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(434, 390);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(172, 53);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "   Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
            this.ClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearButton.Location = new System.Drawing.Point(643, 390);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(172, 53);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "  Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AccNo
            // 
            this.AccNo.AutoSize = true;
            this.AccNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccNo.Location = new System.Drawing.Point(41, 459);
            this.AccNo.Name = "AccNo";
            this.AccNo.Size = new System.Drawing.Size(80, 25);
            this.AccNo.TabIndex = 14;
            this.AccNo.Text = "Acc No:";
            // 
            // AccNoTextBox
            // 
            this.AccNoTextBox.BackColor = System.Drawing.Color.DimGray;
            this.AccNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccNoTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccNoTextBox.Location = new System.Drawing.Point(140, 461);
            this.AccNoTextBox.Name = "AccNoTextBox";
            this.AccNoTextBox.Size = new System.Drawing.Size(184, 23);
            this.AccNoTextBox.TabIndex = 15;
            this.AccNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(140, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 2);
            this.panel1.TabIndex = 8;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.DimGray;
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.Location = new System.Drawing.Point(136, 511);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(184, 23);
            this.NameTextBox.TabIndex = 17;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name.Location = new System.Drawing.Point(41, 512);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(74, 25);
            this.Name.TabIndex = 16;
            this.Name.Text = "Name :";
            // 
            // PublisherTextBox
            // 
            this.PublisherTextBox.BackColor = System.Drawing.Color.DimGray;
            this.PublisherTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PublisherTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PublisherTextBox.Location = new System.Drawing.Point(136, 575);
            this.PublisherTextBox.Name = "PublisherTextBox";
            this.PublisherTextBox.Size = new System.Drawing.Size(184, 23);
            this.PublisherTextBox.TabIndex = 19;
            this.PublisherTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Publisher
            // 
            this.Publisher.AutoSize = true;
            this.Publisher.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Publisher.Location = new System.Drawing.Point(10, 575);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(105, 25);
            this.Publisher.TabIndex = 18;
            this.Publisher.Text = "Publisher :";
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.BackColor = System.Drawing.Color.DimGray;
            this.ISBNTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ISBNTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ISBNTextBox.Location = new System.Drawing.Point(622, 512);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(184, 23);
            this.ISBNTextBox.TabIndex = 21;
            this.ISBNTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ISBN.Location = new System.Drawing.Point(530, 512);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(66, 25);
            this.ISBN.TabIndex = 20;
            this.ISBN.Text = "ISBN :";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.BackColor = System.Drawing.Color.DimGray;
            this.AuthorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthorTextBox.Location = new System.Drawing.Point(622, 575);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(184, 23);
            this.AuthorTextBox.TabIndex = 23;
            this.AuthorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Author.Location = new System.Drawing.Point(511, 575);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(85, 25);
            this.Author.TabIndex = 22;
            this.Author.Text = "Author :";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(134, 534);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(190, 2);
            this.panel7.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(134, 597);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 2);
            this.panel3.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(620, 534);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 2);
            this.panel4.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(620, 597);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(190, 2);
            this.panel5.TabIndex = 26;
            // 
            // sQLConnectBindingSource
            // 
            this.sQLConnectBindingSource.DataSource = typeof(Library_Automation_WithDatabaseManagementSystem.sql.SQLConnect);
            // 
            // departmentIDComboBox
            // 
            this.departmentIDComboBox.BackColor = System.Drawing.Color.DimGray;
            this.departmentIDComboBox.FormattingEnabled = true;
            this.departmentIDComboBox.Items.AddRange(new object[] {
            "Computer",
            "Network",
            "Human Resources"});
            this.departmentIDComboBox.Location = new System.Drawing.Point(622, 459);
            this.departmentIDComboBox.Name = "departmentIDComboBox";
            this.departmentIDComboBox.Size = new System.Drawing.Size(184, 28);
            this.departmentIDComboBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(466, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Department :";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::Library_Automation_WithDatabaseManagementSystem.Properties.Resources.refresh;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(762, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 53);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BooksUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departmentIDComboBox);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.PublisherTextBox);
            this.Controls.Add(this.Publisher);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AccNoTextBox);
            this.Controls.Add(this.AccNo);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BookIDTextBox);
            this.Controls.Add(this.BookID);
            this.Size = new System.Drawing.Size(837, 645);
            this.Load += new System.EventHandler(this.BooksUserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLConnectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label BookID;
        private TextBox BookIDTextBox;
        private Panel panel2;
        private Button SearchButton;
        private DataGridView dataGridView1;
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button ClearButton;
        private Label AccNo;
        private TextBox AccNoTextBox;
        private Panel panel1;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private Panel panel4;
        private Label label5;
        private Panel panel5;
        private Label label6;
        private Panel panel6;
        private TextBox NameTextBox;
        private Label Name;
        private TextBox PublisherTextBox;
        private Label Publisher;
        private TextBox ISBNTextBox;
        private Label ISBN;
        private TextBox AuthorTextBox;
        private Label Author;
        private Panel panel7;
        private Label Department;
        private BindingSource sQLConnectBindingSource;
        private ComboBox departmentIDComboBox;
        private Label label1;
        private Button button1;
    }
}
