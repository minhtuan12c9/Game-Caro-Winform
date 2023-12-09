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
    public partial class History : Form
    {
        // Khai báo ListView
        private ListView historyListView;
        public History()
        {
            InitializeComponent();
        }
        // Phương thức để cập nhật ListView
        public void UpdateHistoryListView(string player1Name, string result, string player2Name)
        {
            ListViewItem item = new ListViewItem(player1Name);
            item.SubItems.Add(result);
            item.SubItems.Add(player2Name);

            historyListView.Items.Add(item);
        }
    }
}
