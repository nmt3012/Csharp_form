using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_form
{
    public partial class FRmMain : Form
    {
        public FRmMain()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            //kiểm tra username và password đúng thì mỏ Form Main, ngược lại thì hiện Messagebox
            if (txtTendangnhap.Text == "admin" && txtBaomat.Text == "123")
            {
                this.Close();
                FRmMain frmMain = new FRmMain();
                frmMain.ShowDialog();

            }
            else
            {
                MessageBox.Show("Sai rồi nhập lại ii", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
