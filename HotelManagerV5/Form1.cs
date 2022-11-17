using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagerV5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        // button_Check In and Out
        private void button1_Click(object sender, EventArgs e) // button_Check In
        {
            Persoon nieuwPersoon = new Persoon(textBox_FirstName.Text,textBox_LastName.Text, textBox_Email.Text);
            //if (radioButton_2P.Checked) { gastenlijst_Table.RoomType = radioButton_2P.Text; }
            //if (radioButton_4P.Checked) { gastenlijst_Table.RoomType = radioButton_4P.Text; }
            //if (radioButton_8P.Checked) { gastenlijst_Table.RoomType = radioButton_8P.Text; }
            nieuwPersoon.AddPersoonToDataBase();
            MessageBox.Show("Toegevoegd aan Gastenlijst Calender");
            textBox_FirstName.Clear();
            textBox_LastName.Clear();
            textBox_Email.Clear(); 

            // toevoegen aan lokalaal database 
            // using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ToString())) ;

        }

        private void button_CheckOut_Click(object sender, EventArgs e) // button_Check Out
        {

        }

        //
        // Close Menu Strip  Form 1
        // EVENT 
        //

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)  // Close
        {
            Form1 form = new Form1();
            this.Close();
            
        }

        //
        // MDI Parent forms2
        // EVENT 
        // EXTRA Tablad
        //

        private void GastenlijstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 GastenlijstTab = new Form2();
            try
            {
                GastenlijstTab.MdiParent = this;
            }
            catch
            {
                Console.WriteLine(); 
            }
            GastenlijstTab.Show(); 
        }

        //
        // MDI Child Forms3
        // EVENT 
        // EXTRA Tablad
        //
        private void taxBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newMDIChild = new Form4();
            try
            {
                newMDIChild.MdiParent = this;
            }
            catch
            {
                Console.WriteLine(); 
            }
            newMDIChild.Show();

        }

        private void label_VerblijfBerekenen_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void getData()
        {
            string dataConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DotNetAdv2\\Project_HotelManagement_V5\\HotelManagerV5\\HotelManagerV5\\Gastenlijst.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(dataConnection);

            SqlCommand command = new SqlCommand("SELECT FistName, LastName, Email FROM Gastenlijst_Table");
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Persoon.LijstPersoon.Add(new Persoon(reader.GetString(0), reader.GetString(1), reader.GetString(2)));
                }
                connection.Close();
            }
        }

    }
        
}

