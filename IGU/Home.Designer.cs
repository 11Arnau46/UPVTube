using UPVTube.Services;

namespace IGU
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nickname = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.evaluate_content = new System.Windows.Forms.Button();
            this.upload_content = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.videos = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.imageList5 = new System.Windows.Forms.ImageList(this.components);
            this.evaluateContentControl1 = new IGU.EvaluateContentControl();
            this.historyControl1 = new IGU.HistoryControl();
            this.uploadContentControl1 = new IGU.UploadContentControl(service);
            this.videosControl1 = new IGU.VideosControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.nickname);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.evaluate_content);
            this.panel1.Controls.Add(this.upload_content);
            this.panel1.Controls.Add(this.history);
            this.panel1.Controls.Add(this.videos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 682);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 166);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 79);
            this.SidePanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // nickname
            // 
            this.nickname.AutoSize = true;
            this.nickname.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.nickname.ForeColor = System.Drawing.Color.White;
            this.nickname.Location = new System.Drawing.Point(23, 99);
            this.nickname.MaximumSize = new System.Drawing.Size(112, 70);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(0, 16);
            this.nickname.TabIndex = 7;
            this.nickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nickname.Click += new System.EventHandler(this.label1_Click);
            // 
            // logout
            // 
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logout.Location = new System.Drawing.Point(14, 575);
            this.logout.Margin = new System.Windows.Forms.Padding(0);
            this.logout.Name = "logout";
            this.logout.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.logout.Size = new System.Drawing.Size(114, 87);
            this.logout.TabIndex = 6;
            this.logout.Text = "Logout";
            this.logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // evaluate_content
            // 
            this.evaluate_content.FlatAppearance.BorderSize = 0;
            this.evaluate_content.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.evaluate_content.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluate_content.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.evaluate_content.Image = ((System.Drawing.Image)(resources.GetObject("evaluate_content.Image")));
            this.evaluate_content.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.evaluate_content.Location = new System.Drawing.Point(13, 451);
            this.evaluate_content.Margin = new System.Windows.Forms.Padding(0);
            this.evaluate_content.Name = "evaluate_content";
            this.evaluate_content.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.evaluate_content.Size = new System.Drawing.Size(116, 97);
            this.evaluate_content.TabIndex = 4;
            this.evaluate_content.Text = "Evaluate Content";
            this.evaluate_content.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.evaluate_content.UseVisualStyleBackColor = true;
            this.evaluate_content.Click += new System.EventHandler(this.evaluate_content_button);
            // 
            // upload_content
            // 
            this.upload_content.FlatAppearance.BorderSize = 0;
            this.upload_content.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload_content.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_content.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.upload_content.Image = ((System.Drawing.Image)(resources.GetObject("upload_content.Image")));
            this.upload_content.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.upload_content.Location = new System.Drawing.Point(14, 346);
            this.upload_content.Margin = new System.Windows.Forms.Padding(0);
            this.upload_content.Name = "upload_content";
            this.upload_content.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.upload_content.Size = new System.Drawing.Size(113, 95);
            this.upload_content.TabIndex = 3;
            this.upload_content.Text = "Upload Content";
            this.upload_content.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.upload_content.UseVisualStyleBackColor = true;
            this.upload_content.Click += new System.EventHandler(this.upload_content_Click);
            // 
            // history
            // 
            this.history.FlatAppearance.BorderSize = 0;
            this.history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.history.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.history.Image = ((System.Drawing.Image)(resources.GetObject("history.Image")));
            this.history.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.history.Location = new System.Drawing.Point(14, 256);
            this.history.Margin = new System.Windows.Forms.Padding(0);
            this.history.Name = "history";
            this.history.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.history.Size = new System.Drawing.Size(116, 79);
            this.history.TabIndex = 2;
            this.history.Text = "History";
            this.history.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_button);
            // 
            // videos
            // 
            this.videos.FlatAppearance.BorderSize = 0;
            this.videos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videos.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.videos.Image = ((System.Drawing.Image)(resources.GetObject("videos.Image")));
            this.videos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.videos.Location = new System.Drawing.Point(14, 166);
            this.videos.Margin = new System.Windows.Forms.Padding(0);
            this.videos.Name = "videos";
            this.videos.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.videos.Size = new System.Drawing.Size(116, 79);
            this.videos.TabIndex = 1;
            this.videos.Text = "Videos";
            this.videos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.videos.UseVisualStyleBackColor = true;
            this.videos.Click += new System.EventHandler(this.videos_button);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList4
            // 
            this.imageList4.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList4.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList5
            // 
            this.imageList5.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList5.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList5.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // evaluateContentControl1
            // 
            this.evaluateContentControl1.Location = new System.Drawing.Point(144, 20);
            this.evaluateContentControl1.Name = "evaluateContentControl1";
            this.evaluateContentControl1.Size = new System.Drawing.Size(850, 650);
            this.evaluateContentControl1.TabIndex = 6;
            // 
            // historyControl1
            // 
            this.historyControl1.Location = new System.Drawing.Point(153, 20);
            this.historyControl1.Name = "historyControl1";
            this.historyControl1.Size = new System.Drawing.Size(850, 650);
            this.historyControl1.TabIndex = 5;
            // 
            // uploadContentControl1
            // 
            this.uploadContentControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uploadContentControl1.Location = new System.Drawing.Point(153, 20);
            this.uploadContentControl1.Name = "uploadContentControl1";
            this.uploadContentControl1.Size = new System.Drawing.Size(850, 650);
            this.uploadContentControl1.TabIndex = 4;
            // 
            // videosControl1
            // 
            this.videosControl1.Location = new System.Drawing.Point(144, 12);
            this.videosControl1.Margin = new System.Windows.Forms.Padding(4);
            this.videosControl1.Name = "videosControl1";
            this.videosControl1.Padding = new System.Windows.Forms.Padding(20);
            this.videosControl1.Size = new System.Drawing.Size(850, 650);
            this.videosControl1.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1015, 682);
            this.Controls.Add(this.evaluateContentControl1);
            this.Controls.Add(this.historyControl1);
            this.Controls.Add(this.uploadContentControl1);
            this.Controls.Add(this.videosControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPVTube";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button videos;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button evaluate_content;
        private System.Windows.Forms.Button upload_content;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Label nickname;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList4;
        private System.Windows.Forms.ImageList imageList5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private VideosControl videosControl1;
        private System.Windows.Forms.Panel SidePanel;
        private UploadContentControl uploadContentControl1;
        private HistoryControl historyControl1;
        private EvaluateContentControl evaluateContentControl1;
    }
}