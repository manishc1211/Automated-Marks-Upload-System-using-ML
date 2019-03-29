namespace Marks_Upload_System
{
    partial class Upload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upload));
            this.label1 = new System.Windows.Forms.Label();
            this.uploadbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fileadd = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.logoutbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ete = new System.Windows.Forms.RadioButton();
            this.mte = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Label();
            this.namel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Attach Answer Sheet: ";
            // 
            // uploadbutton
            // 
            this.uploadbutton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.uploadbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uploadbutton.BackgroundImage")));
            this.uploadbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploadbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uploadbutton.Location = new System.Drawing.Point(210, 534);
            this.uploadbutton.Name = "uploadbutton";
            this.uploadbutton.Size = new System.Drawing.Size(51, 46);
            this.uploadbutton.TabIndex = 6;
            this.uploadbutton.Text = "\r\n";
            this.toolTip1.SetToolTip(this.uploadbutton, "Select");
            this.uploadbutton.UseVisualStyleBackColor = false;
            this.uploadbutton.Click += new System.EventHandler(this.uploadbutton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(198, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Open";
            this.toolTip1.SetToolTip(this.button2, "Attach answer sheet image");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fileadd
            // 
            this.fileadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileadd.Location = new System.Drawing.Point(132, 365);
            this.fileadd.Multiline = true;
            this.fileadd.Name = "fileadd";
            this.fileadd.Size = new System.Drawing.Size(207, 58);
            this.fileadd.TabIndex = 8;
            this.toolTip1.SetToolTip(this.fileadd, "File Path");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // logoutbutton
            // 
            this.logoutbutton.BackColor = System.Drawing.SystemColors.Control;
            this.logoutbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutbutton.BackgroundImage")));
            this.logoutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoutbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logoutbutton.Location = new System.Drawing.Point(424, 602);
            this.logoutbutton.Margin = new System.Windows.Forms.Padding(0);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.logoutbutton.Size = new System.Drawing.Size(35, 35);
            this.logoutbutton.TabIndex = 11;
            this.logoutbutton.Text = "\r\n";
            this.toolTip1.SetToolTip(this.logoutbutton, "Logout");
            this.logoutbutton.UseVisualStyleBackColor = false;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "File Path:";
            // 
            // ete
            // 
            this.ete.AutoSize = true;
            this.ete.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ete.Location = new System.Drawing.Point(182, 474);
            this.ete.Name = "ete";
            this.ete.Size = new System.Drawing.Size(49, 23);
            this.ete.TabIndex = 12;
            this.ete.TabStop = true;
            this.ete.Text = "ETE";
            this.ete.UseVisualStyleBackColor = true;
            // 
            // mte
            // 
            this.mte.AutoSize = true;
            this.mte.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mte.Location = new System.Drawing.Point(244, 474);
            this.mte.Name = "mte";
            this.mte.Size = new System.Drawing.Size(55, 23);
            this.mte.TabIndex = 13;
            this.mte.TabStop = true;
            this.mte.Text = "MTE";
            this.mte.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Exam Type:";
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(13, 624);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(89, 16);
            this.log.TabIndex = 15;
            this.log.Text = "Logged in as:";
            // 
            // namel
            // 
            this.namel.AutoSize = true;
            this.namel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namel.Location = new System.Drawing.Point(97, 624);
            this.namel.Name = "namel";
            this.namel.Size = new System.Drawing.Size(26, 16);
            this.namel.TabIndex = 16;
            this.namel.Text = "xxx";
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(471, 649);
            this.Controls.Add(this.namel);
            this.Controls.Add(this.log);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mte);
            this.Controls.Add(this.ete);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fileadd);
            this.Controls.Add(this.uploadbutton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Upload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload";
            this.Load += new System.EventHandler(this.Upload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uploadbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox fileadd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.RadioButton ete;
        private System.Windows.Forms.RadioButton mte;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label log;
        public System.Windows.Forms.Label namel;
    }
}