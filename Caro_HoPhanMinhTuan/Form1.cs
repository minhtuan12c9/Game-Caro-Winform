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
    public partial class frmTuan : Form
    {

        #region Properties
            public Button Timer1
            {
                get => time1;
                set => time1 = value;
            }
            public Button Timer2
            {
                get => time2;
                set => time2 = value;
            }

            Cls_Tuan ChessBoard;
            public Panel pnlPlayer1;
            public Panel pnlPlayer2;
            private Button nameplayer1;
            private Button nameplayer2;

            public string PlayerName1
            {
                get { return namePlayer1.Text; }
                set { namePlayer1.Text = value; }
            }

            public string PlayerName2
            {
                get { return namePlayer2.Text; }
                set { namePlayer2.Text = value; }
            }

            public string Time1
            {
                get { return timePlayer1.Text; }
                set { timePlayer1.Text = value; }
            }
            public string Time2
            {
                get { return timePlayer2.Text; }
                set { timePlayer2.Text = value; }
            }

            public string Win1
            {
                get { return win1.Text; }
                set { win1.Text = value; }
            }
            public string Win2
            {
                get { return win2.Text; }
                set { win2.Text = value; }
            }

            public Button Undo1
            {
                get => undo1;
                set => undo1 = value;
            }
            public Button Undo2
            {
                get => undo2;
                set => undo2 = value;
            }

            public Button Nameplayer1 { get => nameplayer1; set => nameplayer1 = value; }
            public Button Nameplayer2 { get => nameplayer2; set => nameplayer2 = value; }


        #endregion

        public frmTuan()
        {
            InitializeComponent();

            ChessBoard = new Cls_Tuan(pnlChessBoard, this);
            ChessBoard.drawChessBoard();

            this.pnlPlayer1 = pnlplayer1;
            this.pnlPlayer2 = pnlplayer2;
            this.Nameplayer1 = namePlayer1;
            this.Nameplayer2 = namePlayer2;

        }

        private void start_Click(object sender, EventArgs e)
        {
            Form dangkyForm = new DangKy(this);
            dangkyForm.StartPosition = FormStartPosition.CenterScreen;
            dangkyForm.Show();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ChessBoard.drawChessBoard();
            pnlChessBoard.Enabled = true;
            pnlplayer1.BackColor = Color.Red;
            pnlplayer2.BackColor = Color.Turquoise;
            ChessBoard.CurrentPlayer = 0;
            ChessBoard.CountUndo1 = 3;
            ChessBoard.CountUndo2 = 3;
            undo1.Text = "Undo: 03";
            undo2.Text = "Undo: 03";

            ChessBoard.TimeSum1 = 0;
            ChessBoard.TimeSum2 = 0;

            time1.Text = "00:00";
            time2.Text = "00:00";
            StartGame();
        }
        public void StartGame()
        {
            // Bắt đầu trò chơi và reset thời gian
            ChessBoard.player1Time = 10;
            ChessBoard.player2Time = 10;
            timePlayer1.Text = ChessBoard.player1Time.ToString();
            timePlayer2.Text = ChessBoard.player2Time.ToString();

            // Bắt đầu đếm thời gian
            ChessBoard.timer.Start();
        }
        private void Undo(object sender, EventArgs e)
        {
            ChessBoard.Undo();
        }

        private void history_Click(object sender, EventArgs e)
        {
            Form dangkyForm = new History();
            dangkyForm.StartPosition = FormStartPosition.CenterScreen;
            dangkyForm.Show();
        }
    }
}
