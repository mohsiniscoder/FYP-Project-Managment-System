namespace Project_Salvation.UI
{
    partial class uc_delete_groups
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_delete_groups));
            this.id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_group = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Animated = true;
            this.id.BorderRadius = 15;
            this.id.BorderThickness = 3;
            this.id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id.DefaultText = "";
            this.id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id.Location = new System.Drawing.Point(63, 75);
            this.id.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.id.Name = "id";
            this.id.PasswordChar = '\0';
            this.id.PlaceholderText = "";
            this.id.SelectedText = "";
            this.id.Size = new System.Drawing.Size(295, 53);
            this.id.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(67, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 42);
            this.label1.TabIndex = 36;
            this.label1.Text = "Group ID";
            // 
            // delete_group
            // 
            this.delete_group.Animated = true;
            this.delete_group.BorderRadius = 20;
            this.delete_group.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_group.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_group.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_group.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_group.FillColor = System.Drawing.Color.Red;
            this.delete_group.Font = new System.Drawing.Font("Verdana", 17.75F, System.Drawing.FontStyle.Bold);
            this.delete_group.ForeColor = System.Drawing.Color.White;
            this.delete_group.Location = new System.Drawing.Point(379, 69);
            this.delete_group.Name = "delete_group";
            this.delete_group.Size = new System.Drawing.Size(226, 58);
            this.delete_group.TabIndex = 37;
            this.delete_group.Text = "Delete Group";
            this.delete_group.Click += new System.EventHandler(this.delete_group_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(573, 41);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(164, 85);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 38;
            this.guna2PictureBox1.TabStop = false;
            // 
            // uc_delete_groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delete_group);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "uc_delete_groups";
            this.Size = new System.Drawing.Size(752, 426);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox id;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button delete_group;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
