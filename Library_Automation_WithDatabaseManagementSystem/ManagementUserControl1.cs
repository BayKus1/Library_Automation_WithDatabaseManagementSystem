using Library_Automation_WithDatabaseManagementSystem.sql;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Automation_WithDatabaseManagementSystem
{
    public partial class ManagementUserControl1 : UserControl
    {
        private static ManagementUserControl1 _instance;
        public static ManagementUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ManagementUserControl1();
                }
                return _instance;
            }
        }
        public ManagementUserControl1()
        {
            InitializeComponent();
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            
            int userno = Convert.ToInt32(UserNoTextBox.Text);
            string password = UserPasswordTextBox.Text;
            String username = UserNameTextBox.Text;
            String email = EmailTextBox.Text;
            String name = FirstNameTextBox.Text;
            String surname = SurnameTextBox.Text;
            String phone = PhoneTextBox.Text;

            string sha256Converter = SHAConverter.ComputeSha256Hash(password);


            try
            {
                NpgsqlCommand command = new NpgsqlCommand("user_update", SQLConnectManager.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("user_no", userno);
                command.Parameters.AddWithValue("user_name", username);
                command.Parameters.AddWithValue("user_password", sha256Converter);
                command.Parameters.AddWithValue("first_name", name);
                command.Parameters.AddWithValue("surnamee", surname);
                command.Parameters.AddWithValue("e_mail", email);
                command.Parameters.AddWithValue("phonee", phone);
                SQLConnectManager.connect.Open();

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid SQL Operation : " + ex);
                } 

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            SQLConnectManager.connect.Close();

            refreshDataGridView();
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConnectManager.connect.Open();
                NpgsqlCommand command = new NpgsqlCommand("call user_delete(" + Convert.ToInt32(dataGridView1.CurrentCell.Value.ToString()) + ")", SQLConnectManager.connect);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid SQL Operation : " + ex);
                }
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            SQLConnectManager.connect.Close();
            refreshDataGridView();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserNoTextBox.Text = "";
            UserNameTextBox.Text = "";
            UserPasswordTextBox.Text = "";
            FirstNameTextBox.Text = "";
            SurnameTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneTextBox.Text = "";
            refreshDataGridView();
        }


        public void refreshDataGridView()
        {
            SQLConnectManager.connect.Open();
            NpgsqlDataAdapter MyDA = new NpgsqlDataAdapter();
            string sqlSelectAll = "SELECT * FROM get_user";
            MyDA.SelectCommand = new NpgsqlCommand(sqlSelectAll, SQLConnectManager.connect);

            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView1.DataSource = bSource;
            SQLConnectManager.connect.Close();
        }

        private void ManagementUserControl1_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pick = dataGridView1.SelectedCells[0].RowIndex;
            int userNo = Convert.ToInt32(dataGridView1.Rows[pick].Cells[0].Value);
            string username = dataGridView1.Rows[pick].Cells[1].Value.ToString();
            string password = dataGridView1.Rows[pick].Cells[2].Value.ToString();
            string name = dataGridView1.Rows[pick].Cells[3].Value.ToString();
            string surname = dataGridView1.Rows[pick].Cells[4].Value.ToString();
            string email = dataGridView1.Rows[pick].Cells[5].Value.ToString();
            string phone = dataGridView1.Rows[pick].Cells[6].Value.ToString();

            UserNoTextBox.Text = userNo.ToString();
            UserNameTextBox.Text = username;
            UserPasswordTextBox.Text = password;
            FirstNameTextBox.Text = name;
            SurnameTextBox.Text = surname;
            PhoneTextBox.Text = phone;
            EmailTextBox.Text = email;
        }

        private void GrantAuthorityButton_Click(object sender, EventArgs e)
        {
            int userno = Convert.ToInt32(UserNoTextBox.Text);

            try
            {
                NpgsqlCommand command = new NpgsqlCommand("add_grant", SQLConnectManager.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("userr_no", userno);
                SQLConnectManager.connect.Open();

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid SQL Operation : " + ex);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            SQLConnectManager.connect.Close();

            refreshDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userno = Convert.ToInt32(UserNoTextBox.Text);

            try
            {
                NpgsqlCommand command = new NpgsqlCommand("revoke_grant", SQLConnectManager.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("userr_no", userno);
                SQLConnectManager.connect.Open();

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid SQL Operation : " + ex);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            SQLConnectManager.connect.Close();

            refreshDataGridView();
        }
    }
}
