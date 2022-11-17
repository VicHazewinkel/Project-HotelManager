using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagerV5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        //
        // Menu Strip  Form 2
        //
        private void menuToolStripMenuItem_Click(object sender, EventArgs e) // Close
        {
            Form2 form = new Form2();
            this.Close(); 
        }

        private void GastenlijstToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.gastenlijst_TableTableAdapter = new GastenlijstDataSetTableAdapters.Gastenlijst_TableTableAdapter(); 
            // TODO: This line of code loads data into the 'gastenlijstDataSet.Gastenlijst_Table' table. You can move, or remove it, as needed.
            // this.gastenlijst_TableTableAdapter.Fill(this.gastenlijstDataSet.Gastenlijst_Table);

        }
    }
}
