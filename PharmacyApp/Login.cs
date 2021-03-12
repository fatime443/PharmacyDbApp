using PharmacyApp.Helper;
using PharmacyApp.modell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class Login : Form
    {
        PharrmacyDbEntities _context = new PharrmacyDbEntities();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            txtPassword.Text = Utilities.HashCode("1234");


            if (Utilities.IsEmpty(username, password))
            {
                Worker selectedworker = _context.Workers.FirstOrDefault(x => x.Fullname == username);
                if (selectedworker != null)
                {
                    if (selectedworker.Password == password.HashCode())
                    {
                        if (chkRemember.Checked)
                        {
                            Properties.Settings.Default.Username = txtUsername.Text;
                            Properties.Settings.Default.Password = txtPassword.Text;
                            Properties.Settings.Default.IsChecked = true;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Properties.Settings.Default.Username = string.Empty;
                            Properties.Settings.Default.Password  = string.Empty;
                            Properties.Settings.Default.IsChecked  = false;
                            Properties.Settings.Default.Save();
                        }
                        switch (selectedworker.RoleId)
                        {
                            case 1:
                                Form1 form1 = new Form1();
                                form1.ShowDialog();
                                break;
                            case 2:
                                WorkerDashboard workerDashboard = new WorkerDashboard();
                                workerDashboard.ShowDialog();
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                    MessageBox.Show("Username or Password is not valid!","error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Worker doesn't exist!","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IsChecked)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;
                chkRemember.Checked = true;
            }
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
