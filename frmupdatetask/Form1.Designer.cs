
namespace frmupdatetask
{
    partial class Form1
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
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "In Progress",
            "Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(30, 55);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(207, 24);
            this.cmbStatus.TabIndex = 0;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(272, 33);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(498, 242);
            this.txtComments.TabIndex = 1;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(462, 358);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(142, 31);
            this.btnUpdateStatus.TabIndex = 2;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.cmbStatus);
            this.Name = "Form1";
            this.Text = "Update Task Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Button btnUpdateStatus;
    }
}

