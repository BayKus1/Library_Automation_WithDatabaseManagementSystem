using Library_Automation_WithDatabaseManagementSystem.sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace Library_Automation_WithDatabaseManagementSystem
{
    public partial class BooksUserControl1 : UserControl
    {

        private static BooksUserControl1 _instance;
        public static BooksUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance= new BooksUserControl1();
                }
                return _instance;
            }
        }
        public BooksUserControl1()
        {
            InitializeComponent();
        }

        
        private void BooksUserControl1_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int accNo = Convert.ToInt32(AccNoTextBox.Text);
            int departmentNumber;
            String book_Name =NameTextBox.Text;
            String isbn=ISBNTextBox.Text;
            String publisher=PublisherTextBox.Text;
            String author=AuthorTextBox.Text;
            String departmant_id = departmentIDComboBox.Text;
            if (departmant_id == "Computer")
            {
                departmentNumber = 1;
            }
            else if (departmant_id == "Network")
            {
                departmentNumber = 2;
            }
            else
            {
                departmentNumber= 3;
            }

            try
            {
                NpgsqlCommand command = new NpgsqlCommand("BooksAdd_SP", SQLConnectEmploye.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("acc_no", accNo);
                command.Parameters.AddWithValue("isbn", isbn);
                command.Parameters.AddWithValue("book_name", book_Name);
                command.Parameters.AddWithValue("author", author);
                command.Parameters.AddWithValue("publisher", publisher);
                command.Parameters.AddWithValue("dep_id", departmentNumber);
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

        public void refreshDataGridView()
        {
            SQLConnectEmploye.connect.Open();
            NpgsqlDataAdapter MyDA = new NpgsqlDataAdapter();
            string sqlSelectAll = "SELECT * FROM get_book_info";
            MyDA.SelectCommand = new NpgsqlCommand(sqlSelectAll, SQLConnectEmploye.connect);

            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView1.DataSource = bSource;
            SQLConnectEmploye.connect.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            String accNo=AccNoTextBox.Text;
            try
            {
                SQLConnectEmploye.connect.Open();
                NpgsqlCommand command = new NpgsqlCommand("call book_delete(" + Convert.ToInt32(dataGridView1.CurrentCell.Value.ToString()) + ")", SQLConnectEmploye.connect);

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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                String bookSearch = BookIDTextBox.Text;
                NpgsqlCommand cmd = new NpgsqlCommand("select* from get_book_info where acc_no =" + bookSearch + "", SQLConnectEmploye.connect);


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

                for (int i = 0; i < 8; i++)
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

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            AccNoTextBox.Text = "";
            BookIDTextBox.Text = "";
            NameTextBox.Text = "";
            AuthorTextBox.Text = "";
            PublisherTextBox.Text = "";
            ISBNTextBox.Text = "";
            departmentIDComboBox.Text = "";
            refreshDataGridView();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int accNo = Convert.ToInt32(AccNoTextBox.Text);
            int departmentNumber;
            String book_Name = NameTextBox.Text;
            String isbn = ISBNTextBox.Text;
            String publisher = PublisherTextBox.Text;
            String author = AuthorTextBox.Text;
            String departmant_id = departmentIDComboBox.Text;
            if (departmant_id == "Computer")
            {
                departmentNumber = 1;
            }
            else if (departmant_id == "Network")
            {
                departmentNumber = 2;
            }
            else
            {
                departmentNumber = 3;
            }

            try
            {
                NpgsqlCommand command = new NpgsqlCommand("book_update", SQLConnectEmploye.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("accno", accNo);
                command.Parameters.AddWithValue("isbnn", isbn);
                command.Parameters.AddWithValue("bookname", book_Name);
                command.Parameters.AddWithValue("authorr", author);
                command.Parameters.AddWithValue("publisherr", publisher);
                command.Parameters.AddWithValue("depid", departmentNumber);
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
                int accno = Convert.ToInt32(dataGridView1.Rows[pick].Cells[0].Value);
                string isbn = dataGridView1.Rows[pick].Cells[1].Value.ToString();
                string name = dataGridView1.Rows[pick].Cells[2].Value.ToString();
                string author = dataGridView1.Rows[pick].Cells[3].Value.ToString();
                string publisher = dataGridView1.Rows[pick].Cells[4].Value.ToString();
                int department = Convert.ToInt32(dataGridView1.Rows[pick].Cells[5].Value);

                AccNoTextBox.Text = accno.ToString();
                NameTextBox.Text = name;
                AuthorTextBox.Text = author;
                ISBNTextBox.Text = isbn;
                PublisherTextBox.Text = publisher;
                departmentIDComboBox.Text=department.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
    }
}
