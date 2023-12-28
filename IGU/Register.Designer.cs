using System.Linq;
using System.Windows.Forms;

namespace IGU
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.Email_textbox = new System.Windows.Forms.TextBox();
            this.BackToLogin_label = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.Register_Button = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Confirm_pas_textbox = new System.Windows.Forms.TextBox();
            this.Nickname_textbox = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Email_label_errors = new System.Windows.Forms.Label();
            this.Password_label_errors = new System.Windows.Forms.Label();
            this.ConfirmP_label_errors = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Email_textbox
            // 
            this.Email_textbox.BackColor = System.Drawing.Color.LightGray;
            this.Email_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Email_textbox.Font = new System.Drawing.Font("Microsoft Tai Le", 13F);
            this.Email_textbox.Location = new System.Drawing.Point(50, 57);
            this.Email_textbox.Multiline = true;
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.Size = new System.Drawing.Size(299, 35);
            this.Email_textbox.TabIndex = 20;
            this.Email_textbox.Text = "email@gmail.com";
            this.Email_textbox.TextChanged += new System.EventHandler(this.email_textbox_TextChanged);
            // 
            // BackToLogin_label
            // 
            this.BackToLogin_label.AccessibleDescription = "";
            this.BackToLogin_label.AccessibleName = "";
            this.BackToLogin_label.AutoSize = true;
            this.BackToLogin_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToLogin_label.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.BackToLogin_label.ForeColor = System.Drawing.Color.SlateBlue;
            this.BackToLogin_label.Location = new System.Drawing.Point(154, 660);
            this.BackToLogin_label.Name = "BackToLogin_label";
            this.BackToLogin_label.Size = new System.Drawing.Size(99, 18);
            this.BackToLogin_label.TabIndex = 18;
            this.BackToLogin_label.Text = "Back to Login";
            this.BackToLogin_label.Click += new System.EventHandler(this.backToLogin_label_Click);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CheckBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.CheckBox1.ForeColor = System.Drawing.Color.Gray;
            this.CheckBox1.Location = new System.Drawing.Point(218, 491);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(131, 22);
            this.CheckBox1.TabIndex = 16;
            this.CheckBox1.Text = "Show Password";
            this.CheckBox1.UseVisualStyleBackColor = false;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Label2
            // 
            this.Label2.AccessibleDescription = "";
            this.Label2.AccessibleName = "";
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.Gray;
            this.Label2.Location = new System.Drawing.Point(44, 296);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(82, 21);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Password";
            // 
            // Label1
            // 
            this.Label1.AccessibleDescription = "";
            this.Label1.AccessibleName = "";
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.Gray;
            this.Label1.Location = new System.Drawing.Point(45, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 21);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Email";
            // 
            // Password_textbox
            // 
            this.Password_textbox.BackColor = System.Drawing.Color.LightGray;
            this.Password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_textbox.Font = new System.Drawing.Font("Microsoft Tai Le", 13F);
            this.Password_textbox.Location = new System.Drawing.Point(51, 330);
            this.Password_textbox.Multiline = true;
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.PasswordChar = '*';
            this.Password_textbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Password_textbox.Size = new System.Drawing.Size(298, 35);
            this.Password_textbox.TabIndex = 13;
            this.Password_textbox.Text = "1234";
            this.Password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            // 
            // Register_Button
            // 
            this.Register_Button.BackColor = System.Drawing.Color.SlateBlue;
            this.Register_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_Button.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Button.ForeColor = System.Drawing.Color.GhostWhite;
            this.Register_Button.Location = new System.Drawing.Point(48, 547);
            this.Register_Button.Name = "Register_Button";
            this.Register_Button.Size = new System.Drawing.Size(299, 51);
            this.Register_Button.TabIndex = 12;
            this.Register_Button.Text = "Register";
            this.Register_Button.UseVisualStyleBackColor = false;
            this.Register_Button.Click += new System.EventHandler(this.Register_Button_Click);
            // 
            // Label5
            // 
            this.Label5.AccessibleDescription = "";
            this.Label5.AccessibleName = "";
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Gray;
            this.Label5.Location = new System.Drawing.Point(44, 396);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(148, 21);
            this.Label5.TabIndex = 22;
            this.Label5.Text = "Confirm Password";
            // 
            // Confirm_pas_textbox
            // 
            this.Confirm_pas_textbox.BackColor = System.Drawing.Color.LightGray;
            this.Confirm_pas_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Confirm_pas_textbox.Font = new System.Drawing.Font("Microsoft Tai Le", 13F);
            this.Confirm_pas_textbox.Location = new System.Drawing.Point(50, 430);
            this.Confirm_pas_textbox.Multiline = true;
            this.Confirm_pas_textbox.Name = "Confirm_pas_textbox";
            this.Confirm_pas_textbox.PasswordChar = '*';
            this.Confirm_pas_textbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Confirm_pas_textbox.Size = new System.Drawing.Size(299, 35);
            this.Confirm_pas_textbox.TabIndex = 21;
            this.Confirm_pas_textbox.Text = "1234";
            this.Confirm_pas_textbox.TextChanged += new System.EventHandler(this.confirm_pas_textbox_TextChanged);
            // 
            // Nickname_textbox
            // 
            this.Nickname_textbox.BackColor = System.Drawing.Color.LightGray;
            this.Nickname_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nickname_textbox.Font = new System.Drawing.Font("Microsoft Tai Le", 13F);
            this.Nickname_textbox.Location = new System.Drawing.Point(50, 239);
            this.Nickname_textbox.Multiline = true;
            this.Nickname_textbox.Name = "Nickname_textbox";
            this.Nickname_textbox.Size = new System.Drawing.Size(299, 35);
            this.Nickname_textbox.TabIndex = 24;
            this.Nickname_textbox.Text = "nick";
            this.Nickname_textbox.TextChanged += new System.EventHandler(this.nickname_textbox_TextChanged);
            // 
            // Label6
            // 
            this.Label6.AccessibleDescription = "";
            this.Label6.AccessibleName = "";
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.Label6.ForeColor = System.Drawing.Color.Gray;
            this.Label6.Location = new System.Drawing.Point(46, 211);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(88, 21);
            this.Label6.TabIndex = 23;
            this.Label6.Text = "Nickname";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = "";
            this.label3.AccessibleName = "";
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(108, 641);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Already Have an Account";
            // 
            // Email_label_errors
            // 
            this.Email_label_errors.AutoSize = true;
            this.Email_label_errors.Location = new System.Drawing.Point(52, 97);
            this.Email_label_errors.Name = "Email_label_errors";
            this.Email_label_errors.Size = new System.Drawing.Size(0, 13);
            this.Email_label_errors.TabIndex = 26;
            // 
            // Password_label_errors
            // 
            this.Password_label_errors.AutoSize = true;
            this.Password_label_errors.Location = new System.Drawing.Point(54, 372);
            this.Password_label_errors.Name = "Password_label_errors";
            this.Password_label_errors.Size = new System.Drawing.Size(0, 13);
            this.Password_label_errors.TabIndex = 28;
            // 
            // ConfirmP_label_errors
            // 
            this.ConfirmP_label_errors.AutoSize = true;
            this.ConfirmP_label_errors.Location = new System.Drawing.Point(55, 471);
            this.ConfirmP_label_errors.Name = "ConfirmP_label_errors";
            this.ConfirmP_label_errors.Size = new System.Drawing.Size(0, 13);
            this.ConfirmP_label_errors.TabIndex = 29;
            // 
            // Label4
            // 
            this.Label4.AccessibleDescription = "";
            this.Label4.AccessibleName = "";
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.Label4.ForeColor = System.Drawing.Color.Gray;
            this.Label4.Location = new System.Drawing.Point(45, 119);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(56, 21);
            this.Label4.TabIndex = 30;
            this.Label4.Text = "Name";
            // 
            // Name_textbox
            // 
            this.Name_textbox.BackColor = System.Drawing.Color.LightGray;
            this.Name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name_textbox.Font = new System.Drawing.Font("Microsoft Tai Le", 13F);
            this.Name_textbox.Location = new System.Drawing.Point(50, 147);
            this.Name_textbox.MaxLength = 25;
            this.Name_textbox.Multiline = true;
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(299, 35);
            this.Name_textbox.TabIndex = 31;
            this.Name_textbox.Text = "alumno";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(400, 708);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.ConfirmP_label_errors);
            this.Controls.Add(this.Password_label_errors);
            this.Controls.Add(this.Email_label_errors);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nickname_textbox);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Confirm_pas_textbox);
            this.Controls.Add(this.Email_textbox);
            this.Controls.Add(this.BackToLogin_label);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.Register_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Email_textbox;
        private System.Windows.Forms.Label BackToLogin_label;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox Password_textbox;
        private System.Windows.Forms.Button Register_Button;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.TextBox Confirm_pas_textbox;
        private System.Windows.Forms.TextBox Nickname_textbox;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Email_label_errors;
        private System.Windows.Forms.Label Password_label_errors;
        private System.Windows.Forms.Label ConfirmP_label_errors;
        private System.Windows.Forms.Label Nick_label_errors;
        private Label Label4;
        private TextBox Name_textbox;
    }
}