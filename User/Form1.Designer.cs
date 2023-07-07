namespace User
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtReport = new TextBox();
            label1 = new Label();
            txtWrite = new TextBox();
            btnSave = new Button();
            btnReport = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtReport
            // 
            txtReport.Location = new Point(12, 71);
            txtReport.Multiline = true;
            txtReport.Name = "txtReport";
            txtReport.Size = new Size(409, 145);
            txtReport.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 1;
            label1.Text = "Reporte";
            // 
            // txtWrite
            // 
            txtWrite.Location = new Point(12, 27);
            txtWrite.Name = "txtWrite";
            txtWrite.Size = new Size(328, 23);
            txtWrite.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(346, 27);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Enviar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(148, 222);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(111, 23);
            btnReport.TabIndex = 4;
            btnReport.Text = "Reportar";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "Guardar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 254);
            Controls.Add(label2);
            Controls.Add(btnReport);
            Controls.Add(btnSave);
            Controls.Add(txtWrite);
            Controls.Add(label1);
            Controls.Add(txtReport);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtReport;
        private Label label1;
        private TextBox txtWrite;
        private Button btnSave;
        private Button btnReport;
        private Label label2;
    }
}