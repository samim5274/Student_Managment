namespace StudentInfo
{
    partial class Department_Wise_Student_Info
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.DepartmentGrid = new System.Windows.Forms.DataGridView();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPDFReport = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(179, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "StudentId";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(271, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(271, 46);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(182, 22);
            this.txtStudentId.TabIndex = 2;
            // 
            // DepartmentGrid
            // 
            this.DepartmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentGrid.Location = new System.Drawing.Point(39, 199);
            this.DepartmentGrid.Name = "DepartmentGrid";
            this.DepartmentGrid.RowTemplate.Height = 24;
            this.DepartmentGrid.Size = new System.Drawing.Size(981, 186);
            this.DepartmentGrid.TabIndex = 3;
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(271, 84);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(182, 24);
            this.cbxDepartment.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(165, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Department";
            // 
            // btnPDFReport
            // 
            this.btnPDFReport.Location = new System.Drawing.Point(409, 127);
            this.btnPDFReport.Name = "btnPDFReport";
            this.btnPDFReport.Size = new System.Drawing.Size(119, 34);
            this.btnPDFReport.TabIndex = 6;
            this.btnPDFReport.Text = "PDF Report";
            this.btnPDFReport.UseVisualStyleBackColor = true;
            this.btnPDFReport.Click += new System.EventHandler(this.btnPDFReport_Click);
            // 
            // Department_Wise_Student_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1030, 406);
            this.Controls.Add(this.btnPDFReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.DepartmentGrid);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Name = "Department_Wise_Student_Info";
            this.Text = "Department_Wise_Student_Info";
            this.Load += new System.EventHandler(this.DepartmentWiseStudentInfoLoad);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.DataGridView DepartmentGrid;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPDFReport;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}