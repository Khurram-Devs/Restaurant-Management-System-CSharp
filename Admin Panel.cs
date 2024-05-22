//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//namespace Admin_Panel_Assignment
//{
//    public partial class Admin_Panel : Form
//    {
//        public Admin_Panel()
//        {
//            InitializeComponent();
//            PlaceholderHelper.SetPlaceholder(textBox1, "ITEM NAME");
//            PlaceholderHelper.SetPlaceholder(textBox2, "ITEM PRICE");
//            PlaceholderHelper.SetPlaceholder(textBox3, "ITEM QUANTITY");
//        }

//        public SqlConnection connect()
//        {
//            string ConnectionString = "Data Source=DESKTOP-T1L3Q7N;Initial Catalog=foodpanda;Integrated Security=True";
//            SqlConnection conn = new SqlConnection(ConnectionString);

//            return conn;

//        }

//        public void FetchData()
//        {
//            SqlConnection conn = this.connect();
//            string Query = "SELECT * FROM foodList";
//            SqlCommand command = new SqlCommand(Query, conn);

//            conn.Open();
//            SqlDataAdapter adapter = new SqlDataAdapter(command);
//            DataTable dataTable = new DataTable();
//            adapter.Fill(dataTable);


//            DataColumn serialColumn = new DataColumn("Serial No", typeof(int));
//            dataTable.Columns.Add(serialColumn);


//            for (int i = 0; i < dataTable.Rows.Count; i++)
//            {
//                dataTable.Rows[i]["Serial No"] = (i + 1);
//            }

//            dataGridView1.DataSource = dataTable;
//        }


//        public void InsertRow()
//        {


//            try
//            {
//                string food_Name = textBox1.Text;
//                int food_Price = int.Parse(textBox2.Text);
//                int food_Quant = int.Parse(textBox3.Text);

//                SqlConnection conn = this.connect();
//                conn.Open();

//                string QueryCheck = "SELECT * FROM foodList WHERE food_name = @food_name";
//                SqlCommand commandCheck = new SqlCommand(QueryCheck, conn);
//                commandCheck.Parameters.AddWithValue("@food_name", food_Name);
//                SqlDataReader check = commandCheck.ExecuteReader();

//                if (check.HasRows)
//                {
//                    MessageBox.Show("Item already exists...");
//                    conn.Close();
//                }
//                else
//                {
//                    check.Close();

//                    string Query = "INSERT INTO foodList (food_name, food_price, food_quantity) VALUES(@food_name,@food_price, @food_quant)";
//                    SqlCommand command = new SqlCommand(Query, conn);
//                    command.Parameters.AddWithValue("@food_name", food_Name);
//                    command.Parameters.AddWithValue("@food_price", food_Price);
//                    command.Parameters.AddWithValue("@food_quant", food_Quant);

//                    command.ExecuteNonQuery();

//                    PlaceholderHelper.SetPlaceholder(textBox1, "ITEM NAME");
//                    PlaceholderHelper.SetPlaceholder(textBox2, "ITEM PRICE");
//                    PlaceholderHelper.SetPlaceholder(textBox3, "ITEM QUANTITY");
//                    textBox1.ForeColor = System.Drawing.Color.Gray;
//                    textBox2.ForeColor = System.Drawing.Color.Gray;
//                    textBox3.ForeColor = System.Drawing.Color.Gray;
//                    MessageBox.Show("Item Added...");

//                    this.FetchData();
//                    conn.Close();
//                }

//            }
//            catch (System.FormatException)
//            {
//                MessageBox.Show("FAILED! PLEASE ENTER THE VALID VALUES...");
//            }




//        }

//        public void FetchRowData(int columnIndex)
//        {
//            if (dataGridView1.SelectedCells.Count == 0)
//            {
//                MessageBox.Show("Please select a cell first...");
//                return;
//            }

//            DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
//            DataGridViewRow selectedRow = selectedCell.OwningRow;

//            if (selectedRow.Cells.Count > columnIndex && columnIndex >= 0)
//            {
//                string foodname = (string)selectedRow.Cells["food_name"].Value;
//                int foodprice = (int)selectedRow.Cells["food_price"].Value;
//                int foodquantity = (int)selectedRow.Cells["food_quantity"].Value;

//                textBox1.Text = foodname;
//                textBox2.Text = foodprice.ToString();
//                textBox3.Text = foodquantity.ToString();
//            }
//            else
//            {
//                MessageBox.Show("Invalid column index.");
//            }
//        }


