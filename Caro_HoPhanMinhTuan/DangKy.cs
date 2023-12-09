using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_HoPhanMinhTuan
{
    public partial class DangKy : Form
    {

        public frmTuan frmTuan;


        public DangKy(frmTuan frmTuan)
        {
            InitializeComponent();
            this.frmTuan = frmTuan;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (nameBox1.Text == "" || nameBox2.Text == "")
                MessageBox.Show("Hãy nhập tên của bạn trước!");
            else
            {
                frmTuan.PlayerName1 = nameBox1.Text;
                frmTuan.PlayerName2 = nameBox2.Text;
                frmTuan.pnlPlayer1.BackColor = Color.Red;
                frmTuan.Undo1.Text = "Undo: 03";
                frmTuan.Undo2.Text = "Undo: 03";
                //frmTuan.Undo1.Enabled = false;
                //frmTuan.Undo2.Enabled = false;
                frmTuan.StartGame(); // Bắt đầu trò chơi và đếm ngược thời gian
                this.Close();
                frmTuan.Show();
                
            }
        }
    }
}
