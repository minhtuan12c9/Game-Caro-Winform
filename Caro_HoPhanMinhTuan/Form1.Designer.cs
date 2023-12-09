
namespace Caro_HoPhanMinhTuan
{
    partial class frmTuan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlplayer1 = new System.Windows.Forms.Panel();
            this.time1 = new System.Windows.Forms.Button();
            this.win1 = new System.Windows.Forms.Button();
            this.undo1 = new System.Windows.Forms.Button();
            this.timePlayer1 = new System.Windows.Forms.Button();
            this.namePlayer1 = new System.Windows.Forms.Button();
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.pnlplayer2 = new System.Windows.Forms.Panel();
            this.time2 = new System.Windows.Forms.Button();
            this.win2 = new System.Windows.Forms.Button();
            this.undo2 = new System.Windows.Forms.Button();
            this.timePlayer2 = new System.Windows.Forms.Button();
            this.namePlayer2 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlplayer1.SuspendLayout();
            this.pnlplayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlplayer1
            // 
            this.pnlplayer1.BackColor = System.Drawing.Color.Turquoise;
            this.pnlplayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlplayer1.Controls.Add(this.time1);
            this.pnlplayer1.Controls.Add(this.win1);
            this.pnlplayer1.Controls.Add(this.undo1);
            this.pnlplayer1.Controls.Add(this.timePlayer1);
            this.pnlplayer1.Controls.Add(this.namePlayer1);
            this.pnlplayer1.Location = new System.Drawing.Point(824, 397);
            this.pnlplayer1.Name = "pnlplayer1";
            this.pnlplayer1.Size = new System.Drawing.Size(287, 349);
            this.pnlplayer1.TabIndex = 1;
            // 
            // time1
            // 
            this.time1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.time1.FlatAppearance.BorderSize = 5;
            this.time1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time1.Location = new System.Drawing.Point(14, 273);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(258, 59);
            this.time1.TabIndex = 0;
            this.time1.Text = "00:00";
            this.time1.UseVisualStyleBackColor = true;
            // 
            // win1
            // 
            this.win1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.win1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.win1.FlatAppearance.BorderSize = 5;
            this.win1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.win1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win1.Location = new System.Drawing.Point(14, 208);
            this.win1.Name = "win1";
            this.win1.Size = new System.Drawing.Size(258, 59);
            this.win1.TabIndex = 0;
            this.win1.Text = "Win: 00/00";
            this.win1.UseVisualStyleBackColor = true;
            // 
            // undo1
            // 
            this.undo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.undo1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.undo1.FlatAppearance.BorderSize = 5;
            this.undo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undo1.Location = new System.Drawing.Point(14, 143);
            this.undo1.Name = "undo1";
            this.undo1.Size = new System.Drawing.Size(258, 59);
            this.undo1.TabIndex = 0;
            this.undo1.Text = "Undo: 00";
            this.undo1.UseVisualStyleBackColor = true;
            this.undo1.Click += new System.EventHandler(this.Undo);
            // 
            // timePlayer1
            // 
            this.timePlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timePlayer1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.timePlayer1.FlatAppearance.BorderSize = 5;
            this.timePlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePlayer1.Location = new System.Drawing.Point(14, 78);
            this.timePlayer1.Name = "timePlayer1";
            this.timePlayer1.Size = new System.Drawing.Size(258, 59);
            this.timePlayer1.TabIndex = 0;
            this.timePlayer1.Text = "Time: 00:00";
            this.timePlayer1.UseVisualStyleBackColor = true;
            // 
            // namePlayer1
            // 
            this.namePlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.namePlayer1.BackColor = System.Drawing.Color.Blue;
            this.namePlayer1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.namePlayer1.FlatAppearance.BorderSize = 5;
            this.namePlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePlayer1.ForeColor = System.Drawing.Color.Yellow;
            this.namePlayer1.Location = new System.Drawing.Point(14, 13);
            this.namePlayer1.Name = "namePlayer1";
            this.namePlayer1.Size = new System.Drawing.Size(258, 59);
            this.namePlayer1.TabIndex = 0;
            this.namePlayer1.Text = "PLAYER 1";
            this.namePlayer1.UseVisualStyleBackColor = false;
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(188)))), ((int)(((byte)(198)))));
            this.pnlChessBoard.Location = new System.Drawing.Point(12, 12);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(804, 799);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // pnlplayer2
            // 
            this.pnlplayer2.BackColor = System.Drawing.Color.Turquoise;
            this.pnlplayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlplayer2.Controls.Add(this.time2);
            this.pnlplayer2.Controls.Add(this.win2);
            this.pnlplayer2.Controls.Add(this.undo2);
            this.pnlplayer2.Controls.Add(this.timePlayer2);
            this.pnlplayer2.Controls.Add(this.namePlayer2);
            this.pnlplayer2.Location = new System.Drawing.Point(1117, 397);
            this.pnlplayer2.Name = "pnlplayer2";
            this.pnlplayer2.Size = new System.Drawing.Size(287, 349);
            this.pnlplayer2.TabIndex = 1;
            // 
            // time2
            // 
            this.time2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.time2.FlatAppearance.BorderSize = 5;
            this.time2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time2.Location = new System.Drawing.Point(14, 273);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(258, 59);
            this.time2.TabIndex = 0;
            this.time2.Text = "00:00";
            this.time2.UseVisualStyleBackColor = true;
            // 
            // win2
            // 
            this.win2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.win2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.win2.FlatAppearance.BorderSize = 5;
            this.win2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.win2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win2.Location = new System.Drawing.Point(14, 208);
            this.win2.Name = "win2";
            this.win2.Size = new System.Drawing.Size(258, 59);
            this.win2.TabIndex = 0;
            this.win2.Text = "Win: 00/00";
            this.win2.UseVisualStyleBackColor = true;
            // 
            // undo2
            // 
            this.undo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.undo2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.undo2.FlatAppearance.BorderSize = 5;
            this.undo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undo2.Location = new System.Drawing.Point(14, 143);
            this.undo2.Name = "undo2";
            this.undo2.Size = new System.Drawing.Size(258, 59);
            this.undo2.TabIndex = 0;
            this.undo2.Text = "Undo: 00";
            this.undo2.UseVisualStyleBackColor = true;
            this.undo2.Click += new System.EventHandler(this.Undo);
            // 
            // timePlayer2
            // 
            this.timePlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timePlayer2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.timePlayer2.FlatAppearance.BorderSize = 5;
            this.timePlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePlayer2.Location = new System.Drawing.Point(14, 78);
            this.timePlayer2.Name = "timePlayer2";
            this.timePlayer2.Size = new System.Drawing.Size(258, 59);
            this.timePlayer2.TabIndex = 0;
            this.timePlayer2.Text = "Time: 00:00";
            this.timePlayer2.UseVisualStyleBackColor = true;
            // 
            // namePlayer2
            // 
            this.namePlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.namePlayer2.BackColor = System.Drawing.Color.Blue;
            this.namePlayer2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.namePlayer2.FlatAppearance.BorderSize = 5;
            this.namePlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePlayer2.ForeColor = System.Drawing.Color.Yellow;
            this.namePlayer2.Location = new System.Drawing.Point(14, 13);
            this.namePlayer2.Name = "namePlayer2";
            this.namePlayer2.Size = new System.Drawing.Size(258, 59);
            this.namePlayer2.TabIndex = 0;
            this.namePlayer2.Text = "PLAYER 2";
            this.namePlayer2.UseVisualStyleBackColor = false;
            // 
            // start
            // 
            this.start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.start.BackColor = System.Drawing.Color.Yellow;
            this.start.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.start.FlatAppearance.BorderSize = 5;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.MediumBlue;
            this.start.Location = new System.Drawing.Point(839, 332);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(258, 59);
            this.start.TabIndex = 0;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // clear
            // 
            this.clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clear.BackColor = System.Drawing.Color.Yellow;
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clear.FlatAppearance.BorderSize = 5;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.MediumBlue;
            this.clear.Location = new System.Drawing.Point(1132, 332);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(258, 59);
            this.clear.TabIndex = 0;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // history
            // 
            this.history.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.history.BackColor = System.Drawing.Color.Yellow;
            this.history.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.history.FlatAppearance.BorderSize = 5;
            this.history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.history.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.ForeColor = System.Drawing.Color.MediumBlue;
            this.history.Location = new System.Drawing.Point(987, 752);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(258, 59);
            this.history.TabIndex = 0;
            this.history.Text = "HISTORY";
            this.history.UseVisualStyleBackColor = false;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Caro_HoPhanMinhTuan.Properties.Resources.game;
            this.pictureBox1.Location = new System.Drawing.Point(824, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmTuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(188)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(1414, 823);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.history);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pnlplayer2);
            this.Controls.Add(this.pnlplayer1);
            this.Controls.Add(this.pnlChessBoard);
            this.Name = "frmTuan";
            this.Text = "Form1";
            this.pnlplayer1.ResumeLayout(false);
            this.pnlplayer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlplayer1;
        private System.Windows.Forms.Button namePlayer1;
        private System.Windows.Forms.Button win1;
        private System.Windows.Forms.Button undo1;
        private System.Windows.Forms.Button timePlayer1;
        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Button time1;
        private System.Windows.Forms.Panel pnlplayer2;
        private System.Windows.Forms.Button time2;
        private System.Windows.Forms.Button win2;
        private System.Windows.Forms.Button undo2;
        private System.Windows.Forms.Button timePlayer2;
        private System.Windows.Forms.Button namePlayer2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

