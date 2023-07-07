namespace User1
{
    partial class MainForm
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
            btnJoin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnJoin
            // 
            btnJoin.Location = new Point(97, 55);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(75, 23);
            btnJoin.TabIndex = 0;
            btnJoin.Text = "Unirse";
            btnJoin.UseVisualStyleBackColor = true;
            btnJoin.Click += btnJoin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "Unirse al chat";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 105);
            Controls.Add(label1);
            Controls.Add(btnJoin);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJoin;
        private Label label1;
    }
}