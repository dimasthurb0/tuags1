using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmTugas1 : Form
    {
        public frmTugas1()
        {
            InitializeComponent();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTugas1_Load(object sender, EventArgs e)
        {
              
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var nama = txtNama.Text; 
            var pendidikan = cmbPendidikan.Text; 
            var pekerjaan = lstPekerjaan.Text; 
        
            txtPesan1.Text = string.Format("Hallo {0}", nama); 
            txtPesan1.Text = string.Format("Pendidikan Anda {0} ya ?", pendidikan); 
            txtPesan1.Text = string.Format("Anda Seorang {0}, HEBAT !!!! ?", pekerjaan); }
        }
    }


