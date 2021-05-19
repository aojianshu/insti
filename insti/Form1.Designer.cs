
namespace insti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.alblLogin = new System.Windows.Forms.LinkLabel();
            this.panelGuest = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.alblAdminlogout = new System.Windows.Forms.LinkLabel();
            this.panelMember = new System.Windows.Forms.Panel();
            this.alblMemberlogout = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelGuest.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.panelMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Scheduling System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 120);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(135, 19);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome Guest!";
            // 
            // alblLogin
            // 
            this.alblLogin.AutoSize = true;
            this.alblLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.alblLogin.LinkColor = System.Drawing.Color.Black;
            this.alblLogin.Location = new System.Drawing.Point(709, 120);
            this.alblLogin.Name = "alblLogin";
            this.alblLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.alblLogin.Size = new System.Drawing.Size(63, 19);
            this.alblLogin.TabIndex = 2;
            this.alblLogin.TabStop = true;
            this.alblLogin.Text = "Log In";
            this.alblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.alblLogin.VisitedLinkColor = System.Drawing.Color.Black;
            this.alblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.alblLogin_LinkClicked);
            // 
            // panelGuest
            // 
            this.panelGuest.Controls.Add(this.label2);
            this.panelGuest.Location = new System.Drawing.Point(12, 165);
            this.panelGuest.Name = "panelGuest";
            this.panelGuest.Size = new System.Drawing.Size(760, 384);
            this.panelGuest.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please Log in . . .";
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.alblAdminlogout);
            this.panelAdmin.Controls.Add(this.label3);
            this.panelAdmin.Location = new System.Drawing.Point(9, 165);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(760, 384);
            this.panelAdmin.TabIndex = 4;
            this.panelAdmin.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Administrators Form Area";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // alblAdminlogout
            // 
            this.alblAdminlogout.AutoSize = true;
            this.alblAdminlogout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.alblAdminlogout.LinkColor = System.Drawing.Color.Black;
            this.alblAdminlogout.Location = new System.Drawing.Point(672, 27);
            this.alblAdminlogout.Name = "alblAdminlogout";
            this.alblAdminlogout.Size = new System.Drawing.Size(72, 19);
            this.alblAdminlogout.TabIndex = 1;
            this.alblAdminlogout.TabStop = true;
            this.alblAdminlogout.Text = "Log Out";
            this.alblAdminlogout.VisitedLinkColor = System.Drawing.Color.Black;
            this.alblAdminlogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.alblAdminlogout_LinkClicked);
            // 
            // panelMember
            // 
            this.panelMember.Controls.Add(this.alblMemberlogout);
            this.panelMember.Location = new System.Drawing.Point(9, 165);
            this.panelMember.Name = "panelMember";
            this.panelMember.Size = new System.Drawing.Size(763, 384);
            this.panelMember.TabIndex = 2;
            this.panelMember.Visible = false;
            // 
            // alblMemberlogout
            // 
            this.alblMemberlogout.AutoSize = true;
            this.alblMemberlogout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.alblMemberlogout.LinkColor = System.Drawing.Color.Black;
            this.alblMemberlogout.Location = new System.Drawing.Point(672, 14);
            this.alblMemberlogout.Name = "alblMemberlogout";
            this.alblMemberlogout.Size = new System.Drawing.Size(72, 19);
            this.alblMemberlogout.TabIndex = 0;
            this.alblMemberlogout.TabStop = true;
            this.alblMemberlogout.Text = "Log Out";
            this.alblMemberlogout.VisitedLinkColor = System.Drawing.Color.Black;
            this.alblMemberlogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.alblMemberlogout_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelMember);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panelGuest);
            this.Controls.Add(this.alblLogin);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iligan Computer Institute RSS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelGuest.ResumeLayout(false);
            this.panelGuest.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.panelMember.ResumeLayout(false);
            this.panelMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.LinkLabel alblLogin;
        private System.Windows.Forms.Panel panelGuest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel alblAdminlogout;
        private System.Windows.Forms.Panel panelMember;
        private System.Windows.Forms.LinkLabel alblMemberlogout;
    }
}

