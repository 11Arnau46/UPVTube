using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace IGU
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Password_Text = new System.Windows.Forms.Label();
            this.Nick_Text = new System.Windows.Forms.Label();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.Create_label = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.User_textbox = new System.Windows.Forms.TextBox();
            this.Nick_Error_Label = new System.Windows.Forms.Label();
            this.Password_Error_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CheckBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.CheckBox1.ForeColor = System.Drawing.Color.Gray;
            this.CheckBox1.Location = new System.Drawing.Point(205, 237);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(131, 22);
            this.CheckBox1.TabIndex = 16;
            this.CheckBox1.Text = "Show Password";
            this.CheckBox1.UseVisualStyleBackColor = false;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Password_Text
            // 
            this.Password_Text.AccessibleDescription = "";
            this.Password_Text.AccessibleName = "";
            this.Password_Text.AutoSize = true;
            this.Password_Text.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Password_Text.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Text.ForeColor = System.Drawing.Color.Gray;
            this.Password_Text.Location = new System.Drawing.Point(56, 143);
            this.Password_Text.Name = "Password_Text";
            this.Password_Text.Size = new System.Drawing.Size(82, 21);
            this.Password_Text.TabIndex = 15;
            this.Password_Text.Text = "Password";
            // 
            // Nick_Text
            // 
            this.Nick_Text.AccessibleDescription = "";
            this.Nick_Text.AccessibleName = "";
            this.Nick_Text.AutoSize = true;
            this.Nick_Text.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nick_Text.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nick_Text.ForeColor = System.Drawing.Color.Gray;
            this.Nick_Text.Location = new System.Drawing.Point(56, 49);
            this.Nick_Text.Name = "Nick_Text";
            this.Nick_Text.Size = new System.Drawing.Size(152, 21);
            this.Nick_Text.TabIndex = 14;
            this.Nick_Text.Text = "Email or nickname";
            // 
            // Password_textbox
            // 
            this.Password_textbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Password_textbox.BackColor = System.Drawing.Color.LightGray;
            this.Password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_textbox.Font = new System.Drawing.Font("Microsoft Tai Le", 22F);
            this.Password_textbox.Location = new System.Drawing.Point(60, 166);
            this.Password_textbox.Margin = new System.Windows.Forms.Padding(5, 3, 3, 5);
            this.Password_textbox.Multiline = true;
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.PasswordChar = '*';
            this.Password_textbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Password_textbox.Size = new System.Drawing.Size(276, 39);
            this.Password_textbox.TabIndex = 13;
            this.Password_textbox.TextChanged += new System.EventHandler(this.Password_TextBox_TextChanged);

            // 
            // User_textbox
            // 

            this.User_textbox.BackColor = System.Drawing.Color.LightGray;
            this.User_textbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.User_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User_textbox.Font = new System.Drawing.Font("Microsoft Tai Le", 22F);
            this.User_textbox.Location = new System.Drawing.Point(60, 72);
            this.User_textbox.Margin = new System.Windows.Forms.Padding(5, 3, 3, 5); // Left padding
            this.User_textbox.Multiline = true; // Set to single-line
            this.User_textbox.Name = "User_textbox";
            this.User_textbox.Size = new System.Drawing.Size(276, 39);
            this.User_textbox.TabIndex = 20;
            this.User_textbox.TextChanged += new System.EventHandler(this.Nick_TextBox_TextChanged);

            // 
            // Create_label
            // 
            this.Create_label.AccessibleDescription = "";
            this.Create_label.AccessibleName = "";
            this.Create_label.AllowDrop = true;
            this.Create_label.AutoSize = true;
            this.Create_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create_label.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.Create_label.ForeColor = System.Drawing.Color.SlateBlue;
            this.Create_label.Location = new System.Drawing.Point(144, 395);
            this.Create_label.Name = "Create_label";
            this.Create_label.Size = new System.Drawing.Size(110, 18);
            this.Create_label.TabIndex = 22;
            this.Create_label.Text = "Create Account";
            this.Create_label.Click += new System.EventHandler(this.Register_Label_Click);
            // 
            // Label1
            // 
            this.Label1.AccessibleDescription = "";
            this.Label1.AccessibleName = "";
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.Gray;
            this.Label1.Location = new System.Drawing.Point(116, 376);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(162, 19);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "Don\'t Have an Account";
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.SlateBlue;
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.ForeColor = System.Drawing.Color.GhostWhite;
            this.Login_button.Location = new System.Drawing.Point(60, 274);
            this.Login_button.Margin = new System.Windows.Forms.Padding(2);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(276, 56);
            this.Login_button.TabIndex = 24;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);


            
            // 
            // Nick_Error_Label
            // 
            this.Nick_Error_Label.AutoSize = true;
            this.Nick_Error_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Nick_Error_Label.ForeColor = System.Drawing.Color.Crimson;
            this.Nick_Error_Label.Location = new System.Drawing.Point(60, 120);
            this.Nick_Error_Label.Name = "Nick_Error_Label";
            this.Nick_Error_Label.Size = new System.Drawing.Size(0, 18);
            this.Nick_Error_Label.TabIndex = 27;
            this.Nick_Error_Label.Tag = "Nick_Error_Label";
            this.Nick_Error_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password_Error_Label
            // 
            this.Password_Error_Label.AutoSize = true;
            this.Password_Error_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Password_Error_Label.ForeColor = System.Drawing.Color.Crimson;
            this.Password_Error_Label.Location = new System.Drawing.Point(60, 214);
            this.Password_Error_Label.Name = "Password_Error_Label";
            this.Password_Error_Label.Size = new System.Drawing.Size(0, 18);
            this.Password_Error_Label.TabIndex = 28;
            this.Password_Error_Label.Tag = "Password_Error_Label";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(395, 432);
            this.Controls.Add(this.Password_Error_Label);
            this.Controls.Add(this.Nick_Error_Label);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Create_label);
            this.Controls.Add(this.User_textbox);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.Password_Text);
            this.Controls.Add(this.Nick_Text);
            this.Controls.Add(this.Password_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Nick;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.Label Password_Text;
        private System.Windows.Forms.Label Nick_Text;
        private System.Windows.Forms.TextBox Password_textbox;
        private System.Windows.Forms.Label Create_label;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.TextBox User_textbox;
        private System.Windows.Forms.Label Nick_Error_Label;
        private System.Windows.Forms.Label Password_Error_Label;
    }
}