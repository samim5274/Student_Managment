namespace StudentInfo
{
    partial class MotherForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentWiseStudentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deparmtmentCrystallReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentInfoToolStripMenuItem,
            this.addNewDepartmentToolStripMenuItem,
            this.createUserToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addStudentInfoToolStripMenuItem
            // 
            this.addStudentInfoToolStripMenuItem.Name = "addStudentInfoToolStripMenuItem";
            this.addStudentInfoToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.addStudentInfoToolStripMenuItem.Text = "AddStudentInfo";
            this.addStudentInfoToolStripMenuItem.Click += new System.EventHandler(this.addStudentInfoToolStripMenuItem_Click);
            // 
            // addNewDepartmentToolStripMenuItem
            // 
            this.addNewDepartmentToolStripMenuItem.Name = "addNewDepartmentToolStripMenuItem";
            this.addNewDepartmentToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.addNewDepartmentToolStripMenuItem.Text = "AddNewDepartment";
            this.addNewDepartmentToolStripMenuItem.Click += new System.EventHandler(this.addNewDepartmentToolStripMenuItem_Click);
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.createUserToolStripMenuItem.Text = "CreateUser";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentWiseStudentInfoToolStripMenuItem,
            this.deparmtmentCrystallReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.reportToolStripMenuItem.Text = "ReportForm";
            // 
            // departmentWiseStudentInfoToolStripMenuItem
            // 
            this.departmentWiseStudentInfoToolStripMenuItem.Name = "departmentWiseStudentInfoToolStripMenuItem";
            this.departmentWiseStudentInfoToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.departmentWiseStudentInfoToolStripMenuItem.Text = "Department_Wise_Student_Info";
            this.departmentWiseStudentInfoToolStripMenuItem.Click += new System.EventHandler(this.departmentWiseStudentInfoToolStripMenuItem_Click);
            // 
            // deparmtmentCrystallReportToolStripMenuItem
            // 
            this.deparmtmentCrystallReportToolStripMenuItem.Name = "deparmtmentCrystallReportToolStripMenuItem";
            this.deparmtmentCrystallReportToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.deparmtmentCrystallReportToolStripMenuItem.Text = "Deparmtment_Crystall_Report";
            this.deparmtmentCrystallReportToolStripMenuItem.Click += new System.EventHandler(this.deparmtmentCrystallReportToolStripMenuItem_Click);
            // 
            // MotherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 360);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MotherForm";
            this.Text = "MotherForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentWiseStudentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deparmtmentCrystallReportToolStripMenuItem;
    }
}