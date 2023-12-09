using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_HoPhanMinhTuan
{
    public class Cls_Tuan
    {
        #region Properties

            int countUndo1 = 3;
            int countUndo2 = 3;

            private List<Button> winButtons = new List<Button>();
            // Add a variable to track the flashing state
            private bool flashingState = false;
            // Create a Timer for flashing effect
            private Timer flashTimer;

            public int match = 0;

            public int player1Time = 10; // Thời gian ban đầu của người chơi 1 (giây)
            public int player2Time = 10; // Thời gian ban đầu của người chơi 2 (giây)

            public Timer timer = new Timer(); // Sử dụng để đếm thời gian

            private int timeSum1 = 0;
            private int timeSum2 = 0;

            private int currentPlayerTime = 10; // Initial time in seconds
            public int Score1 = 0;
            public int Score2 = 0;
            private Panel chessBoard;
            public Panel ChessBoard
            {
                get => chessBoard;
                set => chessBoard = value;
            }
        
            private List<Player> player;
            public List<Player> Player 
            { 
                get => player; 
                set => player = value; 
            }

            private int currentPlayer;
            public int CurrentPlayer 
            { 
                get => currentPlayer; 
                set => currentPlayer = value; 
            }

            private frmTuan frmTuan;
            public frmTuan FrmTuan { get => frmTuan; set => frmTuan = value; }
        

            private List<List<Button>> matrix;
            public List<List<Button>> Matrix { get => matrix; set => matrix = value; }


            private Stack<Point> playTimeLine;
            public Stack<Point> PlayTimeLine { get => playTimeLine; set => playTimeLine = value; }
            public int CountUndo1 { get => countUndo1; set => countUndo1 = value; }
            public int CountUndo2 { get => countUndo2; set => countUndo2 = value; }
            public int TimeSum1 { get => timeSum1; set => timeSum1 = value; }
            public int TimeSum2 { get => timeSum2; set => timeSum2 = value; }

        #endregion

        #region Initialize
        public Cls_Tuan(Panel chessBoard, frmTuan frmTuan)
        {
            this.ChessBoard = chessBoard;
            this.FrmTuan = frmTuan;
            this.Player = new List<Player>()
            {
                new Player("Jinko", Image.FromFile(Application.StartupPath + "\\Resources\\o.png")),
                new Player("Lynn", Image.FromFile(Application.StartupPath + "\\Resources\\x.png")),
            };
            CurrentPlayer = 0;
            // Khởi tạo đồng hồ đếm thời gian và cài đặt sự kiện Tick
            timer.Interval = 1000; // Mỗi 1 giây
            timer.Tick += Timer_Tick;
            //timer.Start();


            // Initialize flashTimer
            flashTimer = new Timer();
            flashTimer.Interval = 500; // Set the interval in milliseconds (adjust as needed)
            flashTimer.Tick += FlashTimer_Tick; // Event handler for the timer


            PlayTimeLine = new Stack<Point>();

            this.CountUndo1 = countUndo1;
            this.CountUndo2 = countUndo2;
        }
        #endregion

        #region Methods
        public void drawChessBoard()
        {
            flashTimer.Stop();
            ChessBoard.Controls.Clear();
            Matrix = new List<List<Button>>();
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0), BackColor = Color.Gainsboro, };
            for (int i = 0; i < Cls_Tuan.chess_board_height; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j <= Cls_Tuan.chess_board_width; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cls_Tuan.chess_width,
                        Height = Cls_Tuan.chess_height,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackColor = Color.Gainsboro,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString(),
                    };

                    btn.Click += Btn_Click;

                    ChessBoard.Controls.Add(btn);

                    Matrix[i].Add(btn);

                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cls_Tuan.chess_height);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
                return;
            if (frmTuan.PlayerName1 == "PLAYER 1" && frmTuan.PlayerName2 == "PLAYER 2")
                return;
            btn.BackgroundImage = Player[CurrentPlayer].Mark;
            if (CurrentPlayer == 0)
            {
                frmTuan.Undo2.Enabled = false;
                frmTuan.Undo1.Enabled = true;
            }
            else
            {
                frmTuan.Undo1.Enabled = false;
                frmTuan.Undo2.Enabled = true;
            }
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;

            PlayTimeLine.Push(getChessPoint(btn));

            if(CurrentPlayer == 0)
            {
                FrmTuan.pnlPlayer1.BackColor = Color.Red;
                FrmTuan.pnlPlayer2.BackColor = Color.Turquoise;
            }
            else
            {
                FrmTuan.pnlPlayer1.BackColor = Color.Turquoise;
                FrmTuan.pnlPlayer2.BackColor = Color.Red;
            }


            if (isEndGame(btn))
            {
                CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
                EndGame();
            }
        }
        private void EndGame()
        {
            ChessBoard.Enabled = false;
            String a;
            if (CurrentPlayer == 0)
            {
                a = frmTuan.Nameplayer1.Text;
                Score1 += 1;
                match++;
            }
            else
            {
                a = frmTuan.Nameplayer2.Text;
                Score2 += 1;
                match++;
            }
            // Start flashing
            flashTimer.Start();
            timer.Stop();
            
            //lbWin1.Text = "Win-"
            MessageBox.Show("Người chơi " + a + " thắng");
            frmTuan.Win1 = "Win: " + "0" + Score1.ToString() + "/0" + match.ToString();
            frmTuan.Win2 = "Win: " + "0" + Score2.ToString() + "/0" + match.ToString();

            // Thêm thông tin vào ListView
            string player1Name = frmTuan.Nameplayer1.Text;
            string player2Name = frmTuan.Nameplayer2.Text;
            string result = (CurrentPlayer == 0) ? "1 - 0" : "0 - 1";

            // Gọi phương thức cập nhật ListView trong form "History"
            History historyForm = (History)Application.OpenForms["History"];
            if (historyForm != null)
            {
                historyForm.UpdateHistoryListView(player1Name, result, player2Name);
            }
        }
        private bool isEndGame(Button btn)
        {
        return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }
        private Point getChessPoint(Button btn)
        {
            
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);
            Point point = new Point(horizontal, vertical);
            return point;
        }
        private bool isEndHorizontal(Button btn)
        {
            winButtons.Clear();
            Point point = getChessPoint(btn);
            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                    winButtons.Add(Matrix[point.Y][i]);
                }
                else
                    break;
            }
            int countRight = 0;
            for (int i = point.X + 1; i < Cls_Tuan.chess_board_width; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                    winButtons.Add(Matrix[point.Y][i]);
                }
                else
                    break;
            }
            return countLeft + countRight == 5;
        }
        private bool isEndVertical(Button btn)
        {
            winButtons.Clear();
            Point point = getChessPoint(btn);
            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                    winButtons.Add(Matrix[i][point.X]);
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = point.Y + 1; i < Cls_Tuan.chess_board_height; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                    winButtons.Add(Matrix[i][point.X]);
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }
        private bool isEndPrimary(Button btn)
        {
            winButtons.Clear();
            Point point = getChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                    winButtons.Add(Matrix[point.Y - i][point.X - i]);
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 1; i <= Cls_Tuan.chess_board_width - point.X; i++)
            {
                if (point.Y + i >= Cls_Tuan.chess_board_height || point.X + i >= Cls_Tuan.chess_board_width)
                    break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                    winButtons.Add(Matrix[point.Y + i][point.X + i]);
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }
        private bool isEndSub(Button btn)
        {
            winButtons.Clear();
            Point point = getChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Cls_Tuan.chess_board_width || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                    winButtons.Add(Matrix[point.Y - i][point.X + i]);
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 1; i <= Cls_Tuan.chess_board_width - point.X; i++)
            {
                if (point.Y + i >= Cls_Tuan.chess_board_height || point.X + i < 0)
                    break;
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                    winButtons.Add(Matrix[point.Y + i][point.X - i]);
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }

        #endregion
        private string formatTime(int time)
        {
            int minute = TimeSum1 / 60;
            int second = TimeSum1 % 60;
            string result = "";
            if (minute < 10)
            {
                result += "0";
            }
            result += minute+":";

            if (second < 10)
            {
                result += "0";
            }
            result += second;
            return result;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (CurrentPlayer == 0)
            {
                player2Time = 10;
                frmTuan.Time2 = "10";
                
                player1Time--;
                TimeSum1++;

                frmTuan.Timer1.Text = formatTime(TimeSum1);
                frmTuan.Time1 = player1Time.ToString();
                if (player1Time == 0)
                {
                    // Hết thời gian cho người chơi 1, chuyển lượt chơi
                    CurrentPlayer = 1;
                    player2Time = 10; // Reset thời gian của người chơi 2
                    FrmTuan.pnlPlayer1.BackColor = Color.Turquoise;
                    FrmTuan.pnlPlayer2.BackColor = Color.Red;
                }
            }
            else
            {
                player1Time = 10;
                frmTuan.Time1 = "10";
                player2Time--;
                TimeSum2++;
                frmTuan.Timer2.Text = formatTime(TimeSum2);
                frmTuan.Time2 = player2Time.ToString();
                if (player2Time == 0)
                {
                    // Hết thời gian cho người chơi 2, chuyển lượt chơi
                    CurrentPlayer = 0;
                    player1Time = 10; // Reset thời gian của người chơi 1
                    FrmTuan.pnlPlayer1.BackColor = Color.Red;
                    FrmTuan.pnlPlayer2.BackColor = Color.Turquoise;
                }
            }
        }
        // Event handler for the flashing timer
        private void FlashTimer_Tick(object sender, EventArgs e)
        {
            // Toggle the flashing state
            flashingState = !flashingState;

            // Show or hide winButtons based on the state
            winButtons.ForEach(btn =>
            {
                if (flashingState)
                {
                    btn.BackColor = Color.Yellow;
                }
                else
                    btn.BackColor = Color.Gainsboro;
            });
        }
        public void undo()
        {
            if (playTimeLine.Count > 0)
            {
                Point lastMove = playTimeLine.Pop();
                Button buttonToUndo = Matrix[lastMove.Y][lastMove.X];
                buttonToUndo.BackgroundImage = null; // Clear the move
                                                     // Update the current player
                CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
            }
        }
        public void Undo()
        {
            if ((CountUndo1 == 0 && CurrentPlayer == 1) || (CountUndo2 == 0 && CurrentPlayer == 0))
                return;
            if (CurrentPlayer == 1)
            {
                FrmTuan.pnlPlayer1.BackColor = Color.Red;
                FrmTuan.pnlPlayer2.BackColor = Color.Turquoise;
                CountUndo1--;
                frmTuan.Undo1.Text = "Undo: 0" + CountUndo1.ToString();
                if (CountUndo1 == 0)
                {
                    frmTuan.Undo1.Enabled = false;
                }
            }
            else
            {
                FrmTuan.pnlPlayer1.BackColor = Color.Turquoise;
                FrmTuan.pnlPlayer2.BackColor = Color.Red;
                CountUndo2--;
                frmTuan.Undo2.Text = "Undo: 0" + CountUndo2.ToString();
                if (CountUndo2 == 0)
                {
                    frmTuan.Undo2.Enabled = false;
                }
            }
            undo();
        }

        




        public static int chess_width = 40;
        public static int chess_height = 40;

        public static int chess_board_width = 20;
        public static int chess_board_height = 20;
    }
}
