namespace StudentInfo
{
    partial class DepartmentForm
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
            this.btnAdddep = new System.Windows.Forms.Button();
            this.txtDid = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdddep
            // 
            this.btnAdddep.Location = new System.Drawing.Point(206, 115);
            this.btnAdddep.Name = "btnAdddep";
            this.btnAdddep.Size = new System.Drawing.Size(190, 39);
            this.btnAdddep.TabIndex = 0;
            this.btnAdddep.Text = "Add New Department";
            this.btnAdddep.UseVisualStyleBackColor = true;
            this.btnAdddep.Click += new System.EventHandler(this.btnAdddep_Click);
            // 
            // txtDid
            // 
            this.txtDid.Location = new System.Drawing.Point(206, 36);
            this.txtDid.Name = "txtDid";
            this.txtDid.Size = new System.Drawing.Size(216, 22);
            this.txtDid.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(206, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 22);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "DId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 180);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDid);
            this.Controls.Add(this.btnAdddep);
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdddep;
        private System.Windows.Forms.TextBox txtDid;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}