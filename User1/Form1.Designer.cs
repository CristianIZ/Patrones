namespace User1
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
            bntSend = new Button();
            txtWrite = new TextBox();
            txtChat = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // bntSend
            // 
            bntSend.Location = new Point(509, 290);
            bntSend.Name = "bntSend";
            bntSend.Size = new Size(75, 23);
            bntSend.TabIndex = 9;
            bntSend.Text = "Enviar";
            bntSend.UseVisualStyleBackColor = true;
            bntSend.Click += bntSend_Click;
            // 
            // txtWrite
            // 
            txtWrite.Location = new Point(53, 261);
            txtWrite.Name = "txtWrite";
            txtWrite.Size = new Size(531, 23);
            txtWrite.TabIndex = 8;
            // 
            // txtChat
            // 
            txtChat.Location = new Point(12, 27);
            txtChat.Multiline = true;
            txtChat.Name = "txtChat";
            txtChat.ScrollBars = ScrollBars.Vertical;
            txtChat.Size = new Size(572, 228);
            txtChat.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 264);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 6;
            label2.Text = "Write";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 5;
            label1.Text = "Chat";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 330);
            Controls.Add(bntSend);
            Controls.Add(txtWrite);
            Controls.Add(txtChat);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntSend;
        private TextBox txtWrite;
        private TextBox txtChat;
        private Label label2;
        private Label label1;
    }
}