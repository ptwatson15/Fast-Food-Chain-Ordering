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
    public partial class CUSTOMER : Form
    {
        public CUSTOMER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //CUSTOMER
                //SAVE BUTTON

                //GET THE DATA IN THE FORM
                string CUS_ID, Fname, Mname, Lname;
                CUS_ID = this.CUS_ID.Text.ToString();
                Lname = this.Lname.Text.ToString();
                Mname = this.Mname.Text.ToString();
                Fname = this.Fname.Text.ToString();

                //ACCESS THE DATA SOURCE

                string connString = @"Data Source=LAPTOP-4PNL296I;Initial Catalog=FastFood;Integrated Security=True";
                SqlConnection connStudent = new SqlConnection(connString);
                connStudent.Open();

                string sqlInsertStatement = @"Use Fastfood
                                            Insert into dbo.CUSTOMER 
                                            Values('" + CUS_ID + "','" + Fname + "', '" + Lname + "', '"
                                               + Mname + "' )";
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

        private void button3_Click(object sender, EventArgs e)
        {
            //CUSTOMER
            //UPDATE BUTTON

            try
            {
                //GET THE DATA IN THE FORM
                string CUS_ID, Fname, Mname, Lname;
                CUS_ID = this.CUS_ID.Text.ToString();
                Lname = this.Lname.Text.ToString();
                Mname = this.Mname.Text.ToString();
                Fname = this.Fname.Text.ToString();

                //ACCESS THE DATA SOURCE

                string connString = @"Data Source=LAPTOP-4PNL296I;Initial Catalog=FastFood;Integrated Security=True";
                SqlConnection connStudent = new SqlConnection(connString);
                connStudent.Open();

                string sqlUPDATEstring = @"Use FastFood
                                            Update dbo.Customer 
                                            Set
                                               Lname = '" + Lname +
                                              "', Fname = '" + Fname +
                                              "', Mname = '" + Mname +
                                             "' WHERE (CUS_ID = '" + CUS_ID + "')";
                SqlCommand UPDATEcmd = new SqlCommand(sqlUPDATEstring);

                UPDATEcmd.Connection = connStudent;
                UPDATEcmd.ExecuteNonQuery();

                connStudent.Close();
                connStudent.Dispose();
                MessageBox.Show("Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CUSTOMER
            //CANCEL BUTTON
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //CUSTOMER

            //DELETE BUTTON

            try
            {
                //GET THE DATA IN THE FORM
                string CUS_ID, Fname, Mname, Lname;
                CUS_ID = this.CUS_ID.Text.ToString();
                Lname = this.Lname.Text.ToString();
                Mname = this.Mname.Text.ToString();
                Fname = this.Fname.Text.ToString();

                //ACCESS THE DATA SOURCE

                string connString = @"Data Source=LAPTOP-4PNL296I;Initial Catalog=FastFood;Integrated Security=True";
                SqlConnection connStudent = new SqlConnection(connString);
                connStudent.Open();

                string sqlDELETEstring =
                   @"DELETE FROM CUSTOMER WHERE (CUS_ID = '" + CUS_ID + "')";
                SqlCommand cmdDELETE = new SqlCommand(sqlDELETEstring);

                cmdDELETE.Connection = connStudent;
                cmdDELETE.ExecuteNonQuery();

                connStudent.Close();
                connStudent.Dispose();

                MessageBox.Show("Deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CUSTOMER_Load(object sender, EventArgs e)
        {

        }
    }
}
