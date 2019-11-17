using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class frmLoading : Form
    {
        
        public frmLoading()
        {
            InitializeComponent();
        }
        public  void barraProgreso(int progressValue)
        {
            loadingBar.Value = progressValue;
            /*if (progressValue == 100)
            {
                btnClose.Visible = true;
            }*/
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
