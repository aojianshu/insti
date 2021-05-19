using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insti
{
    public partial class Form1 : Form
    {
        private DBConnect connect;
        private DataSet ds;
        private int count;

        public Form1()
        {
            InitializeComponent();
            connect = new DBConnect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
        }

        private void alblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogBox dialog = new DialogBox();
            dialog.ShowDialog();
            String username = dialog.Controls["txtUsername"].Text;
            String password = dialog.Controls["txtPassword"].Text;
            if(dialog.DialogResult == DialogResult.OK)
            {
                ds = connect.Login(username, password);
                count = ds.Tables[0].Rows.Count;
                if(count == 0)
                {
                    MessageBox.Show("No user found");
                    ds.Reset();
                    return;
                }

                if(ds.Tables[0].Rows[0]["ulevel"].ToString() == "Admin")
                {
                    this.alblLogin.Text = "You are logged in sa Administrator";
                    this.alblLogin.Location = new Point(457,120);
                    this.alblLogin.Enabled = false;
                    this.lblWelcome.Text = "Welcome " + ds.Tables[0].Rows[0]["ufullname"].ToString();
                    this.panelAdmin.Visible = true;
                    this.panelGuest.Visible = false;
                }

                if(ds.Tables[0].Rows[0]["ulevel"].ToString() == "Faculty")
                {
                    if(ds.Tables[0].Rows[0]["ustatus"].ToString() == "0")
                    {
                        MessageBox.Show("Sorry your account is currently inactive. Please update your membership account before you can continue.");
                        return;
                    }
                    this.alblLogin.Text = "You are logged in sa Member";
                    this.alblLogin.Location = new Point(520, 120);
                    this.alblLogin.Enabled = false;
                    this.lblWelcome.Text = "Welcome " + ds.Tables[0].Rows[0]["ufullname"].ToString();
                    this.panelMember.Visible = true;
                    this.panelGuest.Visible = false;
                }
                
  
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void alblAdminlogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ds.Reset();
            this.panelGuest.Visible = true;
            this.panelAdmin.Visible = false;
            this.alblLogin.Text = "Log in";
            this.alblLogin.Location = new Point(709, 120);
            this.alblLogin.Enabled = true;
            this.lblWelcome.Text = "Welcome Guest!";
        }

        private void alblMemberlogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ds.Reset();
            this.panelGuest.Visible = true;
            this.panelMember.Visible = false;
            this.alblLogin.Text = "Log in";
            this.alblLogin.Location = new Point(709, 120);
            this.alblLogin.Enabled = true;
            this.lblWelcome.Text = "Welcome Guest!";
        }
    }
}
