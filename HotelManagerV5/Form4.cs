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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            this.Close();
        }

        private void button_ToInschrijven_Click(object sender, EventArgs e)
        {
            Form3 GastenlijstTab = new Form3();
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

        private void interesseInActiviteitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 GastenlijstTab = new Form3();
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

        private void tennisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction");
        }
    }
}
