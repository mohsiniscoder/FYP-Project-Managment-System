namespace Project_Salvation.UI
{
    partial class uc_add_advisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_add_advisor));
            this.add_advisor_to_db = new Guna.UI2.WinForms.Guna2Button();
            this.id = new Guna.UI2.WinForms.Guna2TextBox();
            this.salary = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.advisor_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.designation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.display_advisor_button = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.advisor_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // add_advisor_to_db
            // 
            this.add_advisor_to_db.BorderRadius = 20;
            this.add_advisor_to_db.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_advisor_to_db.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_advisor_to_db.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_advisor_to_db.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_advisor_to_db.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_advisor_to_db.ForeColor = System.Drawing.Color.White;
            this.add_advisor_to_db.Location = new System.Drawing.Point(240, 89);
            this.add_advisor_to_db.Name = "add_advisor_to_db";
            this.add_advisor_to_db.Size = new System.Drawing.Size(203, 58);
            this.add_advisor_to_db.TabIndex = 0;
            this.add_advisor_to_db.Text = "Add Advisor";
            this.add_advisor_to_db.Click += new System.EventHandler(this.add_advisor_to_db_Click);
            // 
            // id
            // 
            this.id.BorderRadius = 15;
            this.id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id.DefaultText = "";
            this.id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id.Location = new System.Drawing.Point(22, 44);
            this.id.Name = "id";
            this.id.PasswordChar = '\0';
            this.id.PlaceholderText = "";
            this.id.SelectedText = "";
            this.id.Size = new System.Drawing.Size(200, 36);
            this.id.TabIndex = 1;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // salary
            // 
            this.salary.BorderRadius = 15;
            this.salary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salary.DefaultText = "";
            this.salary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.salary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.salary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.salary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.salary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.salary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.salary.Location = new System.Drawing.Point(238, 44);
            this.salary.Name = "salary";
            this.salary.PasswordChar = '\0';
            this.salary.PlaceholderText = "";
            this.salary.SelectedText = "";
            this.salary.Size = new System.Drawing.Size(209, 36);
            this.salary.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Advisor ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Designation";
            // 
            // advisor_grid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.advisor_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advisor_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.advisor_grid.ColumnHeadersHeight = 4;
            this.advisor_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advisor_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.advisor_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.advisor_grid.Location = new System.Drawing.Point(27, 160);
            this.advisor_grid.Name = "advisor_grid";
            this.advisor_grid.RowHeadersVisible = false;
            this.advisor_grid.Size = new System.Drawing.Size(702, 242);
            this.advisor_grid.TabIndex = 8;
            this.advisor_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.advisor_grid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.advisor_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.advisor_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.advisor_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.advisor_grid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.advisor_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.advisor_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.advisor_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.advisor_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advisor_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.advisor_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.advisor_grid.ThemeStyle.HeaderStyle.Height = 4;
            this.advisor_grid.ThemeStyle.ReadOnly = false;
            this.advisor_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.advisor_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.advisor_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advisor_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.advisor_grid.ThemeStyle.RowsStyle.Height = 22;
            this.advisor_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.advisor_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // designation
            // 
            this.designation.BackColor = System.Drawing.Color.Transparent;
            this.designation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.designation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.designation.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.designation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.designation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.designation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.designation.ItemHeight = 30;
            this.designation.Items.AddRange(new object[] {
            "Lecturer",
            "Assistant Professor",
            "Associate Professor",
            "Professor",
            ""});
            this.designation.Location = new System.Drawing.Point(470, 44);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(213, 36);
            this.designation.TabIndex = 4;
            // 
            // display_advisor_button
            // 
            this.display_advisor_button.BackColor = System.Drawing.Color.Transparent;
            this.display_advisor_button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.display_advisor_button.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.display_advisor_button.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.display_advisor_button.Image = ((System.Drawing.Image)(resources.GetObject("display_advisor_button.Image")));
            this.display_advisor_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.display_advisor_button.ImageRotate = 0F;
            this.display_advisor_button.Location = new System.Drawing.Point(449, 87);
            this.display_advisor_button.Name = "display_advisor_button";
            this.display_advisor_button.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.display_advisor_button.Size = new System.Drawing.Size(62, 62);
            this.display_advisor_button.TabIndex = 28;
            this.display_advisor_button.UseTransparentBackground = true;
            this.display_advisor_button.Click += new System.EventHandler(this.display_advisor_button_Click);
            // 
            // uc_add_advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.display_advisor_button);
            this.Controls.Add(this.advisor_grid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.id);
            this.Controls.Add(this.add_advisor_to_db);
            this.Name = "uc_add_advisor";
            this.Size = new System.Drawing.Size(752, 426);
            ((System.ComponentModel.ISupportInitialize)(this.advisor_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button add_advisor_to_db;
        private Guna.UI2.WinForms.Guna2TextBox id;
        private Guna.UI2.WinForms.Guna2TextBox salary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView advisor_grid;
        private Guna.UI2.WinForms.Guna2ComboBox designation;
        private Guna.UI2.WinForms.Guna2ImageButton display_advisor_button;
    }
}
