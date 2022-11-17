namespace HotelManagerV5
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GastenlijstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton_2P = new System.Windows.Forms.RadioButton();
            this.radioButton_4P = new System.Windows.Forms.RadioButton();
            this.radioButton_8P = new System.Windows.Forms.RadioButton();
            this.button_CheckIn = new System.Windows.Forms.Button();
            this.button_CheckOut = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.dateTimePicker_CheckinDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_CheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.MaximumSize = new System.Drawing.Size(100, 0);
            this.label1.MinimumSize = new System.Drawing.Size(100, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name";
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(118, 27);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_LastName.TabIndex = 1;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(118, 53);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_FirstName.TabIndex = 2;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(118, 79);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(100, 20);
            this.textBox_Email.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.GastenlijstToolStripMenuItem,
            this.taxBToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.menuToolStripMenuItem.Text = "Close";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // GastenlijstToolStripMenuItem
            // 
            this.GastenlijstToolStripMenuItem.Name = "GastenlijstToolStripMenuItem";
            this.GastenlijstToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.GastenlijstToolStripMenuItem.Text = "Gastenlijst";
            this.GastenlijstToolStripMenuItem.Click += new System.EventHandler(this.GastenlijstToolStripMenuItem_Click);
            // 
            // taxBToolStripMenuItem
            // 
            this.taxBToolStripMenuItem.Name = "taxBToolStripMenuItem";
            this.taxBToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.taxBToolStripMenuItem.Text = "Activiteiten";
            this.taxBToolStripMenuItem.Click += new System.EventHandler(this.taxBToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.MinimumSize = new System.Drawing.Size(100, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.MinimumSize = new System.Drawing.Size(100, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.MinimumSize = new System.Drawing.Size(100, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Room Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.MinimumSize = new System.Drawing.Size(100, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Checkin Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.MinimumSize = new System.Drawing.Size(100, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Check- Out Date";
            // 
            // radioButton_2P
            // 
            this.radioButton_2P.AutoSize = true;
            this.radioButton_2P.Location = new System.Drawing.Point(118, 106);
            this.radioButton_2P.MinimumSize = new System.Drawing.Size(145, 20);
            this.radioButton_2P.Name = "radioButton_2P";
            this.radioButton_2P.Size = new System.Drawing.Size(145, 20);
            this.radioButton_2P.TabIndex = 13;
            this.radioButton_2P.TabStop = true;
            this.radioButton_2P.Text = "2 PersoonsKamer";
            this.radioButton_2P.UseVisualStyleBackColor = true;
            // 
            // radioButton_4P
            // 
            this.radioButton_4P.AutoSize = true;
            this.radioButton_4P.Location = new System.Drawing.Point(235, 106);
            this.radioButton_4P.MinimumSize = new System.Drawing.Size(145, 20);
            this.radioButton_4P.Name = "radioButton_4P";
            this.radioButton_4P.Size = new System.Drawing.Size(145, 20);
            this.radioButton_4P.TabIndex = 14;
            this.radioButton_4P.TabStop = true;
            this.radioButton_4P.Text = "4 PersoonsKamer";
            this.radioButton_4P.UseVisualStyleBackColor = true;
            // 
            // radioButton_8P
            // 
            this.radioButton_8P.AutoSize = true;
            this.radioButton_8P.Location = new System.Drawing.Point(353, 106);
            this.radioButton_8P.MinimumSize = new System.Drawing.Size(145, 20);
            this.radioButton_8P.Name = "radioButton_8P";
            this.radioButton_8P.Size = new System.Drawing.Size(145, 20);
            this.radioButton_8P.TabIndex = 15;
            this.radioButton_8P.TabStop = true;
            this.radioButton_8P.Text = "8 PersoonsKamer";
            this.radioButton_8P.UseVisualStyleBackColor = true;
            // 
            // button_CheckIn
            // 
            this.button_CheckIn.Location = new System.Drawing.Point(27, 178);
            this.button_CheckIn.Name = "button_CheckIn";
            this.button_CheckIn.Size = new System.Drawing.Size(85, 23);
            this.button_CheckIn.TabIndex = 16;
            this.button_CheckIn.Text = "Check- In";
            this.button_CheckIn.UseVisualStyleBackColor = true;
            this.button_CheckIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_CheckOut
            // 
            this.button_CheckOut.Location = new System.Drawing.Point(118, 178);
            this.button_CheckOut.Name = "button_CheckOut";
            this.button_CheckOut.Size = new System.Drawing.Size(85, 23);
            this.button_CheckOut.TabIndex = 17;
            this.button_CheckOut.Text = "Check- Out";
            this.button_CheckOut.UseVisualStyleBackColor = true;
            this.button_CheckOut.Click += new System.EventHandler(this.button_CheckOut_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // dateTimePicker_CheckinDate
            // 
            this.dateTimePicker_CheckinDate.Location = new System.Drawing.Point(118, 128);
            this.dateTimePicker_CheckinDate.Name = "dateTimePicker_CheckinDate";
            this.dateTimePicker_CheckinDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_CheckinDate.TabIndex = 18;
            // 
            // dateTimePicker_CheckOutDate
            // 
            this.dateTimePicker_CheckOutDate.Location = new System.Drawing.Point(118, 154);
            this.dateTimePicker_CheckOutDate.Name = "dateTimePicker_CheckOutDate";
            this.dateTimePicker_CheckOutDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_CheckOutDate.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 285);
            this.Controls.Add(this.dateTimePicker_CheckOutDate);
            this.Controls.Add(this.dateTimePicker_CheckinDate);
            this.Controls.Add(this.button_CheckOut);
            this.Controls.Add(this.button_CheckIn);
            this.Controls.Add(this.radioButton_8P);
            this.Controls.Add(this.radioButton_4P);
            this.Controls.Add(this.radioButton_2P);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton_2P;
        private System.Windows.Forms.RadioButton radioButton_4P;
        private System.Windows.Forms.RadioButton radioButton_8P;
        private System.Windows.Forms.Button button_CheckIn;
        private System.Windows.Forms.Button button_CheckOut;
        private System.Windows.Forms.ToolStripMenuItem GastenlijstToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CheckinDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CheckOutDate;
        private System.Windows.Forms.ToolStripMenuItem taxBToolStripMenuItem;
    }
}

