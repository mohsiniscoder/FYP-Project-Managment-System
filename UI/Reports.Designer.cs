namespace Project_Salvation.UI
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.report_options = new Guna.UI2.WinForms.Guna2ComboBox();
            this.back_button = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mango_button = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.generate_report_button = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // report_options
            // 
            this.report_options.BackColor = System.Drawing.Color.Transparent;
            this.report_options.BorderColor = System.Drawing.Color.White;
            this.report_options.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.report_options.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.report_options.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.report_options.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.report_options.Font = new System.Drawing.Font("Yu Gothic", 32F);
            this.report_options.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.report_options.ItemHeight = 30;
            this.report_options.Items.AddRange(new object[] {
            "Generate Student Result"});
            this.report_options.Location = new System.Drawing.Point(119, 138);
            this.report_options.Name = "report_options";
            this.report_options.Size = new System.Drawing.Size(299, 36);
            this.report_options.TabIndex = 0;
            this.report_options.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // back_button
            // 
            this.back_button.Image = ((System.Drawing.Image)(resources.GetObject("back_button.Image")));
            this.back_button.ImageRotate = 0F;
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(84, 77);
            this.back_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_button.TabIndex = 59;
            this.back_button.TabStop = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // mango_button
            // 
            this.mango_button.Animated = true;
            this.mango_button.BorderColor = System.Drawing.Color.Yellow;
            this.mango_button.BorderThickness = 10;
            this.mango_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.mango_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.mango_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.mango_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.mango_button.FillColor = System.Drawing.Color.Transparent;
            this.mango_button.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.mango_button.ForeColor = System.Drawing.Color.Black;
            this.mango_button.Location = new System.Drawing.Point(163, 11);
            this.mango_button.Name = "mango_button";
            this.mango_button.Size = new System.Drawing.Size(240, 78);
            this.mango_button.TabIndex = 61;
            this.mango_button.Text = "MANGO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(646, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(615, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(384, 43);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(441, 270);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 64;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // generate_report_button
            // 
            this.generate_report_button.Animated = true;
            this.generate_report_button.BackColor = System.Drawing.Color.Transparent;
            this.generate_report_button.BorderRadius = 10;
            this.generate_report_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generate_report_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generate_report_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generate_report_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generate_report_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.generate_report_button.Font = new System.Drawing.Font("Yu Gothic", 20.5F, System.Drawing.FontStyle.Bold);
            this.generate_report_button.ForeColor = System.Drawing.Color.White;
            this.generate_report_button.Location = new System.Drawing.Point(119, 186);
            this.generate_report_button.Name = "generate_report_button";
            this.generate_report_button.PressedColor = System.Drawing.Color.Red;
            this.generate_report_button.Size = new System.Drawing.Size(299, 60);
            this.generate_report_button.TabIndex = 65;
            this.generate_report_button.Text = "Generate Report";
            this.generate_report_button.Click += new System.EventHandler(this.add_students2_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(119, 245);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(224, 147);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 66;
            this.guna2PictureBox2.TabStop = false;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generate_report_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mango_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.report_options);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2PictureBox2);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox report_options;
        private Guna.UI2.WinForms.Guna2PictureBox back_button;
        private Guna.UI2.WinForms.Guna2Button mango_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button generate_report_button;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}