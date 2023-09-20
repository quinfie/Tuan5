using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Tuan5
{
    public partial class FrmBai2 : Form
    {
        ErrorProvider er;
        public FrmBai2()
        {
            ErrorProvider er = new ErrorProvider();
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmBai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        public static bool IsEmail(string email)
        {
             if(string.IsNullOrEmpty(email))
                return false;
  
             return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        private void txbUserName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.er.SetError(ctr, "You must enter Your Name");
            else
                this.er.Clear();
        }

        
    }
}