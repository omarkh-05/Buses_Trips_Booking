namespace AdminBusesBooking.Custom_Controls
{
    partial class CustomMessageBox
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
            panelTitleBar = new Panel();
            btnClose = new Button();
            lblCaption = new Label();
            panelButtons = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelBody = new Panel();
            labelMessage = new Label();
            pictureBoxIcon = new PictureBox();
            panelTitleBar.SuspendLayout();
            panelButtons.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.CadetBlue;
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(lblCaption);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(468, 45);
            panelTitleBar.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 13F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(386, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 45);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lblCaption
            // 
            lblCaption.AutoSize = true;
            lblCaption.ForeColor = Color.White;
            lblCaption.Location = new Point(12, 12);
            lblCaption.Name = "lblCaption";
            lblCaption.Size = new Size(101, 20);
            lblCaption.TabIndex = 0;
            lblCaption.Text = "Caption Label";
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(button3);
            panelButtons.Controls.Add(button2);
            panelButtons.Controls.Add(button1);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 135);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(468, 76);
            panelButtons.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(27, 20);
            button3.Name = "button3";
            button3.Size = new Size(124, 40);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(168, 20);
            button2.Name = "button2";
            button2.Size = new Size(124, 40);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(309, 20);
            button1.Name = "button1";
            button1.Size = new Size(124, 40);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // panelBody
            // 
            panelBody.Controls.Add(labelMessage);
            panelBody.Controls.Add(pictureBoxIcon);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 45);
            panelBody.Name = "panelBody";
            panelBody.Padding = new Padding(13, 12, 0, 0);
            panelBody.Size = new Size(468, 90);
            panelBody.TabIndex = 2;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Dock = DockStyle.Fill;
            labelMessage.Font = new Font("Microsoft Sans Serif", 10F);
            labelMessage.ForeColor = Color.DimGray;
            labelMessage.Location = new Point(69, 12);
            labelMessage.Margin = new Padding(4);
            labelMessage.MaximumSize = new Size(800, 0);
            labelMessage.Name = "labelMessage";
            labelMessage.Padding = new Padding(7, 6, 13, 18);
            labelMessage.Size = new Size(143, 44);
            labelMessage.TabIndex = 1;
            labelMessage.Text = "Label Message";
            labelMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Dock = DockStyle.Left;
            pictureBoxIcon.Image = Properties.Resources.chat;
            pictureBoxIcon.Location = new Point(13, 12);
            pictureBoxIcon.Margin = new Padding(4);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(56, 78);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 0;
            pictureBoxIcon.TabStop = false;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 211);
            Controls.Add(panelBody);
            Controls.Add(panelButtons);
            Controls.Add(panelTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomMessageBox";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CustomMessageBox";
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleBar;
        private Panel panelButtons;
        private Label lblCaption;
        private Panel panelBody;
        private Button btnClose;
        private Button button1;
        private Button button3;
        private Button button2;
        private PictureBox pictureBoxIcon;
        private Label labelMessage;
    }
}