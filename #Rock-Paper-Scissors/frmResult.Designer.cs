namespace _Rock_Paper_Scissors
{
    partial class frmResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResult));
            this.lbRounds = new System.Windows.Forms.Label();
            this.lbComputerWin = new System.Windows.Forms.Label();
            this.lbDraw = new System.Windows.Forms.Label();
            this.lbPlayerWin = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRounds
            // 
            this.lbRounds.AutoSize = true;
            this.lbRounds.Font = new System.Drawing.Font("Niagara Solid", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRounds.Location = new System.Drawing.Point(12, 9);
            this.lbRounds.Name = "lbRounds";
            this.lbRounds.Size = new System.Drawing.Size(198, 85);
            this.lbRounds.TabIndex = 0;
            this.lbRounds.Text = "Rounds: ";
            // 
            // lbComputerWin
            // 
            this.lbComputerWin.AutoSize = true;
            this.lbComputerWin.Font = new System.Drawing.Font("Niagara Solid", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComputerWin.Location = new System.Drawing.Point(12, 129);
            this.lbComputerWin.Name = "lbComputerWin";
            this.lbComputerWin.Size = new System.Drawing.Size(328, 85);
            this.lbComputerWin.TabIndex = 1;
            this.lbComputerWin.Text = "Computer Win: ";
            // 
            // lbDraw
            // 
            this.lbDraw.AutoSize = true;
            this.lbDraw.Font = new System.Drawing.Font("Niagara Solid", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDraw.Location = new System.Drawing.Point(12, 369);
            this.lbDraw.Name = "lbDraw";
            this.lbDraw.Size = new System.Drawing.Size(159, 85);
            this.lbDraw.TabIndex = 2;
            this.lbDraw.Text = "Draw: ";
            // 
            // lbPlayerWin
            // 
            this.lbPlayerWin.AutoSize = true;
            this.lbPlayerWin.Font = new System.Drawing.Font("Niagara Solid", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerWin.Location = new System.Drawing.Point(12, 249);
            this.lbPlayerWin.Name = "lbPlayerWin";
            this.lbPlayerWin.Size = new System.Drawing.Size(268, 85);
            this.lbPlayerWin.TabIndex = 3;
            this.lbPlayerWin.Text = "Player Win: ";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Blue;
            this.btnPlayAgain.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(462, 398);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(514, 136);
            this.btnPlayAgain.TabIndex = 4;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // frmResult
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(993, 544);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lbPlayerWin);
            this.Controls.Add(this.lbDraw);
            this.Controls.Add(this.lbComputerWin);
            this.Controls.Add(this.lbRounds);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResult";
            this.Text = "frmResult";
            this.Load += new System.EventHandler(this.frmResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRounds;
        private System.Windows.Forms.Label lbComputerWin;
        private System.Windows.Forms.Label lbDraw;
        private System.Windows.Forms.Label lbPlayerWin;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}