using System.Runtime.InteropServices;
using System.Windows.Forms;
using Library_Automation_WithDatabaseManagementSystem.sql;
using Npgsql;
namespace Library_Automation_WithDatabaseManagementSystem
{
    public partial class LOGINPAGE : Form
    {
        public LOGINPAGE()
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

            String userName,passWord;

            userName = UNtextBox.Text;
            passWord = PWtextBox.Text;
            string converter = SHAConverter.ComputeSha256Hash(passWord); 
            String sqlLogIn = "SELECT COUNT(*) FROM users WHERE username = @userName and " +
             "userpassword = @passWord";

            using (var cmd = new NpgsqlCommand(sqlLogIn, SQLConnect.connect))
            {
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@passWord", converter);
                var result = (long?)cmd.ExecuteScalar(); 
                if (result > 0) 
                {
                    AppBodyPage appBody = new AppBodyPage();
                    appBody.ManageSet(userName);
                    label3.Visible = false;
                    this.Hide();
                    appBody.Show();
                }
                else
                {
                    label3.Visible = true;
                }
            }

            SQLConnect.connect.Close();
        }


        private void SignUpLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpPage signUp = new SignUpPage();
            signUp.Show();
        }

        private void LOGINPAGE_Load(object sender, EventArgs e)
        {
            label3.Visible= false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void logOfButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No account is online");
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}