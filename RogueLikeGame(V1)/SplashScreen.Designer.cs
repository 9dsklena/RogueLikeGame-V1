
namespace RogueLikeGame_V1_
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pgbLoading = new System.Windows.Forms.ProgressBar();
            this.lblFunFacts = new System.Windows.Forms.Label();
            this.tmrLoading = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pgbLoading
            // 
            this.pgbLoading.Location = new System.Drawing.Point(330, 254);
            this.pgbLoading.Name = "pgbLoading";
            this.pgbLoading.Size = new System.Drawing.Size(173, 23);
            this.pgbLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbLoading.TabIndex = 0;
            this.pgbLoading.Click += new System.EventHandler(this.pgbLoading_Click);
            // 
            // lblFunFacts
            // 
            this.lblFunFacts.BackColor = System.Drawing.Color.Transparent;
            this.lblFunFacts.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunFacts.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFunFacts.Location = new System.Drawing.Point(96, 92);
            this.lblFunFacts.Name = "lblFunFacts";
            this.lblFunFacts.Size = new System.Drawing.Size(639, 159);
            this.lblFunFacts.TabIndex = 1;
            this.lblFunFacts.Text = "label1";
            this.lblFunFacts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFunFacts.Click += new System.EventHandler(this.lblFunFacts_Click);
            // 
            // tmrLoading
            // 
            this.tmrLoading.Enabled = true;
            this.tmrLoading.Interval = 75;
            this.tmrLoading.Tick += new System.EventHandler(this.tmrLoading_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pgbLoading);
            this.Controls.Add(this.lblFunFacts);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading Screen";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbLoading;
        private System.Windows.Forms.Label lblFunFacts;
        private System.Windows.Forms.Timer tmrLoading;
    }
}