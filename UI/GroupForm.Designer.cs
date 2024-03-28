namespace Project_Salvation.UI
{
    partial class GroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.group_panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.group_control_panel = new System.Windows.Forms.Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.add_group2 = new Guna.UI2.WinForms.Guna2Button();
            this.back_button = new Guna.UI2.WinForms.Guna2PictureBox();
            this.add_student_to_group2 = new Guna.UI2.WinForms.Guna2Button();
            this.group_project2 = new Guna.UI2.WinForms.Guna2Button();
            this.delete_groups2 = new Guna.UI2.WinForms.Guna2Button();
            this.mango_button = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.group_control_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mango_button);
            this.panel1.Controls.Add(this.delete_groups2);
            this.panel1.Controls.Add(this.group_project2);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.add_student_to_group2);
            this.panel1.Controls.Add(this.add_group2);
            this.panel1.Controls.Add(this.guna2PictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 482);
            this.panel1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(782, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mohsin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(752, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // group_panel
            // 
            this.group_panel.BackColor = System.Drawing.Color.Transparent;
            this.group_panel.BaseColor = System.Drawing.Color.White;
            this.group_panel.Location = new System.Drawing.Point(233, 38);
            this.group_panel.Name = "group_panel";
            this.group_panel.Radius = 30;
            this.group_panel.Size = new System.Drawing.Size(752, 426);
            this.group_panel.TabIndex = 1;
            // 
            // group_control_panel
            // 
            this.group_control_panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.group_control_panel.Controls.Add(this.label1);
            this.group_control_panel.Controls.Add(this.group_panel);
            this.group_control_panel.Controls.Add(this.pictureBox1);
            this.group_control_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_control_panel.Location = new System.Drawing.Point(0, 0);
            this.group_control_panel.Name = "group_control_panel";
            this.group_control_panel.Size = new System.Drawing.Size(995, 482);
            this.group_control_panel.TabIndex = 42;
            this.group_control_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.group_control_panel_Paint);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(-37, -15);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(322, 231);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // add_group2
            // 
            this.add_group2.Animated = true;
            this.add_group2.BackColor = System.Drawing.Color.Transparent;
            this.add_group2.BorderRadius = 10;
            this.add_group2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_group2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_group2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_group2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_group2.FillColor = System.Drawing.Color.Yellow;
            this.add_group2.Font = new System.Drawing.Font("Yu Gothic", 18.5F, System.Drawing.FontStyle.Bold);
            this.add_group2.ForeColor = System.Drawing.Color.Black;
            this.add_group2.Location = new System.Drawing.Point(4, 160);
            this.add_group2.Name = "add_group2";
            this.add_group2.PressedColor = System.Drawing.Color.Red;
            this.add_group2.Size = new System.Drawing.Size(219, 56);
            this.add_group2.TabIndex = 53;
            this.add_group2.Text = "Add Or View";
            this.add_group2.Click += new System.EventHandler(this.add_group2_Click);
            // 
            // back_button
            // 
            this.back_button.Image = ((System.Drawing.Image)(resources.GetObject("back_button.Image")));
            this.back_button.ImageRotate = 0F;
            this.back_button.Location = new System.Drawing.Point(-3, 9);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(55, 49);
            this.back_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_button.TabIndex = 58;
            this.back_button.TabStop = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // add_student_to_group2
            // 
            this.add_student_to_group2.Animated = true;
            this.add_student_to_group2.BackColor = System.Drawing.Color.Transparent;
            this.add_student_to_group2.BorderRadius = 10;
            this.add_student_to_group2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_student_to_group2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_student_to_group2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_student_to_group2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_student_to_group2.FillColor = System.Drawing.Color.Magenta;
            this.add_student_to_group2.Font = new System.Drawing.Font("Yu Gothic", 18.5F, System.Drawing.FontStyle.Bold);
            this.add_student_to_group2.ForeColor = System.Drawing.Color.White;
            this.add_student_to_group2.Location = new System.Drawing.Point(3, 222);
            this.add_student_to_group2.Name = "add_student_to_group2";
            this.add_student_to_group2.PressedColor = System.Drawing.Color.Red;
            this.add_student_to_group2.Size = new System.Drawing.Size(221, 55);
            this.add_student_to_group2.TabIndex = 54;
            this.add_student_to_group2.Text = "Add to Group";
            this.add_student_to_group2.Click += new System.EventHandler(this.add_student_to_group2_Click);
            // 
            // group_project2
            // 
            this.group_project2.Animated = true;
            this.group_project2.BackColor = System.Drawing.Color.Transparent;
            this.group_project2.BorderRadius = 10;
            this.group_project2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.group_project2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.group_project2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.group_project2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.group_project2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.group_project2.Font = new System.Drawing.Font("Yu Gothic", 18.5F, System.Drawing.FontStyle.Bold);
            this.group_project2.ForeColor = System.Drawing.Color.White;
            this.group_project2.Location = new System.Drawing.Point(3, 283);
            this.group_project2.Name = "group_project2";
            this.group_project2.PressedColor = System.Drawing.Color.Red;
            this.group_project2.Size = new System.Drawing.Size(222, 55);
            this.group_project2.TabIndex = 55;
            this.group_project2.Text = "Assign Project";
            this.group_project2.Click += new System.EventHandler(this.group_project2_Click);
            // 
            // delete_groups2
            // 
            this.delete_groups2.Animated = true;
            this.delete_groups2.BackColor = System.Drawing.Color.Transparent;
            this.delete_groups2.BorderRadius = 10;
            this.delete_groups2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_groups2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_groups2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_groups2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_groups2.FillColor = System.Drawing.Color.Red;
            this.delete_groups2.Font = new System.Drawing.Font("Yu Gothic", 18.5F, System.Drawing.FontStyle.Bold);
            this.delete_groups2.ForeColor = System.Drawing.Color.White;
            this.delete_groups2.Location = new System.Drawing.Point(3, 343);
            this.delete_groups2.Name = "delete_groups2";
            this.delete_groups2.PressedColor = System.Drawing.Color.Red;
            this.delete_groups2.Size = new System.Drawing.Size(222, 55);
            this.delete_groups2.TabIndex = 59;
            this.delete_groups2.Text = "Delete Groups";
            this.delete_groups2.Click += new System.EventHandler(this.delete_groups2_Click);
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
            this.mango_button.Location = new System.Drawing.Point(11, 405);
            this.mango_button.Name = "mango_button";
            this.mango_button.Size = new System.Drawing.Size(209, 69);
            this.mango_button.TabIndex = 1;
            this.mango_button.Text = "MANGO";
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.group_control_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.group_control_panel.ResumeLayout(false);
            this.group_control_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel group_control_panel;
        private Guna.UI.WinForms.GunaElipsePanel group_panel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Button add_group2;
        private Guna.UI2.WinForms.Guna2PictureBox back_button;
        private Guna.UI2.WinForms.Guna2Button add_student_to_group2;
        private Guna.UI2.WinForms.Guna2Button group_project2;
        private Guna.UI2.WinForms.Guna2Button delete_groups2;
        private Guna.UI2.WinForms.Guna2Button mango_button;
    }
}