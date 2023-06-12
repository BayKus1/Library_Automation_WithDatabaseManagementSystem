namespace Library_Automation_WithDatabaseManagementSystem
{
    partial class AppBodyPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppBodyPage));
            this.logOfButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.borrowerButton = new System.Windows.Forms.Button();
            this.transactionButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.SlidingToggleBtn = new System.Windows.Forms.Button();
            this.SlidePanelTimer = new System.Windows.Forms.Timer(this.components);
            this.contentPanel = new System.Windows.Forms.Panel();
            this.manageCheckLabel = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logOfButton
            // 
            this.logOfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOfButton.Image = ((System.Drawing.Image)(resources.GetObject("logOfButton.Image")));
            this.logOfButton.Location = new System.Drawing.Point(869, 4);
            this.logOfButton.Name = "logOfButton";
            this.logOfButton.Size = new System.Drawing.Size(50, 35);
            this.logOfButton.TabIndex = 2;
            this.logOfButton.UseVisualStyleBackColor = true;
            this.logOfButton.Click += new System.EventHandler(this.logOfButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(925, 4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(50, 35);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(981, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(50, 35);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(40)))));
            this.panel8.Controls.Add(this.manageCheckLabel);
            this.panel8.Controls.Add(this.logOfButton);
            this.panel8.Controls.Add(this.minimizeButton);
            this.panel8.Controls.Add(this.exitBtn);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1035, 44);
            this.panel8.TabIndex = 3;
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseDown);
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.SlidingPanel.Controls.Add(this.aboutButton);
            this.SlidingPanel.Controls.Add(this.bookButton);
            this.SlidingPanel.Controls.Add(this.borrowerButton);
            this.SlidingPanel.Controls.Add(this.transactionButton);
            this.SlidingPanel.Controls.Add(this.settingButton);
            this.SlidingPanel.Controls.Add(this.SlidingToggleBtn);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 44);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(200, 645);
            this.SlidingPanel.TabIndex = 4;
            // 
            // aboutButton
            // 
            this.aboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
            this.aboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.Location = new System.Drawing.Point(-3, 407);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(200, 75);
            this.aboutButton.TabIndex = 10;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.bookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookButton.Image = global::Library_Automation_WithDatabaseManagementSystem.Properties.Resources.books;
            this.bookButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookButton.Location = new System.Drawing.Point(-3, 83);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(200, 75);
            this.bookButton.TabIndex = 9;
            this.bookButton.Text = "Books";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // borrowerButton
            // 
            this.borrowerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.borrowerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrowerButton.Image = ((System.Drawing.Image)(resources.GetObject("borrowerButton.Image")));
            this.borrowerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowerButton.Location = new System.Drawing.Point(-3, 164);
            this.borrowerButton.Name = "borrowerButton";
            this.borrowerButton.Size = new System.Drawing.Size(200, 75);
            this.borrowerButton.TabIndex = 8;
            this.borrowerButton.Text = "Borrowers";
            this.borrowerButton.UseVisualStyleBackColor = true;
            this.borrowerButton.Click += new System.EventHandler(this.borrowerButton_Click);
            // 
            // transactionButton
            // 
            this.transactionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.transactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionButton.Image = ((System.Drawing.Image)(resources.GetObject("transactionButton.Image")));
            this.transactionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionButton.Location = new System.Drawing.Point(-3, 245);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(200, 75);
            this.transactionButton.TabIndex = 7;
            this.transactionButton.Text = "    Transactions";
            this.transactionButton.UseVisualStyleBackColor = true;
            this.transactionButton.Click += new System.EventHandler(this.transactionButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.settingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingButton.Image = ((System.Drawing.Image)(resources.GetObject("settingButton.Image")));
            this.settingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingButton.Location = new System.Drawing.Point(-3, 326);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(200, 75);
            this.settingButton.TabIndex = 6;
            this.settingButton.Text = "     Management";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // SlidingToggleBtn
            // 
            this.SlidingToggleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.SlidingToggleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlidingToggleBtn.Image = global::Library_Automation_WithDatabaseManagementSystem.Properties.Resources.slide;
            this.SlidingToggleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlidingToggleBtn.Location = new System.Drawing.Point(-3, 2);
            this.SlidingToggleBtn.Name = "SlidingToggleBtn";
            this.SlidingToggleBtn.Size = new System.Drawing.Size(200, 75);
            this.SlidingToggleBtn.TabIndex = 5;
            this.SlidingToggleBtn.UseVisualStyleBackColor = true;
            this.SlidingToggleBtn.Click += new System.EventHandler(this.SlidingToggleBtn_Click);
            // 
            // SlidePanelTimer
            // 
            this.SlidePanelTimer.Interval = 10;
            this.SlidePanelTimer.Tick += new System.EventHandler(this.SlidePanelTimer_Tick);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.DimGray;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentPanel.Location = new System.Drawing.Point(198, 44);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(837, 645);
            this.contentPanel.TabIndex = 5;
            // 
            // manageCheckLabel
            // 
            this.manageCheckLabel.AutoSize = true;
            this.manageCheckLabel.Location = new System.Drawing.Point(448, 11);
            this.manageCheckLabel.Name = "manageCheckLabel";
            this.manageCheckLabel.Size = new System.Drawing.Size(0, 20);
            this.manageCheckLabel.TabIndex = 3;
            this.manageCheckLabel.Visible = false;
            // 
            // AppBodyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Automation_WithDatabaseManagementSystem.Properties.Resources.Read_A_Book_Motivational_Quote_Poster;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1035, 689);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.SlidingPanel);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBodyPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppBody";
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button logOfButton;
        private Button minimizeButton;
        private Button exitBtn;
        private Panel panel8;
        private Panel SlidingPanel;
        private Button SlidingToggleBtn;
        private System.Windows.Forms.Timer SlidePanelTimer;
        private Button aboutButton;
        private Button bookButton;
        private Button borrowerButton;
        private Button transactionButton;
        private Button settingButton;
        private Panel contentPanel;
        private Label label2;
        private Label label1;
        private Label manageCheckLabel;
    }
}