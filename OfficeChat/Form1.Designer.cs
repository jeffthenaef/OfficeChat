namespace OfficeChat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.txtMessageDialoge = new System.Windows.Forms.RichTextBox();
            this.txtUsrInput = new System.Windows.Forms.TextBox();
            this.lstUserSelection = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.cmbAdminPanel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(315, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMessageDialoge
            // 
            this.txtMessageDialoge.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtMessageDialoge.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageDialoge.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtMessageDialoge.Location = new System.Drawing.Point(10, 38);
            this.txtMessageDialoge.Name = "txtMessageDialoge";
            this.txtMessageDialoge.Size = new System.Drawing.Size(380, 371);
            this.txtMessageDialoge.TabIndex = 2;
            this.txtMessageDialoge.Text = "";
            // 
            // txtUsrInput
            // 
            this.txtUsrInput.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrInput.Location = new System.Drawing.Point(10, 415);
            this.txtUsrInput.Name = "txtUsrInput";
            this.txtUsrInput.Size = new System.Drawing.Size(380, 21);
            this.txtUsrInput.TabIndex = 3;
            // 
            // lstUserSelection
            // 
            this.lstUserSelection.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstUserSelection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUserSelection.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUserSelection.FormattingEnabled = true;
            this.lstUserSelection.ItemHeight = 14;
            this.lstUserSelection.Items.AddRange(new object[] {
            "Friends List"});
            this.lstUserSelection.Location = new System.Drawing.Point(396, 7);
            this.lstUserSelection.Name = "lstUserSelection";
            this.lstUserSelection.ScrollAlwaysVisible = true;
            this.lstUserSelection.Size = new System.Drawing.Size(120, 448);
            this.lstUserSelection.TabIndex = 4;
            this.lstUserSelection.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Logged In As:";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCurrentUser.Location = new System.Drawing.Point(102, 13);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentUser.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(315, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Log In";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbAdminPanel
            // 
            this.cmbAdminPanel.FormattingEnabled = true;
            this.cmbAdminPanel.Items.AddRange(new object[] {
            "Add User"});
            this.cmbAdminPanel.Location = new System.Drawing.Point(10, 441);
            this.cmbAdminPanel.Name = "cmbAdminPanel";
            this.cmbAdminPanel.Size = new System.Drawing.Size(121, 21);
            this.cmbAdminPanel.TabIndex = 9;
            this.cmbAdminPanel.Visible = false;
            this.cmbAdminPanel.SelectedIndexChanged += new System.EventHandler(this.cmbAdminPanel_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(522, 467);
            this.Controls.Add(this.cmbAdminPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstUserSelection);
            this.Controls.Add(this.txtUsrInput);
            this.Controls.Add(this.txtMessageDialoge);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Office Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtMessageDialoge;
        private System.Windows.Forms.TextBox txtUsrInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListBox lstUserSelection;
        private System.Windows.Forms.ComboBox cmbAdminPanel;
    }
}

