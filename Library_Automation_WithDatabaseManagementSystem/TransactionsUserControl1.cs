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
    public partial class TransactionsUserControl1 : UserControl
    {
        private static TransactionsUserControl1 _instance;
        public static TransactionsUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance= new TransactionsUserControl1();
                }
                return _instance;
            }
        }
        public TransactionsUserControl1()
        {
            InitializeComponent();
        }

        public string book1, book2, borrower;

        private void IssueButton_Click(object sender, EventArgs e)
        {
            int transactionNumber = Convert.ToInt32(TransactionTextBox.Text);
            int borrowerno = Convert.ToInt32(BorrowerNoTextBox.Text);
            int bookıd = Convert.ToInt32(BookNoTextBox.Text);
            DateTime ıssueDate = issueDatePicker.Value.Date;
            DateTime returnDate = returnDatePicker.Value.Date;


            try
            {
                NpgsqlCommand command = new NpgsqlCommand("transaction_add", SQLConnectEmploye.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("t_num", transactionNumber);
                command.Parameters.AddWithValue("datee", ıssueDate);
                command.Parameters.AddWithValue("brid", borrowerno);
                command.Parameters.AddWithValue("bookno", bookıd);
                command.Parameters.AddWithValue("returndate", returnDate);

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

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            int bookNo = Convert.ToInt32(BookNoTextBox.Text);
            int tnum = Convert.ToInt32(TransactionTextBox.Text);

            try
            {
                NpgsqlCommand command = new NpgsqlCommand("return_book", SQLConnectEmploye.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("bookno", bookNo);
                command.Parameters.AddWithValue("t_num", tnum);


                SQLConnectEmploye.connect.Open();

                try
                {
                    command.ExecuteNonQuery();

                    MessageBox.Show("Return is successfull");
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



            try
            {
                NpgsqlCommand command2 = new NpgsqlCommand("delete_transaction", SQLConnectEmploye.connect);
                command2.CommandType = CommandType.StoredProcedure;
                command2.Parameters.AddWithValue("t_num", tnum);


                SQLConnectEmploye.connect.Open();

                try
                {
                    command2.ExecuteNonQuery();
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


        private void ClearButton_Click(object sender, EventArgs e)
        {
            TransactionTextBox.Text = "";
            BorrowerNoTextBox.Text = "";
            BookNoTextBox.Text = "";
            refreshDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tnum = Convert.ToInt32(dataGridView1.CurrentCell.Value.ToString());
            DateTime extendDate = extendDatePicker.Value.Date;


            try
            {
                NpgsqlCommand command = new NpgsqlCommand("date_extend", SQLConnectEmploye.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("t_num", tnum);
                command.Parameters.AddWithValue("returndate", extendDate);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pick = dataGridView1.SelectedCells[0].RowIndex;
            int tno = Convert.ToInt32(dataGridView1.Rows[pick].Cells[0].Value);
            string borrowerno = dataGridView1.Rows[pick].Cells[1].Value.ToString();
            string bookno = dataGridView1.Rows[pick].Cells[3].Value.ToString();
            DateTime issueDate = (DateTime)dataGridView1.Rows[pick].Cells[4].Value;
            DateTime returnDate = (DateTime)dataGridView1.Rows[pick].Cells[5].Value;
            

            TransactionTextBox.Text = tno.ToString();
            BorrowerNoTextBox.Text = borrowerno;
            BookNoTextBox.Text = bookno;
            issueDatePicker.Value = issueDate;
            returnDatePicker.Value = returnDate;
        }

        public void refreshDataGridView()
        {
            SQLConnectEmploye.connect.Open();
            NpgsqlDataAdapter MyDA = new NpgsqlDataAdapter();
            string sqlSelectAll = "SELECT * FROM get_transaction";
            MyDA.SelectCommand = new NpgsqlCommand(sqlSelectAll, SQLConnectEmploye.connect);

            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView1.DataSource = bSource;
            SQLConnectEmploye.connect.Close();
        }

        private void TransactionsUserControl1_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
    }
}
