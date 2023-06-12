using Library_Automation_WithDatabaseManagementSystem.sql;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_Automation_WithDatabaseManagementSystem
{
    public partial class AppBodyPage : Form
    {
        public AppBodyPage()
        {
            InitializeComponent();
            isSlidingPanelExpanded = true;
            expandSlidingPanelGUI();
        }

        // TITLE BAR

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // TITLE BAR


        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logOfButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGINPAGE login = new LOGINPAGE();
            login.Show();
        }

        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        bool isSlidingPanelExpanded;
        const int maxSlideWidth=200;
        const int minSlideWidth=50;

        public void expandSlidingPanelGUI()
        {
            bookButton.Text = "Books";
            borrowerButton.Text = "Borrowers";
            transactionButton.Text = "Transaciton";
            settingButton.Text = "Management";
            aboutButton.Text = "About";

            SlidingToggleBtn.Image = Properties.Resources.slide;

            bookButton.Image = null;
            borrowerButton.Image = null;
            transactionButton.Image = null;
            settingButton.Image = null;
            aboutButton.Image = null;
        }
        
        public void retractSlidingPanelGUI() 
        {
            bookButton.Text = "";
            borrowerButton.Text = "";
            transactionButton.Text = "";
            settingButton.Text = "";
            aboutButton.Text = "";

            SlidingToggleBtn.Image = Properties.Resources.slide;

            bookButton.Image = Properties.Resources.books;
            borrowerButton.Image = Properties.Resources.borrows;
            transactionButton.Image = Properties.Resources.transactions;
            settingButton.Image = Properties.Resources.settings;
            aboutButton.Image = Properties.Resources.about;
        }
        private void SlidingToggleBtn_Click(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                retractSlidingPanelGUI();
            }
            SlidePanelTimer.Start();
        }

        private void SlidePanelTimer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                SlidingPanel.Width -= 40;
                if (SlidingPanel.Width <= minSlideWidth)
                {
                    isSlidingPanelExpanded = false;
                    SlidePanelTimer.Stop();

                    this.Refresh();
                }
            }
            else
            {
                SlidingPanel.Width += 40;
                if (SlidingPanel.Width >= maxSlideWidth)
                {
                    isSlidingPanelExpanded = true;
                    SlidePanelTimer.Stop();
                    expandSlidingPanelGUI();
                    this.Refresh();
                }
            }
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            
            if (! contentPanel.Controls.Contains(BooksUserControl1.Instance))
            {
                contentPanel.Controls.Add(BooksUserControl1.Instance);
                BooksUserControl1.Instance.Dock = DockStyle.Fill;
                BooksUserControl1.Instance.BringToFront();
                
            }
            else
            {
                BooksUserControl1.Instance.BringToFront();
            }
        }

        private void borrowerButton_Click(object sender, EventArgs e)
        {
            if (! contentPanel.Controls.Contains(BorrowersUserControl1.Instance))
            {
                contentPanel.Controls.Add(BorrowersUserControl1.Instance);
                BorrowersUserControl1.Instance.Dock = DockStyle.Fill;
                BorrowersUserControl1.Instance.BringToFront();
            }
            else
            {
                BorrowersUserControl1.Instance.BringToFront();
            }
        }

        private void transactionButton_Click(object sender, EventArgs e)
        {
            if (! contentPanel.Controls.Contains(TransactionsUserControl1.Instance))
            {
                contentPanel.Controls.Add(TransactionsUserControl1.Instance);
                TransactionsUserControl1.Instance.Dock = DockStyle.Fill;
                TransactionsUserControl1.Instance.BringToFront();
            }
            else
            {
                TransactionsUserControl1.Instance.BringToFront();
            }
        }

        public void ManageSet(string manage)
        {
            string management = manage;
            manageCheckLabel.Text = management;
        }

        private void settingButton_Click(object sender, EventArgs e)
        {

            
                SQLConnect.connect.Open();
            

                // Kullanıcının yetkisi olup olmadığını kontrol eden SQL sorgusu
                string sql = "SELECT COUNT(*) FROM users WHERE username = @username AND is_management = 'management'";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, SQLConnect.connect))
                {
                
                    command.Parameters.AddWithValue("@username", manageCheckLabel.Text);
                    var count = (long)command.ExecuteScalar();

                    if (count > 0)
                    {
                        SQLConnect.connect.Close();
                        if (!contentPanel.Controls.Contains(ManagementUserControl1.Instance))
                        {
                            contentPanel.Controls.Add(ManagementUserControl1.Instance);
                            ManagementUserControl1.Instance.Dock = DockStyle.Fill;
                            ManagementUserControl1.Instance.BringToFront();
                        }
                        else
                        {
                            ManagementUserControl1.Instance.BringToFront();
                        }

                    }
                    else
                    {
                        MessageBox.Show("User does not have authorization");
                    SQLConnect.connect.Close();
                    }

                    

                }


        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(AboutUserControl1.Instance))
            {
                contentPanel.Controls.Add(AboutUserControl1.Instance);
                AboutUserControl1.Instance.Dock = DockStyle.Fill;
                AboutUserControl1.Instance.BringToFront();
            }
            else
            {
                AboutUserControl1.Instance.BringToFront();
            }
        }
    }
}
