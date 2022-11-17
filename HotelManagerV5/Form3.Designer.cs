namespace HotelManagerV5
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBox_AantalDagen = new System.Windows.Forms.TextBox();
            this.button_Toevoegen = new System.Windows.Forms.Button();
            this.textBox_NamenInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.listbox_form3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(693, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBox_AantalDagen
            // 
            this.textBox_AantalDagen.Location = new System.Drawing.Point(148, 87);
            this.textBox_AantalDagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_AantalDagen.Name = "textBox_AantalDagen";
            this.textBox_AantalDagen.Size = new System.Drawing.Size(0, 22);
            this.textBox_AantalDagen.TabIndex = 27;
            // 
            // button_Toevoegen
            // 
            this.button_Toevoegen.Location = new System.Drawing.Point(129, 117);
            this.button_Toevoegen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Toevoegen.MinimumSize = new System.Drawing.Size(200, 46);
            this.button_Toevoegen.Name = "button_Toevoegen";
            this.button_Toevoegen.Size = new System.Drawing.Size(200, 46);
            this.button_Toevoegen.TabIndex = 31;
            this.button_Toevoegen.Text = "Toevoegen";
            this.button_Toevoegen.UseVisualStyleBackColor = true;
            this.button_Toevoegen.Click += new System.EventHandler(this.button_TaxBerreken_Click);
            // 
            // textBox_NamenInput
            // 
            this.textBox_NamenInput.Location = new System.Drawing.Point(148, 87);
            this.textBox_NamenInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_NamenInput.Name = "textBox_NamenInput";
            this.textBox_NamenInput.Size = new System.Drawing.Size(100, 22);
            this.textBox_NamenInput.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 90);
            this.label8.MinimumSize = new System.Drawing.Size(131, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Namen";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(12, 49);
            this.Label15.MinimumSize = new System.Drawing.Size(200, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(200, 16);
            this.Label15.TabIndex = 21;
            this.Label15.Text = "Inschrijven ";
            this.Label15.Click += new System.EventHandler(this.label_VerblijfBerekenen_Click);
            // 
            // listbox_form3
            // 
            this.listbox_form3.FormattingEnabled = true;
            this.listbox_form3.ItemHeight = 16;
            this.listbox_form3.Location = new System.Drawing.Point(393, 49);
            this.listbox_form3.Name = "listbox_form3";
            this.listbox_form3.Size = new System.Drawing.Size(191, 180);
            this.listbox_form3.TabIndex = 34;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 247);
            this.Controls.Add(this.listbox_form3);
            this.Controls.Add(this.textBox_NamenInput);
            this.Controls.Add(this.button_Toevoegen);
            this.Controls.Add(this.textBox_AantalDagen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Inschrijvingen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBox_AantalDagen;
        private System.Windows.Forms.Button button_Toevoegen;
        private System.Windows.Forms.TextBox textBox_NamenInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.ListBox listbox_form3;
    }
}