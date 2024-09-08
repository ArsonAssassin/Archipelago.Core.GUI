namespace Archipelago.Core.GUI
{
    partial class MainForm
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
            outputTextbox = new TextBox();
            passwordTextbox = new TextBox();
            label3 = new Label();
            slotTextbox = new TextBox();
            label2 = new Label();
            hostTextbox = new TextBox();
            label1 = new Label();
            connectBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // outputTextbox
            // 
            outputTextbox.Location = new Point(28, 25);
            outputTextbox.Multiline = true;
            outputTextbox.Name = "outputTextbox";
            outputTextbox.ReadOnly = true;
            outputTextbox.ScrollBars = ScrollBars.Both;
            outputTextbox.Size = new Size(417, 388);
            outputTextbox.TabIndex = 0;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(562, 83);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(158, 23);
            passwordTextbox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 86);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 13;
            label3.Text = "Password:";
            // 
            // slotTextbox
            // 
            slotTextbox.Location = new Point(562, 54);
            slotTextbox.Name = "slotTextbox";
            slotTextbox.Size = new Size(158, 23);
            slotTextbox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(487, 57);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 11;
            label2.Text = "Slot:";
            // 
            // hostTextbox
            // 
            hostTextbox.Location = new Point(562, 25);
            hostTextbox.Name = "hostTextbox";
            hostTextbox.Size = new Size(158, 23);
            hostTextbox.TabIndex = 10;
            hostTextbox.Text = "archipelago.gg:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(487, 28);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 9;
            label1.Text = "Host:";
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(562, 112);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(158, 23);
            connectBtn.TabIndex = 8;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(594, 285);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 444);
            Controls.Add(pictureBox1);
            Controls.Add(passwordTextbox);
            Controls.Add(label3);
            Controls.Add(slotTextbox);
            Controls.Add(label2);
            Controls.Add(hostTextbox);
            Controls.Add(label1);
            Controls.Add(connectBtn);
            Controls.Add(outputTextbox);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox outputTextbox;
        private TextBox passwordTextbox;
        private Label label3;
        private TextBox slotTextbox;
        private Label label2;
        private TextBox hostTextbox;
        private Label label1;
        private Button connectBtn;
        private PictureBox pictureBox1;
    }
}
