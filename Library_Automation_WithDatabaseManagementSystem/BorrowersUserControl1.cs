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
    public partial class BorrowersUserControl1 : UserControl
    {
        private static BorrowersUserControl1 _instance;
        public static BorrowersUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BorrowersUserControl1();
                }
                return _instance;
            }
        }
        public BorrowersUserControl1()
        {
            InitializeComponent();
        }

        public void refreshDataGridView()
        {
            SQLConnectEmploye.connect.Open();
            NpgsqlDataAdapter MyDA = new NpgsqlDataAdapter();
            string sqlSelectAll = "SELECT * FROM get_borrowers";
            MyDA.SelectCommand = new NpgsqlCommand(sqlSelectAll, SQLConnectEmploye.connect);

            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView1.DataSource = bSource;
            SQLConnectEmploye.connect.Close();
        }
        private void BorrowersUserControl1_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int brid = Convert.ToInt32(BorrowerNoTextBox.Text);
            String name = NameTextBox.Text;
            String address = AddressTextBox.Text;
            String phone = PhoneTextBox.Text;

            try
            {
                NpgsqlCommand command = new NpgsqlCommand("borrower_add", SQLConnectEmploye.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("brid", brid);
                command.Parameters.AddWithValue("borname", name);
                command.Parameters.AddWithValue("addres", address);
                command.Parameters.AddWithValue("phone", phone);
                SQLConnectEmploye.connect.Open();

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid SQL Operation : " + ex);
                }

                SQLConnectEmploye.connect.Close();

                refreshDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            SQLConnectEmploye.connect.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConnectEmploye.connect.Open();
                NpgsqlCommand command = new NpgsqlCommand("call borrower_delete(" + Convert.ToInt32(dataGridView1.CurrentCell.Value.ToString()) + ")", SQLConnectEmploye.connect);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid SQL Operation : " + ex);
                }

                SQLConnectEmploye.connect.Close();

                refreshDataGridView();
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            BorrowerIDTextBox.Text = "";
            BorrowerNoTextBox.Text = "";
            PhoneTextBox.Text = "";
            AddressTextBox.Text = "";
            NameTextBox.Text = "";
            refreshDataGridView();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                String borrowerSearch = BorrowerIDTextBox.Text;
                NpgsqlCommand cmd = new NpgsqlCommand("select* from get_borrowers where br_id =" + borrowerSearch + "", SQLConnectEmploye.connect);


                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);


                SQLConnectEmploye.connect.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid SQL Operation : " + ex);
                }

                SQLConnectEmploye.connect.Close();

                dataGridView1.DataSource = dataSet.Tables[0];

                for (int i = 0; i < 4; i++)
                {
                    if (i != 2 || i != 0)
                    {
                        this.dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    else
                    {
                        this.dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            SQLConnectEmploye.connect.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pick = dataGridView1.SelectedCells[0].RowIndex;
            int brNo = Convert.ToInt32(dataGridView1.Rows[pick].Cells[0].Value);
            string name = dataGridView1.Rows[pick].Cells[1].Value.ToString();
            string adress = dataGridView1.Rows[pick].Cells[2].Value.ToString();
            string phone = dataGridView1.Rows[pick].Cells[3].Value.ToString();

            BorrowerNoTextBox.Text = brNo.ToString();
            NameTextBox.Text = name;
            AddressTextBox.Text = adress;
            PhoneTextBox.Text = phone;

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int brid = Convert.ToInt32(BorrowerNoTextBox.Text);
            String name = NameTextBox.Text;
            String address = AddressTextBox.Text;
            String phone = PhoneTextBox.Text;

            try
            {
                NpgsqlCommand command = new NpgsqlCommand("borrower_update", SQLConnectEmploye.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("brid", brid);
                command.Parameters.AddWithValue("borname", name);
                command.Parameters.AddWithValue("addres", address);
                command.Parameters.AddWithValue("phonee", phone);
                SQLConnectEmploye.connect.Open();

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
            SQLConnectEmploye.connect.Close();

            refreshDataGridView();
        }
    }
}
