namespace Project_Salvation.UI
{
    partial class uc_create_show_groups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_create_show_groups));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.animation2 = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.animation_1 = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.add_group_button = new Guna.UI.WinForms.GunaButton();
            this.group_data_grid = new Guna.UI.WinForms.GunaDataGridView();
            this.view_groups = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.group_data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // animation2
            // 
            this.animation2.Animated = true;
            this.animation2.AnimationSpeed = 0.6F;
            this.animation2.Backwards = true;
            this.animation2.BaseColor = System.Drawing.Color.White;
            this.animation2.IdleColor = System.Drawing.Color.Gainsboro;
            this.animation2.IdleOffset = 20;
            this.animation2.Image = null;
            this.animation2.ImageSize = new System.Drawing.Size(52, 52);
            this.animation2.Location = new System.Drawing.Point(166, 5);
            this.animation2.Name = "animation2";
            this.animation2.ProgressMaxColor = System.Drawing.Color.Red;
            this.animation2.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.animation2.ProgressOffset = 20;
            this.animation2.Size = new System.Drawing.Size(92, 92);
            this.animation2.TabIndex = 31;
            this.animation2.Value = 45;
            this.animation2.Click += new System.EventHandler(this.animation2_Click);
            // 
            // animation_1
            // 
            this.animation_1.Animated = true;
            this.animation_1.AnimationSpeed = 0.6F;
            this.animation_1.BaseColor = System.Drawing.Color.White;
            this.animation_1.IdleColor = System.Drawing.Color.Gainsboro;
            this.animation_1.IdleOffset = 20;
            this.animation_1.Image = null;
            this.animation_1.ImageSize = new System.Drawing.Size(52, 52);
            this.animation_1.Location = new System.Drawing.Point(469, 7);
            this.animation_1.Name = "animation_1";
            this.animation_1.ProgressMaxColor = System.Drawing.Color.Lime;
            this.animation_1.ProgressMinColor = System.Drawing.Color.Yellow;
            this.animation_1.ProgressOffset = 20;
            this.animation_1.Size = new System.Drawing.Size(92, 92);
            this.animation_1.TabIndex = 30;
            this.animation_1.Value = 45;
            // 
            // add_group_button
            // 
            this.add_group_button.AnimationHoverSpeed = 0.07F;
            this.add_group_button.AnimationSpeed = 0.03F;
            this.add_group_button.BaseColor = System.Drawing.Color.ForestGreen;
            this.add_group_button.BorderColor = System.Drawing.Color.Black;
            this.add_group_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add_group_button.FocusedColor = System.Drawing.Color.Empty;
            this.add_group_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_group_button.ForeColor = System.Drawing.Color.White;
            this.add_group_button.Image = ((System.Drawing.Image)(resources.GetObject("add_group_button.Image")));
            this.add_group_button.ImageSize = new System.Drawing.Size(20, 20);
            this.add_group_button.Location = new System.Drawing.Point(264, 27);
            this.add_group_button.Name = "add_group_button";
            this.add_group_button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.add_group_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.add_group_button.OnHoverForeColor = System.Drawing.Color.White;
            this.add_group_button.OnHoverImage = null;
            this.add_group_button.OnPressedColor = System.Drawing.Color.Black;
            this.add_group_button.Size = new System.Drawing.Size(191, 51);
            this.add_group_button.TabIndex = 29;
            this.add_group_button.Text = "Create Group";
            this.add_group_button.Click += new System.EventHandler(this.add_group_button_Click);
            // 
            // group_data_grid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.group_data_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.group_data_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.group_data_grid.BackgroundColor = System.Drawing.Color.White;
            this.group_data_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.group_data_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.group_data_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.group_data_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.group_data_grid.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.group_data_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.group_data_grid.EnableHeadersVisualStyles = false;
            this.group_data_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.group_data_grid.Location = new System.Drawing.Point(169, 159);
            this.group_data_grid.Name = "group_data_grid";
            this.group_data_grid.RowHeadersVisible = false;
            this.group_data_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.group_data_grid.Size = new System.Drawing.Size(403, 242);
            this.group_data_grid.TabIndex = 32;
            this.group_data_grid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.group_data_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.group_data_grid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.group_data_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.group_data_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.group_data_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.group_data_grid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.group_data_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.group_data_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.group_data_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.group_data_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.group_data_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.group_data_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.group_data_grid.ThemeStyle.HeaderStyle.Height = 21;
            this.group_data_grid.ThemeStyle.ReadOnly = false;
            this.group_data_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.group_data_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.group_data_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.group_data_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.group_data_grid.ThemeStyle.RowsStyle.Height = 22;
            this.group_data_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.group_data_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.group_data_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.group_data_grid_CellContentClick);
            // 
            // view_groups
            // 
            this.view_groups.AnimationHoverSpeed = 0.07F;
            this.view_groups.AnimationSpeed = 0.03F;
            this.view_groups.BaseColor = System.Drawing.Color.Red;
            this.view_groups.BorderColor = System.Drawing.Color.Black;
            this.view_groups.DialogResult = System.Windows.Forms.DialogResult.None;
            this.view_groups.FocusedColor = System.Drawing.Color.Empty;
            this.view_groups.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_groups.ForeColor = System.Drawing.Color.White;
            this.view_groups.Image = ((System.Drawing.Image)(resources.GetObject("view_groups.Image")));
            this.view_groups.ImageSize = new System.Drawing.Size(20, 20);
            this.view_groups.Location = new System.Drawing.Point(264, 94);
            this.view_groups.Name = "view_groups";
            this.view_groups.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.view_groups.OnHoverBorderColor = System.Drawing.Color.Black;
            this.view_groups.OnHoverForeColor = System.Drawing.Color.White;
            this.view_groups.OnHoverImage = null;
            this.view_groups.OnPressedColor = System.Drawing.Color.Black;
            this.view_groups.Size = new System.Drawing.Size(191, 51);
            this.view_groups.TabIndex = 33;
            this.view_groups.Text = "View Groups";
            this.view_groups.Click += new System.EventHandler(this.view_groups_Click);
            // 
            // uc_create_show_groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.view_groups);
            this.Controls.Add(this.group_data_grid);
            this.Controls.Add(this.animation2);
            this.Controls.Add(this.animation_1);
            this.Controls.Add(this.add_group_button);
            this.Name = "uc_create_show_groups";
            this.Size = new System.Drawing.Size(752, 426);
            this.Load += new System.EventHandler(this.uc_create_show_groups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.group_data_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaCircleProgressBar animation2;
        private Guna.UI.WinForms.GunaCircleProgressBar animation_1;
        private Guna.UI.WinForms.GunaButton add_group_button;
        private Guna.UI.WinForms.GunaDataGridView group_data_grid;
        private Guna.UI.WinForms.GunaButton view_groups;
    }
}
