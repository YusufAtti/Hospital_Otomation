namespace HospitalOtomation
{
    partial class Patience_Sign_up
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textname = new System.Windows.Forms.TextBox();
            this.textsurname = new System.Windows.Forms.TextBox();
            this.msktxtnumber = new System.Windows.Forms.MaskedTextBox();
            this.msktxtphone = new System.Windows.Forms.MaskedTextBox();
            this.textpassw = new System.Windows.Forms.TextBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(65, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(21, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Serial Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.Location = new System.Drawing.Point(61, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.Location = new System.Drawing.Point(78, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(187, 43);
            this.textname.Multiline = true;
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(133, 29);
            this.textname.TabIndex = 1;
            // 
            // textsurname
            // 
            this.textsurname.Location = new System.Drawing.Point(187, 81);
            this.textsurname.Multiline = true;
            this.textsurname.Name = "textsurname";
            this.textsurname.Size = new System.Drawing.Size(133, 29);
            this.textsurname.TabIndex = 2;
            // 
            // msktxtnumber
            // 
            this.msktxtnumber.Location = new System.Drawing.Point(187, 126);
            this.msktxtnumber.Mask = "00000000000";
            this.msktxtnumber.Name = "msktxtnumber";
            this.msktxtnumber.Size = new System.Drawing.Size(133, 22);
            this.msktxtnumber.TabIndex = 3;
            this.msktxtnumber.ValidatingType = typeof(int);
            // 
            // msktxtphone
            // 
            this.msktxtphone.Location = new System.Drawing.Point(187, 164);
            this.msktxtphone.Mask = "(999) 000-0000";
            this.msktxtphone.Name = "msktxtphone";
            this.msktxtphone.Size = new System.Drawing.Size(133, 22);
            this.msktxtphone.TabIndex = 4;
            // 
            // textpassw
            // 
            this.textpassw.Location = new System.Drawing.Point(187, 202);
            this.textpassw.Multiline = true;
            this.textpassw.Name = "textpassw";
            this.textpassw.Size = new System.Drawing.Size(133, 29);
            this.textpassw.TabIndex = 5;
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbgender.Location = new System.Drawing.Point(187, 247);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(133, 24);
            this.cmbgender.TabIndex = 6;
            // 
            // Patience_Sign_up
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 368);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.textpassw);
            this.Controls.Add(this.msktxtphone);
            this.Controls.Add(this.msktxtnumber);
            this.Controls.Add(this.textsurname);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Patience_Sign_up";
            this.Text = "Patient_Sign_up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textsurname;
        private System.Windows.Forms.MaskedTextBox msktxtnumber;
        private System.Windows.Forms.MaskedTextBox msktxtphone;
        private System.Windows.Forms.TextBox textpassw;
        private System.Windows.Forms.ComboBox cmbgender;
    }
}