//        public void UpdateRowData()
//        {
//            try
//            {
//                string food_Name = textBox1.Text;
//                int food_Price = int.Parse(textBox2.Text);
//                int food_Quant = int.Parse(textBox3.Text);
//                int _id = (int)dataGridView1.SelectedCells[0].OwningRow.Cells["food_ID"].Value;

//                SqlConnection conn = this.connect();
//                conn.Open();

//                string QueryCheck = "SELECT * FROM foodList WHERE food_name = @food_name";
//                SqlCommand commandCheck = new SqlCommand(QueryCheck, conn);
//                commandCheck.Parameters.AddWithValue("@food_name", food_Name);
//                SqlDataReader check = commandCheck.ExecuteReader();

//                if (check.HasRows)
//                {
//                    MessageBox.Show("Item already exists...");
//                    conn.Close();
//                }
//                else
//                {
//                    check.Close();

//                    string Query = "UPDATE foodList SET food_name = @food_name, food_price = @food_price, food_quantity = @food_quant WHERE food_ID = @updateID;";
//                    SqlCommand command = new SqlCommand(Query, conn);
//                    command.Parameters.AddWithValue("@food_name", food_Name);
//                    command.Parameters.AddWithValue("@food_price", food_Price);
//                    command.Parameters.AddWithValue("@food_quant", food_Quant);
//                    command.Parameters.AddWithValue("@updateID", _id);

//                    command.ExecuteNonQuery();

//                    PlaceholderHelper.SetPlaceholder(textBox1, "ITEM NAME");
//                    PlaceholderHelper.SetPlaceholder(textBox2, "ITEM PRICE");
//                    PlaceholderHelper.SetPlaceholder(textBox3, "ITEM QUANTITY");
//                    textBox1.ForeColor = System.Drawing.Color.Gray;
//                    textBox2.ForeColor = System.Drawing.Color.Gray;
//                    textBox3.ForeColor = System.Drawing.Color.Gray;
//                    MessageBox.Show("SUCCESSFULL! ITEM UPDATED...");

//                    this.FetchData();
//                    conn.Close();
//                }
//            }
//            catch (System.FormatException)
//            {
//                MessageBox.Show("FAILED! PLEASE ENTER THE VALID VALUES...");
//            }
//        }

//        public void deleteRow()
//        {

//            try
//            {
//                int _id = (int)dataGridView1.SelectedCells[0].OwningRow.Cells["food_ID"].Value;
//                SqlConnection conn = this.connect();
//                string Query = "delete from foodList where food_ID = @deleteID ";
//                SqlCommand command = new SqlCommand(Query, conn);
//                command.Parameters.AddWithValue("@deleteID", _id);
//                conn.Open();
//                command.ExecuteNonQuery();
//                this.FetchData();
//                conn.Close();
//                MessageBox.Show("SUCCESSFULL! ITEM DELETED...");
//            }
//            catch (System.NullReferenceException)
//            {
//                MessageBox.Show("INVALID ITEM...");
//            }
//            catch (Exception)
//            {
//                MessageBox.Show("PLEASE SELECT A ITEM FIRST...");
//            }

//        }

//        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {
//            int ColInd = e.ColumnIndex;
//            this.FetchRowData(ColInd);
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            this.FetchData();

//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            this.deleteRow();
//        }

//        private void button3_Click(object sender, EventArgs e)
//        {
//            this.InsertRow();
//        }

//        private void button4_Click(object sender, EventArgs e)
//        {
//            this.UpdateRowData();
//        }

//        private void Admin_Panel_Load(object sender, EventArgs e)
//        {
//            this.foodlistTableAdapter.Fill(this.foodpandaDataSet.foodlist);
//            this.FetchData();


//        }



//    }
//}



