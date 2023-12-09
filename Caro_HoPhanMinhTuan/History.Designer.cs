
namespace Caro_HoPhanMinhTuan
{
    partial class History
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.kq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.namePlayer1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.namePlayer2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kq,
            this.namePlayer1,
            this.namePlayer2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 391);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // kq
            // 
            this.kq.DisplayIndex = 1;
            this.kq.Text = "Kết quả";
            this.kq.Width = 136;
            // 
            // namePlayer1
            // 
            this.namePlayer1.DisplayIndex = 0;
            this.namePlayer1.Text = "Người chơi 1";
            this.namePlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.namePlayer1.Width = 309;
            // 
            // namePlayer2
            // 
            this.namePlayer2.Text = "Người chơi 2";
            this.namePlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.namePlayer2.Width = 343;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(188)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.listView1);
            this.Name = "History";
            this.Text = "History";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader kq;
        private System.Windows.Forms.ColumnHeader namePlayer1;
        private System.Windows.Forms.ColumnHeader namePlayer2;
    }
}