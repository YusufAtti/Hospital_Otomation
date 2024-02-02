namespace HospitalOtomation
{
    partial class aLoginPatient
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
            this.lblptserial = new System.Windows.Forms.Label();
            this.lblptpassw = new System.Windows.Forms.Label();
            this.msktxtptnumber = new System.Windows.Forms.MaskedTextBox();
            this.textBoxptpassw = new System.Windows.Forms.TextBox();
            this.linkLabelptsignup = new System.Windows.Forms.LinkLabel();
            this.btnptclogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblptserial
            // 
            this.lblptserial.AutoSize = true;
            this.lblptserial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblptserial.Location = new System.Drawing.Point(37, 39);
            this.lblptserial.Name = "lblptserial";
            this.lblptserial.Size = new System.Drawing.Size(129, 22);
            this.lblptserial.TabIndex = 1;
            this.lblptserial.Text = "Serial Number:";
            // 
            // lblptpassw
            // 
            this.lblptpassw.AutoSize = true;
            this.lblptpassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblptpassw.Location = new System.Drawing.Point(71, 77);
            this.lblptpassw.Name = "lblptpassw";
            this.lblptpassw.Size = new System.Drawing.Size(99, 22);
            this.lblptpassw.TabIndex = 2;
            this.lblptpassw.Text = "Password: ";
            // 
            // msktxtptnumber
            // 
            this.msktxtptnumber.Location = new System.Drawing.Point(190, 39);
            this.msktxtptnumber.Mask = "00000000000";
            this.msktxtptnumber.Name = "msktxtptnumber";
            this.msktxtptnumber.Size = new System.Drawing.Size(141, 22);
            this.msktxtptnumber.TabIndex = 3;
            this.msktxtptnumber.Text = "11111111111";
            this.msktxtptnumber.ValidatingType = typeof(int);
            // 
            // textBoxptpassw
            // 
            this.textBoxptpassw.Location = new System.Drawing.Point(190, 77);
            this.textBoxptpassw.Name = "textBoxptpassw";
            this.textBoxptpassw.Size = new System.Drawing.Size(141, 22);
            this.textBoxptpassw.TabIndex = 4;
            this.textBoxptpassw.Text = "0000";
            this.textBoxptpassw.UseSystemPasswordChar = true;
            // 
            // linkLabelptsignup
            // 
            this.linkLabelptsignup.AutoSize = true;
            this.linkLabelptsignup.Location = new System.Drawing.Point(286, 167);
            this.linkLabelptsignup.Name = "linkLabelptsignup";
            this.linkLabelptsignup.Size = new System.Drawing.Size(52, 16);
            this.linkLabelptsignup.TabIndex = 5;
            this.linkLabelptsignup.TabStop = true;
            this.linkLabelptsignup.Text = "Sign up";
            this.linkLabelptsignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelptsignup_LinkClicked);
            // 
            // btnptclogin
            // 
            this.btnptclogin.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnptclogin.Location = new System.Drawing.Point(213, 114);
            this.btnptclogin.Name = "btnptclogin";
            this.btnptclogin.Size = new System.Drawing.Size(118, 35);
            this.btnptclogin.TabIndex = 6;
            this.btnptclogin.Text = "Log in";
            this.btnptclogin.UseVisualStyleBackColor = false;
            this.btnptclogin.Click += new System.EventHandler(this.btnptclogin_Click);
            // 
            // aLoginPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(354, 192);
            this.Controls.Add(this.btnptclogin);
            this.Controls.Add(this.linkLabelptsignup);
            this.Controls.Add(this.textBoxptpassw);
            this.Controls.Add(this.msktxtptnumber);
            this.Controls.Add(this.lblptpassw);
            this.Controls.Add(this.lblptserial);
            this.Name = "aLoginPatient";
            this.Text = "LoginPatient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblptserial;
        private System.Windows.Forms.Label lblptpassw;
        private System.Windows.Forms.MaskedTextBox msktxtptnumber;
        private System.Windows.Forms.TextBox textBoxptpassw;
        private System.Windows.Forms.LinkLabel linkLabelptsignup;
        private System.Windows.Forms.Button btnptclogin;
    }
}