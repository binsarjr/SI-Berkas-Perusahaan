using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SI_Berkas_Perusahaan.Controller;

namespace SI_Berkas_Perusahaan.View
{
    public partial class FrmLogin : Form
    {
        private UserController _controller = new UserController();
        public FrmLogin()
        {
            InitializeComponent();
            txtUsername.Text = "admin";
            txtPassword.Text = "admin";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // cek username dan password valid atau tidak
            if(_controller.Attempt(txtUsername.Text, txtPassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
