namespace Project_Salvation.UI
{
    partial class ProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mango_button = new Guna.UI2.WinForms.Guna2Button();
            this.edit_project = new Guna.UI2.WinForms.Guna2Button();
            this.back_button = new Guna.UI2.WinForms.Guna2PictureBox();
            this.delete_projects2 = new Guna.UI2.WinForms.Guna2Button();
            this.add_projects2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.project_control_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mango_button);
            this.panel1.Controls.Add(this.edit_project);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.delete_projects2);
            this.panel1.Controls.Add(this.add_projects2);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 484);
            this.panel1.TabIndex = 39;
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
            this.mango_button.Location = new System.Drawing.Point(7, 384);
            this.mango_button.Name = "mango_button";
            this.mango_button.Size = new System.Drawing.Size(209, 69);
            this.mango_button.TabIndex = 59;
            this.mango_button.Text = "MANGO";
            // 
            // edit_project
            // 
            this.edit_project.Animated = true;
            this.edit_project.BackColor = System.Drawing.Color.Transparent;
            this.edit_project.BorderRadius = 10;
            this.edit_project.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.edit_project.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.edit_project.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.edit_project.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.edit_project.FillColor = System.Drawing.Color.Magenta;
            this.edit_project.Font = new System.Drawing.Font("Yu Gothic", 17.5F, System.Drawing.FontStyle.Bold);
            this.edit_project.ForeColor = System.Drawing.Color.White;
            this.edit_project.Location = new System.Drawing.Point(4, 311);
            this.edit_project.Name = "edit_project";
            this.edit_project.PressedColor = System.Drawing.Color.Red;
            this.edit_project.Size = new System.Drawing.Size(219, 57);
            this.edit_project.TabIndex = 58;
            this.edit_project.Text = "Update Project";
            this.edit_project.Click += new System.EventHandler(this.edit_project_Click);
            // 
            // back_button
            // 
            this.back_button.Image = ((System.Drawing.Image)(resources.GetObject("back_button.Image")));
            this.back_button.ImageRotate = 0F;
            this.back_button.Location = new System.Drawing.Point(3, 1);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(51, 46);
            this.back_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_button.TabIndex = 0;
            this.back_button.TabStop = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // delete_projects2
            // 
            this.delete_projects2.Animated = true;
            this.delete_projects2.BackColor = System.Drawing.Color.Transparent;
            this.delete_projects2.BorderRadius = 10;
            this.delete_projects2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_projects2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_projects2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_projects2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_projects2.FillColor = System.Drawing.Color.Red;
            this.delete_projects2.Font = new System.Drawing.Font("Yu Gothic", 17.5F, System.Drawing.FontStyle.Bold);
            this.delete_projects2.ForeColor = System.Drawing.Color.White;
            this.delete_projects2.Location = new System.Drawing.Point(7, 250);
            this.delete_projects2.Name = "delete_projects2";
            this.delete_projects2.PressedColor = System.Drawing.Color.Red;
            this.delete_projects2.Size = new System.Drawing.Size(214, 55);
            this.delete_projects2.TabIndex = 57;
            this.delete_projects2.Text = "Delete Projects";
            this.delete_projects2.Click += new System.EventHandler(this.delete_projects2_Click);
            // 
            // add_projects2
            // 
            this.add_projects2.Animated = true;
            this.add_projects2.BackColor = System.Drawing.Color.Transparent;
            this.add_projects2.BorderRadius = 10;
            this.add_projects2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_projects2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_projects2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_projects2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_projects2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.add_projects2.Font = new System.Drawing.Font("Yu Gothic", 18.5F, System.Drawing.FontStyle.Bold);
            this.add_projects2.ForeColor = System.Drawing.Color.White;
            this.add_projects2.Location = new System.Drawing.Point(6, 188);
            this.add_projects2.Name = "add_projects2";
            this.add_projects2.PressedColor = System.Drawing.Color.Red;
            this.add_projects2.Size = new System.Drawing.Size(214, 56);
            this.add_projects2.TabIndex = 56;
            this.add_projects2.Text = "Add Projects";
            this.add_projects2.Click += new System.EventHandler(this.add_projects2_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(22, 14);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(198, 149);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(767, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mohsin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(727, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // project_control_panel
            // 
            this.project_control_panel.BackColor = System.Drawing.Color.Transparent;
            this.project_control_panel.FillColor = System.Drawing.Color.White;
            this.project_control_panel.Location = new System.Drawing.Point(243, 41);
            this.project_control_panel.Name = "project_control_panel";
            this.project_control_panel.ShadowColor = System.Drawing.Color.Black;
            this.project_control_panel.Size = new System.Drawing.Size(717, 426);
            this.project_control_panel.TabIndex = 40;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 484);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.project_control_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectForm";
            this.Text = "ProjectForm";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ShadowPanel project_control_panel;
        private Guna.UI2.WinForms.Guna2PictureBox back_button;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button edit_project;
        private Guna.UI2.WinForms.Guna2Button delete_projects2;
        private Guna.UI2.WinForms.Guna2Button add_projects2;
        private Guna.UI2.WinForms.Guna2Button mango_button;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}