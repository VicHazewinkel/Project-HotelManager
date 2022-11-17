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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //
        // Close Menu Strip  Form 1
        // EVENT 
        // Tablad Sluiten 
        //

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            this.Close();
        }

        private void label_VerblijfBerekenen_Click(object sender, EventArgs e)
        {
            Label15.Font = new Font("Arial", 24, FontStyle.Bold);
        }

        //
        // Lambda-expressie 
        // Click_EVENT
        //


        private void button_TaxBerreken_Click(object sender, EventArgs e)       //Toevoegen (aanpassing) 
        {
            List<string> namen = new List<string>();
            namen.Add(textBox_NamenInput.Text);

            // lambda expression
            namen.ForEach(naam => listbox_form3.Items.Add(naam));

        }
    }
}
