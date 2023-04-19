namespace Shaman_PAM_Solution
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            process = new System.Diagnostics.Process();
            panel1 = new Panel();
            label1 = new Label();
            btnContact = new Button();
            btnExit = new Button();
            btnHistory = new Button();
            btnRequest = new Button();
            pictureBox1 = new PictureBox();
            notifyIcon = new NotifyIcon(components);
            contextMenuStrip = new ContextMenuStrip(components);
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // process
            // 
            process.StartInfo.Domain = "";
            process.StartInfo.LoadUserProfile = false;
            process.StartInfo.Password = null;
            process.StartInfo.StandardErrorEncoding = null;
            process.StartInfo.StandardInputEncoding = null;
            process.StartInfo.StandardOutputEncoding = null;
            process.StartInfo.UserName = "";
            process.SynchronizingObject = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(93, 93, 57);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnContact);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnRequest);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(7, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 480);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(61, 103);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 6;
            label1.Tag = "";
            label1.Text = "Shaman PAM Solution";
            // 
            // btnContact
            // 
            btnContact.Dock = DockStyle.Bottom;
            btnContact.FlatAppearance.BorderSize = 0;
            btnContact.FlatStyle = FlatStyle.Flat;
            btnContact.ForeColor = SystemColors.ControlLight;
            btnContact.Location = new Point(0, 451);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(270, 29);
            btnContact.TabIndex = 5;
            btnContact.Text = "Contact Us";
            btnContact.UseVisualStyleBackColor = true;
            btnContact.Click += btnContact_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Top;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = SystemColors.ControlLight;
            btnExit.Location = new Point(0, 201);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(270, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnHistory
            // 
            btnHistory.Dock = DockStyle.Top;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.ForeColor = SystemColors.ControlLight;
            btnHistory.Location = new Point(0, 172);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(270, 29);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "View History";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnRequest
            // 
            btnRequest.Dock = DockStyle.Top;
            btnRequest.FlatAppearance.BorderSize = 0;
            btnRequest.FlatStyle = FlatStyle.Flat;
            btnRequest.ForeColor = SystemColors.ControlLight;
            btnRequest.Location = new Point(0, 143);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(270, 29);
            btnRequest.TabIndex = 2;
            btnRequest.Text = "Request Form";
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += btnRequest_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.herbimage;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = contextMenuStrip;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "Shaman PAM Solution";
            notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(174, 52);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(173, 24);
            toolStripMenuItem2.Text = "Show Window";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(173, 24);
            toolStripMenuItem3.Text = "Exit";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 507);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Shaman PAM Solution";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Diagnostics.Process process;
        private Panel panel1;
        private PictureBox pictureBox1;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip;
        private Label label1;
        private Button btnContact;
        private Button btnExit;
        private Button btnHistory;
        private Button btnRequest;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}