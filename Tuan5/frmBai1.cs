using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan5
{
    public partial class frmBai1 : Form
    {
        ErrorProvider er;
        public frmBai1()
        {
            ErrorProvider er = new ErrorProvider();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            //Control ctr = (Control)sender;
            //if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length-11]))
            //    this.er.SetError(ctr, "This is not avalid number");
            //else
            //    this.er.Clear();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
        //    Control ctr = (Control)sender;
        //    if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 11]))
        //        this.er.SetError(ctr, "This is not avalid number");
        //    else
        //        this.er.Clear();
        }

        private void frmBai1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r=MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
