namespace Project_Salvation.UI
{
    partial class uc_project_advisor_add
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_project_advisor_add));
            this.role = new Guna.UI2.WinForms.Guna2ComboBox();
            this.project_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.advisor_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.add_project_advisor = new Guna.UI2.WinForms.Guna2Button();
            this.project_advisor_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.display_project_advisor_button = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.project_advisor_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // role
            // 
            this.role.BackColor = System.Drawing.Color.Transparent;
            this.role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.role.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.role.Font = new System.Drawing.Font("Verdana", 12.25F);
            this.role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.role.ItemHeight = 30;
            this.role.Items.AddRange(new object[] {
            "Industry Professional",
            "Main Advisor",
            "Co-Advisor",
            "Industry Advisor"});
            this.role.Location = new System.Drawing.Point(486, 37);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(213, 36);
            this.role.TabIndex = 8;
            // 
            // project_id
            // 
            this.project_id.BorderRadius = 15;
            this.project_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.project_id.DefaultText = "";
            this.project_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.project_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.project_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.project_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.project_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.project_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.project_id.Location = new System.Drawing.Point(255, 37);
            this.project_id.Name = "project_id";
            this.project_id.PasswordChar = '\0';
            this.project_id.PlaceholderText = "";
            this.project_id.SelectedText = "";
            this.project_id.Size = new System.Drawing.Size(209, 36);
            this.project_id.TabIndex = 7;
            // 
            // advisor_id
            // 
            this.advisor_id.BorderRadius = 15;
            this.advisor_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.advisor_id.DefaultText = "";
            this.advisor_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.advisor_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.advisor_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.advisor_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.advisor_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.advisor_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.advisor_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.advisor_id.Location = new System.Drawing.Point(37, 37);
            this.advisor_id.Name = "advisor_id";
            this.advisor_id.PasswordChar = '\0';
            this.advisor_id.PlaceholderText = "";
            this.advisor_id.SelectedText = "";
            this.advisor_id.Size = new System.Drawing.Size(200, 36);
            this.advisor_id.TabIndex = 6;
            // 
            // add_project_advisor
            // 
            this.add_project_advisor.BorderRadius = 20;
            this.add_project_advisor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_project_advisor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_project_advisor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_project_advisor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_project_advisor.Font = new System.Drawing.Font("Verdana", 13.75F, System.Drawing.FontStyle.Bold);
            this.add_project_advisor.ForeColor = System.Drawing.Color.White;
            this.add_project_advisor.Location = new System.Drawing.Point(256, 89);
            this.add_project_advisor.Name = "add_project_advisor";
            this.add_project_advisor.Size = new System.Drawing.Size(209, 55);
            this.add_project_advisor.TabIndex = 5;
            this.add_project_advisor.Text = "Assign Advisor";
            this.add_project_advisor.Click += new System.EventHandler(this.add_project_advisor_Click);
            // 
            // project_advisor_grid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.project_advisor_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.project_advisor_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.project_advisor_grid.ColumnHeadersHeight = 4;
            this.project_advisor_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.project_advisor_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.project_advisor_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.project_advisor_grid.Location = new System.Drawing.Point(26, 164);
            this.project_advisor_grid.Name = "project_advisor_grid";
            this.project_advisor_grid.RowHeadersVisible = false;
            this.project_advisor_grid.Size = new System.Drawing.Size(702, 248);
            this.project_advisor_grid.TabIndex = 9;
            this.project_advisor_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.project_advisor_grid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.project_advisor_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.project_advisor_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.project_advisor_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.project_advisor_grid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.project_advisor_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.project_advisor_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.project_advisor_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.project_advisor_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_advisor_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.project_advisor_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.project_advisor_grid.ThemeStyle.HeaderStyle.Height = 4;
            this.project_advisor_grid.ThemeStyle.ReadOnly = false;
            this.project_advisor_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.project_advisor_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.project_advisor_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_advisor_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.project_advisor_grid.ThemeStyle.RowsStyle.Height = 22;
            this.project_advisor_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.project_advisor_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Advisor ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Project ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Role of Advisor";
            // 
            // display_project_advisor_button
            // 
            this.display_project_advisor_button.BackColor = System.Drawing.Color.Transparent;
            this.display_project_advisor_button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.display_project_advisor_button.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.display_project_advisor_button.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.display_project_advisor_button.Image = ((System.Drawing.Image)(resources.GetObject("display_project_advisor_button.Image")));
            this.display_project_advisor_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.display_project_advisor_button.ImageRotate = 0F;
            this.display_project_advisor_button.Location = new System.Drawing.Point(471, 88);
            this.display_project_advisor_button.Name = "display_project_advisor_button";
            this.display_project_advisor_button.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.display_project_advisor_button.Size = new System.Drawing.Size(62, 62);
            this.display_project_advisor_button.TabIndex = 28;
            this.display_project_advisor_button.UseTransparentBackground = true;
            this.display_project_advisor_button.Click += new System.EventHandler(this.display_project_advisor_button_Click);
            // 
            // uc_project_advisor_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.display_project_advisor_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.project_advisor_grid);
            this.Controls.Add(this.role);
            this.Controls.Add(this.project_id);
            this.Controls.Add(this.advisor_id);
            this.Controls.Add(this.add_project_advisor);
            this.Name = "uc_project_advisor_add";
            this.Size = new System.Drawing.Size(752, 426);
            ((System.ComponentModel.ISupportInitialize)(this.project_advisor_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox role;
        private Guna.UI2.WinForms.Guna2TextBox project_id;
        private Guna.UI2.WinForms.Guna2TextBox advisor_id;
        private Guna.UI2.WinForms.Guna2Button add_project_advisor;
        private Guna.UI2.WinForms.Guna2DataGridView project_advisor_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ImageButton display_project_advisor_button;
    }
}
