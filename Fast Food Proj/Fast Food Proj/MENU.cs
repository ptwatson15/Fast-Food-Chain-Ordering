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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                //MENU
                //SAVE BUTTON

                //GET THE DATA IN THE FORM
                string Menu_Id, Food, Price, Category;
                Menu_Id = this.Menu_Id.Text.ToString();
                Food = this.Food.Text.ToString();
                Price = this.Price.Text.ToString();
                Category = this.Category.Text.ToString();

                //ACCESS THE DATA SOURCE

                string connString = @"Data Source=LAPTOP-4PNL296I;Initial Catalog=FastFood;Integrated Security=True";
                SqlConnection connStudent = new SqlConnection(connString);
                connStudent.Open();

                string sqlInsertStatement = @"Use Fastfood
                                            Insert into dbo.MENU 
                                            Values('" + Menu_Id + "','" + Food + "', '" + Price + "', '"
                                               + Category + "' )";
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

        private void button6_Click(object sender, EventArgs e)
        {
            //MENU
            //UPDATE BUTTON

            //GET THE DATA IN THE FORM
            string Menu_Id, Food, Price, Category;
            Menu_Id = this.Menu_Id.Text.ToString();
            Food = this.Food.Text.ToString();
            Price = this.Price.Text.ToString();
            Category = this.Category.Text.ToString();

            //ACCESS THE DATA SOURCE

            string connString = @"Data Source=LAPTOP-4PNL296I;Initial Catalog=FastFood;Integrated Security=True";
            SqlConnection connStudent = new SqlConnection(connString);
            connStudent.Open();

            string sqlUPDATEstring = @"Use FastFood
                                            Update dbo.MENU 
                                            Set
                                               Food = '" + Food +
                                          "', Price = '" + Price +
                                          "', Category = '" + Category +
                                         "' WHERE (Menu_Id = '" + Menu_Id + "')";
            SqlCommand UPDATEcmd = new SqlCommand(sqlUPDATEstring);

            UPDATEcmd.Connection = connStudent;
            UPDATEcmd.ExecuteNonQuery();

            connStudent.Close();
            connStudent.Dispose();
            MessageBox.Show("Updated");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MENU
            //DELETE BUTTON

            //GET THE DATA IN THE FORM
            string Menu_Id, Food, Price, Category;
            Menu_Id = this.Menu_Id.Text.ToString();
            Food = this.Food.Text.ToString();
            Price = this.Price.Text.ToString();
            Category = this.Category.Text.ToString();


            //ACCESS THE DATA SOURCE

            string connString = @"Data Source=LAPTOP-4PNL296I;Initial Catalog=FastFood;Integrated Security=True";
            SqlConnection connStudent = new SqlConnection(connString);
            connStudent.Open();

            string sqlDELETEstring =
               @"DELETE FROM MENU WHERE (Food = '" + Food + "')";
            SqlCommand cmdDELETE = new SqlCommand(sqlDELETEstring);

            cmdDELETE.Connection = connStudent;
            cmdDELETE.ExecuteNonQuery();

            connStudent.Close();
            connStudent.Dispose();

            MessageBox.Show("Deleted!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //MENU
            //CANCEL BUTTON
            this.Close();
        }
    }
}
