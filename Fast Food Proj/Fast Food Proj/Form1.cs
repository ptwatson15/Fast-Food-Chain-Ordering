using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Fast_Food_Proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {





        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {



        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {



        }

        private void button5_Click(object sender, EventArgs e)
        {



        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                //ORDER
                //SAVE BUTTON

                //GET THE DATA IN THE FORM
                string Order_Id, CUS_ID_2, Food_2, Quantity, Price_2, DineTake, Tab_Add;
                Order_Id = this.Order_Id.Text.ToString();
                CUS_ID_2 = this.CUS_ID_2.Text.ToString();
                Food_2 = this.Food_2.Text.ToString();
                Quantity = this.Quantity.Text.ToString();
                Price_2 = this.Price_2.Text.ToString();
                DineTake = this.DineTake.Text.ToString();
                Tab_Add = this.Tab_Add.Text.ToString();

                //ACCESS THE DATA SOURCE

                string connString = @"Data Source=LAPTOP-4PNL296I;Initial Catalog=FastFood;Integrated Security=True";
                SqlConnection connStudent = new SqlConnection(connString);
                connStudent.Open();

                string sqlInsertStatement = @"Use Fastfood
                                            Insert into dbo.ORDERS(CUS_ID,Food,Quantity, Price,DineTake, Tab_Add)
                                            Values('" + CUS_ID_2 + "', '" + Food_2 + "', '" + Quantity + "', '"
                                                  + Price_2 + "', '" + DineTake + "', '" + Tab_Add /* + "','','"+Order_Id */+ "' )";
                SqlCommand cmdTxt = new SqlCommand(sqlInsertStatement, connStudent);

                cmdTxt.ExecuteNonQuery();
                MessageBox.Show("Saved!");



                //CLOSE THE DATA SOURCE
                connStudent.Close();
                connStudent.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button10_Click(object sender, EventArgs e)
        {
            //ORDER
            //UPDATE BUTTON

            //GET THE DATA IN THE FORM
            string Order_Id, CUS_ID_2, Food_2, Quantity, Price_2, DineTake, Tab_Add;
            Order_Id = this.Order_Id.Text.ToString();
            CUS_ID_2 = this.CUS_ID_2.Text.ToString();
            Food_2 = this.Food_2.Text.ToString();
            Quantity = this.Quantity.Text.ToString();
            Price_2 = this.Price_2.Text.ToString();
            DineTake = this.DineTake.Text.ToString();
            Tab_Add = this.Tab_Add.Text.ToString();

            //ACCESS THE DATA SOURCE

            string connString = @"Data Source=LAPTOP-4PNL296I;Initial Catalog=FastFood;Integrated Security=True";
            SqlConnection connStudent = new SqlConnection(connString);
            connStudent.Open();

            string sqlUPDATEstring = @"Use FastFood
                                            Update dbo.ORDERS 
                                            Set
                                             CUS_ID = '" + CUS_ID_2 +
                                          "', Food = '" + Food_2 +
                                           "', Quantity = '" + Quantity +
                                            "', Price = '" + Price_2 +
                                            "', DineTake = '" + DineTake +
                                            "', Tab_Add = '" + Tab_Add +
                                         "' WHERE (Order_Id = '" + Order_Id + "')";
            SqlCommand UPDATEcmd = new SqlCommand(sqlUPDATEstring);

            UPDATEcmd.Connection = connStudent;
            UPDATEcmd.ExecuteNonQuery();

            connStudent.Close();
            connStudent.Dispose();
            MessageBox.Show("Updated");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //ORDER
            //DELETE BUTTON

            //GET THE DATA IN THE FORM
            string Order_Id, CUS_ID_2, Food_2, Quantity, Price_2, DineTake, Tab_Add;
            Order_Id = this.Order_Id.Text.ToString();
            CUS_ID_2 = this.CUS_ID_2.Text.ToString();
            Food_2 = this.Food_2.Text.ToString();
            Quantity = this.Quantity.Text.ToString();
            Price_2 = this.Price_2.Text.ToString();
            DineTake = this.DineTake.Text.ToString();
            Tab_Add = this.Tab_Add.Text.ToString();


            //ACCESS THE DATA SOURCE

            string connString = @"Data Source=LAPTOP-4PNL296I;Initial Catalog=FastFood;Integrated Security=True";
            SqlConnection connStudent = new SqlConnection(connString);
            connStudent.Open();

            string sqlDELETEstring =
               @"DELETE FROM ORDERS WHERE (Order_Id = '" + Order_Id + "')";
            SqlCommand cmdDELETE = new SqlCommand(sqlDELETEstring);

            cmdDELETE.Connection = connStudent;
            cmdDELETE.ExecuteNonQuery();

            connStudent.Close();
            connStudent.Dispose();

            MessageBox.Show("Deleted!");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //ORDER
            //CANCEL BUTTON
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdData.Rows[e.RowIndex];


                try
                {
                    if (grdData.Columns.Contains("Order_ID") == true)
                    {
                        Order_Id.Text = row.Cells["Order_ID"].Value.ToString();
                    }

                    if (grdData.Columns.Contains("Food") == true)
                    {
                        Food_2.Text = row.Cells["Food"].Value.ToString();
                    }

                    if (grdData.Columns.Contains("CUS_ID") == true)
                    {
                        CUS_ID_2.Text = row.Cells["CUS_ID"].Value.ToString();
                    }

                    if (grdData.Columns.Contains("Quantity") == true)
                    {
                        Quantity.Text = row.Cells["Quantity"].Value.ToString();
                    }
                    if (grdData.Columns.Contains("Price") == true)
                    {
                        Price_2.Text = row.Cells["Price"].Value.ToString();
                    }
                    if (grdData.Columns.Contains("DineTake") == true)
                    {
                        DineTake.Text = row.Cells["DineTake"].Value.ToString();
                    }
                    if (grdData.Columns.Contains("Tab_Add") == true)
                    {
                        Tab_Add.Text = row.Cells["Tab_Add"].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //set the connection string
            string connString = @"Data Source=LAPTOP-4PNL296I;Initial Catalog=FastFood;Integrated Security=True";


            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    //retrieve the SQL Server instance version
                    string query = @"SELECT * from MENU";

                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, conn);


                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                    //define dataset
                    DataSet ds = new DataSet();

                    //fill dataset with query results
                    dAdapter.Fill(ds);

                    //set DataGridView control to read-only
                    grdData.ReadOnly = true;

                    //set the DataGridView control's data source/data table
                    grdData.DataSource = ds.Tables[0];


                    //close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //LOAD ORDERS
            //set the connection string
            string connString = @"Data Source=LAPTOP-4PNL296I;Initial Catalog=FastFood;Integrated Security=True";


            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    //retrieve the SQL Server instance version
                    string Order_Id = this.Order_Id.Text.ToString();
                    string query = @"SELECT  Order_ID, CUS_ID, Food, Quantity, Price, DineTake, Tab_Add, Time_Stamp from ORDERS where Order_Id='" + Order_Id + "'";

                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, conn);


                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                    //define dataset
                    DataSet ds = new DataSet();

                    //fill dataset with query results
                    dAdapter.Fill(ds);

                    //set DataGridView control to read-only
                    dataGridView1.ReadOnly = true;

                    //set the DataGridView control's data source/data table
                    dataGridView1.DataSource = ds.Tables[0];


                    //close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //set the connection string
            string connString = @"Data Source=LAPTOP-4PNL296I;Initial Catalog=FastFood;Integrated Security=True";


            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    //retrieve the SQL Server instance version
                    string CUS_ID_2 = this.CUS_ID_2.Text.ToString();
                    //string query = @"SELECT CUS_ID,Fname,Mname,Lname from CUSTOMER;";
                    string query = @"SELECT CUS_ID,Fname,Mname,Lname from CUSTOMER where CUS_ID='" + CUS_ID_2 + "';";

                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, conn);


                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                    //define dataset
                    DataSet ds = new DataSet();

                    //fill dataset with query results
                    dAdapter.Fill(ds);

                    //set DataGridView control to read-only
                    grdData.ReadOnly = true;

                    //set the DataGridView control's data source/data table
                    grdData.DataSource = ds.Tables[0];


                    //close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //ALL ORDERS
            //set the connection string
            string connString = @"Data Source=LAPTOP-4PNL296I;Initial Catalog=FastFood;Integrated Security=True";


            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    //retrieve the SQL Server instance version
                    string Order_Id = this.Order_Id.Text.ToString();
                    string query = @"select Order_ID, CUS_ID, Food, Quantity, Price, DineTake, Tab_Add, Time_Stamp from ORDERS ";

                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, conn);


                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                    //define dataset
                    DataSet ds = new DataSet();

                    //fill dataset with query results
                    dAdapter.Fill(ds);

                    //set DataGridView control to read-only
                    dataGridView1.ReadOnly = true;

                    //set the DataGridView control's data source/data table
                    dataGridView1.DataSource = ds.Tables[0];


                    //close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //Clear Text
            Order_Id.Text = "";
            CUS_ID_2.Text = "";
            Food_2.Text = "";
            Quantity.Text = "";
            Price_2.Text = "";
            DineTake.Text = "";
            Tab_Add.Text = "";

        }

        private void Price_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {



            try
            {
                double PRICENUM = double.Parse(Price_2.Text.ToString());
                double QUANNUM = double.Parse(Quantity.Text.ToString());
                Price_2.Text = (PRICENUM * QUANNUM).ToString();
            }
            catch (Exception ex)
            {
                //display error message
                //MessageBox.Show("(PRICE-QUANITY) Exception: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            //set the connection string
            string connString = @"Data Source=LAPTOP-4PNL296I;Initial Catalog=FastFood;Integrated Security=True";


            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    //retrieve the SQL Server instance version
                    string CUS_ID_2 = this.CUS_ID_2.Text.ToString();
                    string query = @"SELECT CUS_ID,Fname,Mname,Lname from CUSTOMER;";
                    //string query = @"SELECT CUS_ID,Fname,Mname,Lname from CUSTOMER where CUS_ID='" + CUS_ID_2 + "';";

                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, conn);


                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                    //define dataset
                    DataSet ds = new DataSet();

                    //fill dataset with query results
                    dAdapter.Fill(ds);

                    //set DataGridView control to read-only
                    grdData.ReadOnly = true;

                    //set the DataGridView control's data source/data table
                    grdData.DataSource = ds.Tables[0];


                    //close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {



        }

        private void totalSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ACCESS THE DATA SOURCE

            string connString = @"Data Source=LAPTOP-4PNL296I;Initial Catalog=FastFood;Integrated Security=True";
            SqlConnection connStudent = new SqlConnection(connString);
            connStudent.Open();

            string SELECTSUM1 =
               @"select sum(Price) from Orders";
            SqlCommand cmdSUMM = new SqlCommand(SELECTSUM1);

            cmdSUMM.Connection = connStudent;
            cmdSUMM.ExecuteNonQuery();


            MessageBox.Show("Total Sales From All Orders is $" + cmdSUMM.ExecuteScalar().ToString());

            connStudent.Close();
            connStudent.Dispose();
        }

        private void editMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MENU BUTTON
            MENU f3 = new MENU();
            f3.ShowDialog(); // Shows MENU FORM
        }

        private void editCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CUSTOMER BUTTON
            CUSTOMER f2 = new CUSTOMER();
            f2.ShowDialog(); // Shows CUSTOMER FORM
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //GENERATE REPORT BY LOCATION
            string CUS_ID_2 = this.CUS_ID_2.Text.ToString();
            string Tab_Add = this.Tab_Add.Text.ToString();
            //set the connection string
            string connString = @"Data Source=LAPTOP-4PNL296I;Initial Catalog=FastFood;Integrated Security=True";


            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    //retrieve the SQL Server instance version
                    string Order_Id = this.Order_Id.Text.ToString();
                    string query = @"select Order_ID, CUS_ID, Food, Quantity, Price, DineTake, Tab_Add, Time_Stamp from Orders where Tab_Add='" + Tab_Add + "'";
                    // string query = @"select * from Orders where CUS_ID='" + CUS_ID_2+"'";

                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, conn);


                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                    //define dataset
                    DataSet ds = new DataSet();

                    //fill dataset with query results
                    dAdapter.Fill(ds);

                    //set DataGridView control to read-only
                    dataGridView1.ReadOnly = true;

                    //set the DataGridView control's data source/data table
                    dataGridView1.DataSource = ds.Tables[0];


                    //close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }




        private void Order_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            //GENERATE REPORT BY Customer
            string CUS_ID_2 = this.CUS_ID_2.Text.ToString();
            string Tab_Add = this.Tab_Add.Text.ToString();
            //set the connection string
            string connString = @"Data Source=LAPTOP-4PNL296I;Initial Catalog=FastFood;Integrated Security=True";


            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    //retrieve the SQL Server instance version
                    string Order_Id = this.Order_Id.Text.ToString();
                    //string query = @"select * from Orders where Tab_Add='" + Tab_Add + "'";
                    string query = @"select Order_ID, CUS_ID, Food, Quantity, Price, DineTake, Tab_Add, Time_Stamp from Orders where CUS_ID='" + CUS_ID_2 + "'";

                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, conn);


                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                    //define dataset
                    DataSet ds = new DataSet();

                    //fill dataset with query results
                    dAdapter.Fill(ds);

                    //set DataGridView control to read-only
                    dataGridView1.ReadOnly = true;

                    //set the DataGridView control's data source/data table
                    dataGridView1.DataSource = ds.Tables[0];


                    //close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];


                try
                {
                    if (dataGridView1.Columns.Contains("Order_ID") == true)
                    {
                        Order_Id.Text = row.Cells["Order_ID"].Value.ToString();
                    }

                    if (dataGridView1.Columns.Contains("Food") == true)
                    {
                        Food_2.Text = row.Cells["Food"].Value.ToString();
                    }

                    if (dataGridView1.Columns.Contains("CUS_ID") == true)
                    {
                        CUS_ID_2.Text = row.Cells["CUS_ID"].Value.ToString();
                    }

                    if (dataGridView1.Columns.Contains("Quantity") == true)
                    {
                        Quantity.Text = row.Cells["Quantity"].Value.ToString();
                    }
                    if (dataGridView1.Columns.Contains("Price") == true)
                    {
                        Price_2.Text = row.Cells["Price"].Value.ToString();
                    }
                    if (dataGridView1.Columns.Contains("DineTake") == true)
                    {
                        DineTake.Text = row.Cells["DineTake"].Value.ToString();
                    }
                    if (dataGridView1.Columns.Contains("Tab_Add") == true)
                    {
                        Tab_Add.Text = row.Cells["Tab_Add"].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
