namespace Project_Salvation.UI
{
    partial class uc_add_evaluation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_add_evaluation));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.evaluation_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add_evaluation = new Guna.UI2.WinForms.Guna2Button();
            this.evaluation_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.total_marks = new Guna.UI2.WinForms.Guna2TextBox();
            this.total_weightage = new Guna.UI2.WinForms.Guna2TextBox();
            this.display_evaluation_button = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.evaluation_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total Marks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Evaluation Name";
            // 
            // evaluation_name
            // 
            this.evaluation_name.BorderRadius = 15;
            this.evaluation_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.evaluation_name.DefaultText = "";
            this.evaluation_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.evaluation_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.evaluation_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.evaluation_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.evaluation_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.evaluation_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.evaluation_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.evaluation_name.Location = new System.Drawing.Point(34, 60);
            this.evaluation_name.Name = "evaluation_name";
            this.evaluation_name.PasswordChar = '\0';
            this.evaluation_name.PlaceholderText = "";
            this.evaluation_name.SelectedText = "";
            this.evaluation_name.Size = new System.Drawing.Size(200, 36);
            this.evaluation_name.TabIndex = 16;
            this.evaluation_name.TextChanged += new System.EventHandler(this.evaluation_name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Total Weightage";
            // 
            // add_evaluation
            // 
            this.add_evaluation.BorderRadius = 10;
            this.add_evaluation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_evaluation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_evaluation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_evaluation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_evaluation.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_evaluation.ForeColor = System.Drawing.Color.White;
            this.add_evaluation.Location = new System.Drawing.Point(256, 111);
            this.add_evaluation.Name = "add_evaluation";
            this.add_evaluation.Size = new System.Drawing.Size(223, 46);
            this.add_evaluation.TabIndex = 23;
            this.add_evaluation.Text = "Add Evaluation";
            this.add_evaluation.Click += new System.EventHandler(this.add_evaluation_Click);
            // 
            // evaluation_grid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.evaluation_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.evaluation_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.evaluation_grid.ColumnHeadersHeight = 4;
            this.evaluation_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.evaluation_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.evaluation_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.evaluation_grid.Location = new System.Drawing.Point(16, 170);
            this.evaluation_grid.Name = "evaluation_grid";
            this.evaluation_grid.RowHeadersVisible = false;
            this.evaluation_grid.Size = new System.Drawing.Size(719, 247);
            this.evaluation_grid.TabIndex = 24;
            this.evaluation_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.evaluation_grid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.evaluation_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.evaluation_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.evaluation_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.evaluation_grid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.evaluation_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.evaluation_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.evaluation_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.evaluation_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluation_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.evaluation_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.evaluation_grid.ThemeStyle.HeaderStyle.Height = 4;
            this.evaluation_grid.ThemeStyle.ReadOnly = false;
            this.evaluation_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.evaluation_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.evaluation_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluation_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.evaluation_grid.ThemeStyle.RowsStyle.Height = 22;
            this.evaluation_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.evaluation_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // total_marks
            // 
            this.total_marks.BorderRadius = 15;
            this.total_marks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.total_marks.DefaultText = "";
            this.total_marks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.total_marks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.total_marks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.total_marks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.total_marks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.total_marks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.total_marks.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.total_marks.Location = new System.Drawing.Point(251, 60);
            this.total_marks.Name = "total_marks";
            this.total_marks.PasswordChar = '\0';
            this.total_marks.PlaceholderText = "";
            this.total_marks.SelectedText = "";
            this.total_marks.Size = new System.Drawing.Size(200, 36);
            this.total_marks.TabIndex = 25;
            // 
            // total_weightage
            // 
            this.total_weightage.BorderRadius = 15;
            this.total_weightage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.total_weightage.DefaultText = "";
            this.total_weightage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.total_weightage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.total_weightage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.total_weightage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.total_weightage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.total_weightage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.total_weightage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.total_weightage.Location = new System.Drawing.Point(481, 60);
            this.total_weightage.Name = "total_weightage";
            this.total_weightage.PasswordChar = '\0';
            this.total_weightage.PlaceholderText = "";
            this.total_weightage.SelectedText = "";
            this.total_weightage.Size = new System.Drawing.Size(200, 36);
            this.total_weightage.TabIndex = 26;
            // 
            // display_evaluation_button
            // 
            this.display_evaluation_button.BackColor = System.Drawing.Color.Transparent;
            this.display_evaluation_button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.display_evaluation_button.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.display_evaluation_button.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.display_evaluation_button.Image = ((System.Drawing.Image)(resources.GetObject("display_evaluation_button.Image")));
            this.display_evaluation_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.display_evaluation_button.ImageRotate = 0F;
            this.display_evaluation_button.Location = new System.Drawing.Point(485, 102);
            this.display_evaluation_button.Name = "display_evaluation_button";
            this.display_evaluation_button.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.display_evaluation_button.Size = new System.Drawing.Size(62, 62);
            this.display_evaluation_button.TabIndex = 27;
            this.display_evaluation_button.UseTransparentBackground = true;
            this.display_evaluation_button.Click += new System.EventHandler(this.display_evaluation_button_Click);
            // 
            // uc_add_evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.display_evaluation_button);
            this.Controls.Add(this.total_weightage);
            this.Controls.Add(this.total_marks);
            this.Controls.Add(this.evaluation_grid);
            this.Controls.Add(this.add_evaluation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.evaluation_name);
            this.Name = "uc_add_evaluation";
            this.Size = new System.Drawing.Size(752, 426);
            this.Load += new System.EventHandler(this.uc_add_evaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.evaluation_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox evaluation_name;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button add_evaluation;
        private Guna.UI2.WinForms.Guna2DataGridView evaluation_grid;
        private Guna.UI2.WinForms.Guna2TextBox total_marks;
        private Guna.UI2.WinForms.Guna2TextBox total_weightage;
        private Guna.UI2.WinForms.Guna2ImageButton display_evaluation_button;
    }
}
