namespace BrickBreaker.Screens
{
    partial class HighscoreScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scoreTitle = new System.Windows.Forms.Label();
            this.highscoreOutput = new System.Windows.Forms.Label();
            this.recentScoreOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreTitle
            // 
            this.scoreTitle.BackColor = System.Drawing.Color.Transparent;
            this.scoreTitle.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTitle.Location = new System.Drawing.Point(198, 24);
            this.scoreTitle.Name = "scoreTitle";
            this.scoreTitle.Size = new System.Drawing.Size(404, 90);
            this.scoreTitle.TabIndex = 0;
            this.scoreTitle.Text = "High Scores";
            // 
            // highscoreOutput
            // 
            this.highscoreOutput.AutoSize = true;
            this.highscoreOutput.Location = new System.Drawing.Point(172, 200);
            this.highscoreOutput.Name = "highscoreOutput";
            this.highscoreOutput.Size = new System.Drawing.Size(35, 13);
            this.highscoreOutput.TabIndex = 1;
            this.highscoreOutput.Text = "label1";
            // 
            // recentScoreOutput
            // 
            this.recentScoreOutput.AutoSize = true;
            this.recentScoreOutput.Location = new System.Drawing.Point(487, 200);
            this.recentScoreOutput.Name = "recentScoreOutput";
            this.recentScoreOutput.Size = new System.Drawing.Size(35, 13);
            this.recentScoreOutput.TabIndex = 2;
            this.recentScoreOutput.Text = "label1";
            // 
            // HighscoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperSnakeGame.Properties.Resources.fadeBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.recentScoreOutput);
            this.Controls.Add(this.highscoreOutput);
            this.Controls.Add(this.scoreTitle);
            this.Name = "HighscoreScreen";
            this.Size = new System.Drawing.Size(800, 550);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.HighscoreScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreTitle;
        private System.Windows.Forms.Label highscoreOutput;
        private System.Windows.Forms.Label recentScoreOutput;
    }
}
