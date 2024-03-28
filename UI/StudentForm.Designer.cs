namespace Project_Salvation.UI
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_button = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.student_panel = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.add_students2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.update_students2 = new Guna.UI2.WinForms.Guna2Button();
            this.delete_student_button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mango_button = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mango_button);
            this.panel1.Controls.Add(this.delete_student_button2);
            this.panel1.Controls.Add(this.update_students2);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.add_students2);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 473);
            this.panel1.TabIndex = 0;
            // 
            // back_button
            // 
            this.back_button.Image = ((System.Drawing.Image)(resources.GetObject("back_button.Image")));
            this.back_button.ImageRotate = 0F;
            this.back_button.Location = new System.Drawing.Point(3, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(51, 46);
            this.back_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_button.TabIndex = 1;
            this.back_button.TabStop = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(739, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // student_panel
            // 
            this.student_panel.Location = new System.Drawing.Point(245, 37);
            this.student_panel.Name = "student_panel";
            this.student_panel.Size = new System.Drawing.Size(704, 423);
            this.student_panel.TabIndex = 27;
            this.student_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.student_panel_Paint);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 19;
            this.guna2Elipse2.TargetControl = this.student_panel;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(772, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mohsin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // add_students2
            // 
            this.add_students2.Animated = true;
            this.add_students2.BackColor = System.Drawing.Color.Transparent;
            this.add_students2.BorderRadius = 10;
            this.add_students2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_students2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_students2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_students2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_students2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.add_students2.Font = new System.Drawing.Font("Yu Gothic", 18.5F, System.Drawing.FontStyle.Bold);
            this.add_students2.ForeColor = System.Drawing.Color.White;
            this.add_students2.Location = new System.Drawing.Point(11, 129);
            this.add_students2.Name = "add_students2";
            this.add_students2.PressedColor = System.Drawing.Color.Red;
            this.add_students2.Size = new System.Drawing.Size(226, 55);
            this.add_students2.TabIndex = 48;
            this.add_students2.Text = "Add Students";
            this.add_students2.Click += new System.EventHandler(this.add_students2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.guna2Button1.Font = new System.Drawing.Font("Yu Gothic", 18.7F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(10, 190);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Red;
            this.guna2Button1.Size = new System.Drawing.Size(226, 56);
            this.guna2Button1.TabIndex = 49;
            this.guna2Button1.Text = "View Students";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // update_students2
            // 
            this.update_students2.Animated = true;
            this.update_students2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.update_students2.BorderRadius = 10;
            this.update_students2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update_students2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update_students2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update_students2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update_students2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.update_students2.Font = new System.Drawing.Font("Yu Gothic", 18.7F, System.Drawing.FontStyle.Bold);
            this.update_students2.ForeColor = System.Drawing.Color.White;
            this.update_students2.Location = new System.Drawing.Point(10, 252);
            this.update_students2.Name = "update_students2";
            this.update_students2.PressedColor = System.Drawing.Color.Red;
            this.update_students2.Size = new System.Drawing.Size(226, 57);
            this.update_students2.TabIndex = 50;
            this.update_students2.Text = "Edit Students";
            this.update_students2.Click += new System.EventHandler(this.update_students2_Click);
            // 
            // delete_student_button2
            // 
            this.delete_student_button2.Animated = true;
            this.delete_student_button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.delete_student_button2.BorderRadius = 10;
            this.delete_student_button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_student_button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_student_button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_student_button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_student_button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.delete_student_button2.Font = new System.Drawing.Font("Yu Gothic", 18.5F, System.Drawing.FontStyle.Bold);
            this.delete_student_button2.ForeColor = System.Drawing.Color.White;
            this.delete_student_button2.Location = new System.Drawing.Point(11, 315);
            this.delete_student_button2.Name = "delete_student_button2";
            this.delete_student_button2.PressedColor = System.Drawing.Color.Red;
            this.delete_student_button2.Size = new System.Drawing.Size(225, 54);
            this.delete_student_button2.TabIndex = 51;
            this.delete_student_button2.Text = "Erase Students";
            this.delete_student_button2.Click += new System.EventHandler(this.delete_student_button2_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(13, -5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(202, 147);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
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
            this.mango_button.Location = new System.Drawing.Point(19, 378);
            this.mango_button.Name = "mango_button";
            this.mango_button.Size = new System.Drawing.Size(209, 69);
            this.mango_button.TabIndex = 0;
            this.mango_button.Text = "MANGO";
            this.mango_button.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 473);
            this.Controls.Add(this.student_panel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel student_panel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox back_button;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button add_students2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button update_students2;
        private Guna.UI2.WinForms.Guna2Button delete_student_button2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button mango_button;
    }
}