using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Admin_Panel_Assignment
{
    public partial class Admin_Panel : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-T1L3Q7N;Initial Catalog=foodpanda;Integrated Security=True";

        public Admin_Panel()
        {
            InitializeComponent();
            SetPlaceholders();
            this.MaximizeBox = false;
            this.Closed += App_Closed;
        }

        private void App_Closed(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void SetPlaceholders()
        {
            PlaceholderHelper.SetPlaceholder(textBox1, "ITEM NAME");
            PlaceholderHelper.SetPlaceholder(textBox2, "ITEM PRICE");
            PlaceholderHelper.SetPlaceholder(textBox3, "ITEM QUANTITY");
        }

        private SqlConnection Connect()
        {
            return new SqlConnection(connectionString);
        }

        private void FetchData()
        {
            using (SqlConnection conn = Connect())
            {
                string query = "SELECT * FROM foodList";
                SqlCommand command = new SqlCommand(query, conn);

                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void InsertRow()
        {
            try
            {
                string foodName = textBox1.Text;
                int foodPrice = int.Parse(textBox2.Text);
                int foodQuant = int.Parse(textBox3.Text);

                using (SqlConnection conn = Connect())
                {
                    conn.Open();

                    string queryCheck = "SELECT * FROM foodList WHERE food_name = @food_name";
                    SqlCommand commandCheck = new SqlCommand(queryCheck, conn);
                    commandCheck.Parameters.AddWithValue("@food_name", foodName);
                    SqlDataReader check = commandCheck.ExecuteReader();

                    if (check.HasRows)
                    {
                        MessageBox.Show("Item already exists...");
                        return;
                    }

                    check.Close();

                    string query = "INSERT INTO foodList (food_name, food_price, food_quantity) VALUES(@food_name,@food_price, @food_quant)";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@food_name", foodName);
                    command.Parameters.AddWithValue("@food_price", foodPrice);
                    command.Parameters.AddWithValue("@food_quant", foodQuant);

                    command.ExecuteNonQuery();

                    SetPlaceholders();
                    MessageBox.Show("Item Added...");
                    FetchData();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("FAILED! PLEASE ENTER THE VALID VALUES...");
            }
        }

        private void UpdateRowData()
        {
            try
            {
                string foodName = textBox1.Text;
                int foodPrice = int.Parse(textBox2.Text);
                int foodQuant = int.Parse(textBox3.Text);
                int id = (int)dataGridView1.SelectedCells[0].OwningRow.Cells["food_ID"].Value;

                using (SqlConnection conn = Connect())
                {
                    conn.Open();

                    string queryCheck = "SELECT * FROM foodList WHERE food_name = @food_name AND food_ID != @updateID";
                    SqlCommand commandCheck = new SqlCommand(queryCheck, conn);
                    commandCheck.Parameters.AddWithValue("@food_name", foodName);
                    commandCheck.Parameters.AddWithValue("@updateID", id);

                    SqlDataReader check = commandCheck.ExecuteReader();

                    if (check.HasRows)
                    {
                        MessageBox.Show("Item already exists...");
                        return;
                    }

                    check.Close();

                    string query = "UPDATE foodList SET food_name = @food_name, food_price = @food_price, food_quantity = @food_quant WHERE food_ID = @updateID;";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@food_name", foodName);
                    command.Parameters.AddWithValue("@food_price", foodPrice);
                    command.Parameters.AddWithValue("@food_quant", foodQuant);
                    command.Parameters.AddWithValue("@updateID", id);

                    command.ExecuteNonQuery();

                    SetPlaceholders();
                    MessageBox.Show("SUCCESSFULL! ITEM UPDATED...");
                    FetchData();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("FAILED! PLEASE ENTER THE VALID VALUES...");
            }
        }

        private void DeleteRow()
        {
            try
            {
                int id = (int)dataGridView1.SelectedCells[0].OwningRow.Cells["food_ID"].Value;
                using (SqlConnection conn = Connect())
                {
                    string query = "delete from foodList where food_ID = @deleteID ";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@deleteID", id);
                    conn.Open();
                    command.ExecuteNonQuery();
                    FetchData();
                    MessageBox.Show("SUCCESSFULL! ITEM DELETED...");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("INVALID ITEM...");
            }
            catch (Exception)
            {
                MessageBox.Show("PLEASE SELECT A ITEM FIRST...");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            FetchRowData(columnIndex);
        }

        private void FetchRowData(int columnIndex)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a cell first...");
                return;
            }

            DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
            DataGridViewRow selectedRow = selectedCell.OwningRow;

            if (selectedRow.Cells.Count > columnIndex && columnIndex >= 0)
            {
                string foodname = (string)selectedRow.Cells["food_name"].Value;
                int foodprice = (int)selectedRow.Cells["food_price"].Value;
                int foodquantity = (int)selectedRow.Cells["food_quantity"].Value;

                textBox1.Text = foodname;
                textBox2.Text = foodprice.ToString();
                textBox3.Text = foodquantity.ToString();
            }
            else
            {
                MessageBox.Show("Invalid column index.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FetchData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertRow();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateRowData();
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            FetchData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
