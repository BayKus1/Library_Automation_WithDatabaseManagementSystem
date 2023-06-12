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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Library_Automation_WithDatabaseManagementSystem
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
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



        private void LOGINBTN_Click(object sender, EventArgs e)
        {
            SQLConnect.CheckConnection(SQLConnect.connect);
             
            string userName=UNtextBox.Text;
            string password=PWtextBox.Text;
            string name=NameTxtBox.Text;
            string surname=SurnameTextBox.Text;
            string email=EmailTextBox.Text;
            string phone=PhoneTextBox.Text;
            string sha256 = SHAConverter.ComputeSha256Hash(password);

            if (UNtextBox.Text != "" && PWtextBox.Text != "" && NameTxtBox.Text != ""
                && SurnameTextBox.Text != "" && EmailTextBox.Text != "" && PhoneTextBox.Text != "")
            {
                label3.Visible= false;
                string usersql = "SELECT COUNT(*) FROM users WHERE username = @username";
                using (var cmd = new NpgsqlCommand(usersql, SQLConnect.connect))
                {
                    cmd.Parameters.AddWithValue("username", userName);
                    var result = (long?)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        MessageBox.Show("This username or e-mail address has already been registered.");
                    }
                    else
                    {
                        NpgsqlCommand command = new NpgsqlCommand("SELECT signup(@username, @userpassword, @firstname, @surname, @email, @phone)", SQLConnect.connect);

                        command.Parameters.AddWithValue("username", userName);
                        command.Parameters.AddWithValue("userpassword", sha256);
                        command.Parameters.AddWithValue("firstname", name);
                        command.Parameters.AddWithValue("surname", surname);
                        command.Parameters.AddWithValue("email", email);
                        command.Parameters.AddWithValue("phone", phone);
                        command.ExecuteNonQuery();
                        SQLConnect.connect.Close();


                        UNtextBox.Text = "";
                        PWtextBox.Text = "";
                        NameTxtBox.Text = "";
                        SurnameTextBox.Text = "";
                        EmailTextBox.Text = "";
                        PhoneTextBox.Text = "";

                        MessageBox.Show("Registration Successful");
                        
                    }
                }
            }
            else
            {
                label3.Visible = true;
            }
        }


        private void SignUpPage_Load(object sender, EventArgs e)
        {
            label3.Visible= false;
        }

        private void SignUpLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGINPAGE lOGINPAGE = new LOGINPAGE();
            lOGINPAGE.Show();
        }

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
    }
}
