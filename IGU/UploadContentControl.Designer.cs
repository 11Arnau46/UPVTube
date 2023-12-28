namespace IGU
{
    partial class UploadContentControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadContentControl));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleNum = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionNum = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.urlPanel = new System.Windows.Forms.Panel();
            this.Url = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.añadirSubjectButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.uploadVideoButton = new System.Windows.Forms.Button();
            this.subjectsComboBox = new System.Windows.Forms.ComboBox();
            this.titlePanel.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.urlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.Lavender;
            this.titlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titlePanel.Controls.Add(this.titleNum);
            this.titlePanel.Controls.Add(this.Title);
            this.titlePanel.Controls.Add(this.label10);
            this.titlePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titlePanel.Location = new System.Drawing.Point(20, 57);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1087, 124);
            this.titlePanel.TabIndex = 14;
            this.titlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.titlePanel_Paint);
            // 
            // titleNum
            // 
            this.titleNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.titleNum.BackColor = System.Drawing.SystemColors.Control;
            this.titleNum.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleNum.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.titleNum.Location = new System.Drawing.Point(949, 82);
            this.titleNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleNum.Name = "titleNum";
            this.titleNum.Size = new System.Drawing.Size(111, 27);
            this.titleNum.TabIndex = 16;
            this.titleNum.Text = "0/180";
            this.titleNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleNum.Click += new System.EventHandler(this.textBox_title);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.Control;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(24, 36);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Title.MaxLength = 180;
            this.Title.Multiline = true;
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1041, 73);
            this.Title.TabIndex = 15;
            this.Title.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F);
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(11, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "*Title ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(76, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Video details:";
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.BackColor = System.Drawing.Color.Lavender;
            this.descriptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionPanel.Controls.Add(this.descriptionNum);
            this.descriptionPanel.Controls.Add(this.Description);
            this.descriptionPanel.Controls.Add(this.label3);
            this.descriptionPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.descriptionPanel.Location = new System.Drawing.Point(20, 192);
            this.descriptionPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(1087, 184);
            this.descriptionPanel.TabIndex = 17;
            // 
            // descriptionNum
            // 
            this.descriptionNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.descriptionNum.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionNum.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionNum.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.descriptionNum.Location = new System.Drawing.Point(955, 143);
            this.descriptionNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionNum.Name = "descriptionNum";
            this.descriptionNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.descriptionNum.Size = new System.Drawing.Size(105, 27);
            this.descriptionNum.TabIndex = 16;
            this.descriptionNum.Text = "0/380";
            this.descriptionNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.SystemColors.Control;
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(19, 39);
            this.Description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Description.MaxLength = 380;
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(1047, 129);
            this.Description.TabIndex = 15;
            this.Description.TextChanged += new System.EventHandler(this.Description_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(11, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Description";
            // 
            // urlPanel
            // 
            this.urlPanel.BackColor = System.Drawing.Color.Lavender;
            this.urlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urlPanel.Controls.Add(this.Url);
            this.urlPanel.Controls.Add(this.label5);
            this.urlPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.urlPanel.Location = new System.Drawing.Point(20, 393);
            this.urlPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.urlPanel.Name = "urlPanel";
            this.urlPanel.Size = new System.Drawing.Size(1087, 107);
            this.urlPanel.TabIndex = 17;
            this.urlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Url
            // 
            this.Url.BackColor = System.Drawing.SystemColors.Control;
            this.Url.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Url.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Url.Location = new System.Drawing.Point(24, 44);
            this.Url.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(1041, 26);
            this.Url.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(15, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "*URL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(20, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.subjectsComboBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.añadirSubjectButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(20, 511);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 107);
            this.panel1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(893, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 30);
            this.label8.TabIndex = 26;
            this.label8.Text = "Subject1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(739, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 30);
            this.label7.TabIndex = 25;
            this.label7.Text = "Subject1";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(588, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "Subject1";
            // 
            // añadirSubjectButton
            // 
            this.añadirSubjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.añadirSubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.añadirSubjectButton.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.añadirSubjectButton.ForeColor = System.Drawing.SystemColors.Control;
            this.añadirSubjectButton.Location = new System.Drawing.Point(423, 44);
            this.añadirSubjectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.añadirSubjectButton.Name = "añadirSubjectButton";
            this.añadirSubjectButton.Size = new System.Drawing.Size(60, 39);
            this.añadirSubjectButton.TabIndex = 24;
            this.añadirSubjectButton.Text = "+";
            this.añadirSubjectButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.añadirSubjectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.añadirSubjectButton.UseVisualStyleBackColor = false;
            this.añadirSubjectButton.Click += new System.EventHandler(this.añadirSubjectButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(15, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Subjects";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(65, 649);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "Type of content:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 635);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F);
            this.radioButton1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.radioButton1.Location = new System.Drawing.Point(23, 689);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 33);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Public";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F);
            this.radioButton2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.radioButton2.Location = new System.Drawing.Point(23, 729);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 33);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Private";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // uploadVideoButton
            // 
            this.uploadVideoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.uploadVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadVideoButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadVideoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.uploadVideoButton.Location = new System.Drawing.Point(901, 716);
            this.uploadVideoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uploadVideoButton.Name = "uploadVideoButton";
            this.uploadVideoButton.Size = new System.Drawing.Size(207, 55);
            this.uploadVideoButton.TabIndex = 23;
            this.uploadVideoButton.Text = "Upload Video";
            this.uploadVideoButton.UseVisualStyleBackColor = false;
            this.uploadVideoButton.Click += new System.EventHandler(this.uploadVideoButton_Click);
            // 
            // subjectsComboBox
            // 
            this.subjectsComboBox.FormattingEnabled = true;
            this.subjectsComboBox.Location = new System.Drawing.Point(24, 50);
            this.subjectsComboBox.Name = "subjectsComboBox";
            this.subjectsComboBox.Size = new System.Drawing.Size(355, 24);
            this.subjectsComboBox.TabIndex = 27;
            // 
            // UploadContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uploadVideoButton);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.urlPanel);
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titlePanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UploadContentControl";
            this.Size = new System.Drawing.Size(1133, 800);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            this.urlPanel.ResumeLayout(false);
            this.urlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label titleNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Label descriptionNum;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel urlPanel;
        private System.Windows.Forms.TextBox Url;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button uploadVideoButton;
        private System.Windows.Forms.Button añadirSubjectButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox subjectsComboBox;
    }
}
