
namespace RogueLikeGame_V1_
{
    partial class Level2
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
            this.components = new System.ComponentModel.Container();
            this.pnlScreen = new System.Windows.Forms.Panel();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.pctPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlScreen
            // 
            this.pnlScreen.Location = new System.Drawing.Point(0, 0);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(801, 451);
            this.pnlScreen.TabIndex = 0;
            // 
            // tmrGame
            // 
            this.tmrGame.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // pctPlayer
            // 
            this.pctPlayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pctPlayer.Location = new System.Drawing.Point(388, 213);
            this.pctPlayer.Name = "pctPlayer";
            this.pctPlayer.Size = new System.Drawing.Size(25, 25);
            this.pctPlayer.TabIndex = 1;
            this.pctPlayer.TabStop = false;
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctPlayer);
            this.Controls.Add(this.pnlScreen);
            this.Name = "Level2";
            this.Text = "Level2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlScreen;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.PictureBox pctPlayer;
    }
}