namespace MemoryGameProj
{
    partial class MemoryGameSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstPlayerNameBox = new System.Windows.Forms.TextBox();
            this.secondPlayerNameBox = new System.Windows.Forms.TextBox();
            this.boardSize = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.startGame = new System.Windows.Forms.Button();
            this.pickOpponent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Player Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Player Name:";
            // 
            // firstPlayerNameBox
            // 
            this.firstPlayerNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstPlayerNameBox.Location = new System.Drawing.Point(155, 10);
            this.firstPlayerNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstPlayerNameBox.Name = "firstPlayerNameBox";
            this.firstPlayerNameBox.Size = new System.Drawing.Size(100, 23);
            this.firstPlayerNameBox.TabIndex = 2;
            this.firstPlayerNameBox.TextChanged += new System.EventHandler(this.firstPlayerNameBox_TextChanged);
            // 
            // secondPlayerNameBox
            // 
            this.secondPlayerNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondPlayerNameBox.Enabled = false;
            this.secondPlayerNameBox.Location = new System.Drawing.Point(155, 38);
            this.secondPlayerNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secondPlayerNameBox.Name = "secondPlayerNameBox";
            this.secondPlayerNameBox.Size = new System.Drawing.Size(100, 23);
            this.secondPlayerNameBox.TabIndex = 3;
            this.secondPlayerNameBox.Text = "-computer-";
            this.secondPlayerNameBox.TextChanged += new System.EventHandler(this.secondPlayerNameBox_TextChanged);
            // 
            // boardSize
            // 
            this.boardSize.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.boardSize.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boardSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boardSize.Location = new System.Drawing.Point(12, 103);
            this.boardSize.Name = "boardSize";
            this.boardSize.Size = new System.Drawing.Size(126, 94);
            this.boardSize.TabIndex = 5;
            this.boardSize.Text = "4x4";
            this.boardSize.UseVisualStyleBackColor = false;
            this.boardSize.Click += new System.EventHandler(this.boardSize_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Board Size:";
            // 
            // startGame
            // 
            this.startGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startGame.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.Location = new System.Drawing.Point(261, 161);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(120, 36);
            this.startGame.TabIndex = 7;
            this.startGame.Text = "Start!";
            this.startGame.UseVisualStyleBackColor = false;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // pickOpponent
            // 
            this.pickOpponent.Location = new System.Drawing.Point(272, 38);
            this.pickOpponent.Name = "pickOpponent";
            this.pickOpponent.Size = new System.Drawing.Size(109, 23);
            this.pickOpponent.TabIndex = 8;
            this.pickOpponent.Text = "Aginst A Friend";
            this.pickOpponent.UseVisualStyleBackColor = true;
            this.pickOpponent.Click += new System.EventHandler(this.pickOpponent_Click);
            // 
            // MemoryGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 210);
            this.Controls.Add(this.pickOpponent);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boardSize);
            this.Controls.Add(this.secondPlayerNameBox);
            this.Controls.Add(this.firstPlayerNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemoryGameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game - Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstPlayerNameBox;
        private System.Windows.Forms.TextBox secondPlayerNameBox;
        private System.Windows.Forms.Button boardSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Button pickOpponent;
    }
}