﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManager
{
    public partial class FrmLogin : Form
    {
        public 
        public FrmLogin()
        {
            InitializeComponent();
        }

        
        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           string username = txtUsername.Text;
           string password = txtPassword.Text;
           if (username =="" ||  password == "")
            {
                MessageBox.Show("Popunite sva polja", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (username == "nastavnik" &&  password == "sifra")
            {
                MessageBox.Show("Dobrodošli "+ username);
            }
            else
            {
                MessageBox.Show("Podaci nisu ispravni!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
