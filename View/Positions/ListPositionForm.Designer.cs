﻿namespace Salary_management.View.Positions
{
    partial class ListPositionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.positionsTabControl = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.positionTab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listPositionsTable = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.positionIDTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionNameTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseSalaryTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameRankTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDetailBtnTable = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rankTab = new System.Windows.Forms.TabPage();
            this.positionsTabControl.SuspendLayout();
            this.positionTab.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listPositionsTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // positionsTabControl
            // 
            this.positionsTabControl.Controls.Add(this.positionTab);
            this.positionsTabControl.Controls.Add(this.rankTab);
            this.positionsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.positionsTabControl.ItemSize = new System.Drawing.Size(180, 40);
            this.positionsTabControl.Location = new System.Drawing.Point(0, 0);
            this.positionsTabControl.Name = "positionsTabControl";
            this.positionsTabControl.SelectedIndex = 0;
            this.positionsTabControl.Size = new System.Drawing.Size(895, 518);
            this.positionsTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.positionsTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.positionsTabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.positionsTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.positionsTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.positionsTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.positionsTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.positionsTabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.positionsTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.positionsTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.positionsTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.positionsTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.positionsTabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.positionsTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.positionsTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.positionsTabControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.positionsTabControl.TabIndex = 0;
            this.positionsTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.positionsTabControl.TabMenuOrientation = Siticone.Desktop.UI.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // positionTab
            // 
            this.positionTab.Controls.Add(this.panel5);
            this.positionTab.Controls.Add(this.panel1);
            this.positionTab.Location = new System.Drawing.Point(4, 44);
            this.positionTab.Name = "positionTab";
            this.positionTab.Padding = new System.Windows.Forms.Padding(3);
            this.positionTab.Size = new System.Drawing.Size(887, 470);
            this.positionTab.TabIndex = 0;
            this.positionTab.Text = "Position";
            this.positionTab.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.listPositionsTable);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 128);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel5.Size = new System.Drawing.Size(881, 339);
            this.panel5.TabIndex = 2;
            // 
            // listPositionsTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.listPositionsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listPositionsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listPositionsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listPositionsTable.ColumnHeadersHeight = 22;
            this.listPositionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.listPositionsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionIDTable,
            this.positionNameTable,
            this.baseSalaryTable,
            this.descriptionTable,
            this.nameRankTable,
            this.positionDetailBtnTable});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listPositionsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.listPositionsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPositionsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listPositionsTable.Location = new System.Drawing.Point(0, 20);
            this.listPositionsTable.Name = "listPositionsTable";
            this.listPositionsTable.RowHeadersVisible = false;
            this.listPositionsTable.RowHeadersWidth = 51;
            this.listPositionsTable.RowTemplate.Height = 29;
            this.listPositionsTable.Size = new System.Drawing.Size(881, 319);
            this.listPositionsTable.TabIndex = 0;
            this.listPositionsTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.listPositionsTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listPositionsTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.listPositionsTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listPositionsTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listPositionsTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.listPositionsTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listPositionsTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.listPositionsTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.listPositionsTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listPositionsTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.listPositionsTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.listPositionsTable.ThemeStyle.HeaderStyle.Height = 22;
            this.listPositionsTable.ThemeStyle.ReadOnly = false;
            this.listPositionsTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listPositionsTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listPositionsTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listPositionsTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.listPositionsTable.ThemeStyle.RowsStyle.Height = 29;
            this.listPositionsTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listPositionsTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // positionIDTable
            // 
            this.positionIDTable.HeaderText = "ID";
            this.positionIDTable.MinimumWidth = 6;
            this.positionIDTable.Name = "positionIDTable";
            // 
            // positionNameTable
            // 
            this.positionNameTable.HeaderText = "Name";
            this.positionNameTable.MinimumWidth = 6;
            this.positionNameTable.Name = "positionNameTable";
            // 
            // baseSalaryTable
            // 
            this.baseSalaryTable.HeaderText = "Base Salary";
            this.baseSalaryTable.MinimumWidth = 6;
            this.baseSalaryTable.Name = "baseSalaryTable";
            // 
            // descriptionTable
            // 
            this.descriptionTable.HeaderText = "Description";
            this.descriptionTable.MinimumWidth = 6;
            this.descriptionTable.Name = "descriptionTable";
            // 
            // nameRankTable
            // 
            this.nameRankTable.HeaderText = "Name Rank";
            this.nameRankTable.MinimumWidth = 6;
            this.nameRankTable.Name = "nameRankTable";
            // 
            // positionDetailBtnTable
            // 
            this.positionDetailBtnTable.HeaderText = "Detail";
            this.positionDetailBtnTable.MinimumWidth = 6;
            this.positionDetailBtnTable.Name = "positionDetailBtnTable";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(881, 125);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(869, 58);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.addBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(750, 5);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panel4.Size = new System.Drawing.Size(114, 48);
            this.panel4.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(10, 0);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(94, 38);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Position Management";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchText);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 84);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(869, 34);
            this.panel2.TabIndex = 2;
            // 
            // searchText
            // 
            this.searchText.DefaultText = "";
            this.searchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchText.Location = new System.Drawing.Point(61, 5);
            this.searchText.Name = "searchText";
            this.searchText.PasswordChar = '\0';
            this.searchText.PlaceholderText = "";
            this.searchText.SelectedText = "";
            this.searchText.Size = new System.Drawing.Size(803, 24);
            this.searchText.TabIndex = 1;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search:";
            // 
            // rankTab
            // 
            this.rankTab.Location = new System.Drawing.Point(4, 44);
            this.rankTab.Name = "rankTab";
            this.rankTab.Padding = new System.Windows.Forms.Padding(3);
            this.rankTab.Size = new System.Drawing.Size(887, 470);
            this.rankTab.TabIndex = 1;
            this.rankTab.Text = "Rank";
            this.rankTab.UseVisualStyleBackColor = true;
            // 
            // ListPositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 518);
            this.Controls.Add(this.positionsTabControl);
            this.Name = "ListPositionForm";
            this.Text = "ListPosition";
            this.Load += new System.EventHandler(this.ListPositionForm_Load);
            this.positionsTabControl.ResumeLayout(false);
            this.positionTab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listPositionsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTabControl positionsTabControl;
        private TabPage positionTab;
        private TabPage rankTab;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addBtn;
        private Label label1;
        private Panel panel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox searchText;
        private Label label2;
        private Panel panel5;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView listPositionsTable;
        private DataGridViewTextBoxColumn positionIDTable;
        private DataGridViewTextBoxColumn positionNameTable;
        private DataGridViewTextBoxColumn baseSalaryTable;
        private DataGridViewTextBoxColumn descriptionTable;
        private DataGridViewTextBoxColumn nameRankTable;
        private DataGridViewButtonColumn positionDetailBtnTable;
    }
}