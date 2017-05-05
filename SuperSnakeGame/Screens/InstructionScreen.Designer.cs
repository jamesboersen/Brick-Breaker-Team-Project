namespace BrickBreaker.Screens
{
    partial class InstructionScreen
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.onePlayerLabel = new System.Windows.Forms.Label();
            this.secondPlayerLabel = new System.Windows.Forms.Label();
            this.bluePictureBox = new System.Windows.Forms.PictureBox();
            this.moveLeftLabel = new System.Windows.Forms.Label();
            this.moveRightLabel = new System.Windows.Forms.Label();
            this.powerupBox = new System.Windows.Forms.GroupBox();
            this.greenPictureBox = new System.Windows.Forms.PictureBox();
            this.powerupLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bluePictureBox)).BeginInit();
            this.powerupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionLabel.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.instructionLabel.Location = new System.Drawing.Point(195, 26);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(411, 110);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Instructions";
            // 
            // onePlayerLabel
            // 
            this.onePlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.onePlayerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.onePlayerLabel.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onePlayerLabel.ForeColor = System.Drawing.Color.Red;
            this.onePlayerLabel.Location = new System.Drawing.Point(35, 459);
            this.onePlayerLabel.Name = "onePlayerLabel";
            this.onePlayerLabel.Size = new System.Drawing.Size(362, 78);
            this.onePlayerLabel.TabIndex = 1;
            this.onePlayerLabel.Text = "1 Player";
            this.onePlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondPlayerLabel
            // 
            this.secondPlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.secondPlayerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secondPlayerLabel.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondPlayerLabel.ForeColor = System.Drawing.Color.White;
            this.secondPlayerLabel.Location = new System.Drawing.Point(403, 459);
            this.secondPlayerLabel.Name = "secondPlayerLabel";
            this.secondPlayerLabel.Size = new System.Drawing.Size(362, 78);
            this.secondPlayerLabel.TabIndex = 2;
            this.secondPlayerLabel.Text = "2 Player";
            this.secondPlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bluePictureBox
            // 
            this.bluePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bluePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.bluePictureBox.BackgroundImage = global::SuperSnakeGame.Properties.Resources.joystick_part_2;
            this.bluePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bluePictureBox.ImageLocation = "";
            this.bluePictureBox.InitialImage = null;
            this.bluePictureBox.Location = new System.Drawing.Point(88, 222);
            this.bluePictureBox.Name = "bluePictureBox";
            this.bluePictureBox.Size = new System.Drawing.Size(260, 221);
            this.bluePictureBox.TabIndex = 3;
            this.bluePictureBox.TabStop = false;
            // 
            // moveLeftLabel
            // 
            this.moveLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.moveLeftLabel.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.moveLeftLabel.Location = new System.Drawing.Point(116, 368);
            this.moveLeftLabel.Name = "moveLeftLabel";
            this.moveLeftLabel.Size = new System.Drawing.Size(105, 55);
            this.moveLeftLabel.TabIndex = 5;
            this.moveLeftLabel.Text = "Move Left";
            // 
            // moveRightLabel
            // 
            this.moveRightLabel.BackColor = System.Drawing.Color.Transparent;
            this.moveRightLabel.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.moveRightLabel.Location = new System.Drawing.Point(215, 368);
            this.moveRightLabel.Name = "moveRightLabel";
            this.moveRightLabel.Size = new System.Drawing.Size(124, 55);
            this.moveRightLabel.TabIndex = 6;
            this.moveRightLabel.Text = "Move Right";
            // 
            // powerupBox
            // 
            this.powerupBox.BackColor = System.Drawing.Color.Transparent;
            this.powerupBox.Controls.Add(this.greenPictureBox);
            this.powerupBox.Controls.Add(this.powerupLabel);
            this.powerupBox.Location = new System.Drawing.Point(403, 126);
            this.powerupBox.Name = "powerupBox";
            this.powerupBox.Size = new System.Drawing.Size(362, 317);
            this.powerupBox.TabIndex = 7;
            this.powerupBox.TabStop = false;
            // 
            // greenPictureBox
            // 
            this.greenPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.greenPictureBox.BackgroundImage = global::SuperSnakeGame.Properties.Resources.green_250x250;
            this.greenPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenPictureBox.InitialImage = null;
            this.greenPictureBox.Location = new System.Drawing.Point(50, 19);
            this.greenPictureBox.Name = "greenPictureBox";
            this.greenPictureBox.Size = new System.Drawing.Size(100, 100);
            this.greenPictureBox.TabIndex = 8;
            this.greenPictureBox.TabStop = false;
            // 
            // powerupLabel
            // 
            this.powerupLabel.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.powerupLabel.Location = new System.Drawing.Point(83, 35);
            this.powerupLabel.Name = "powerupLabel";
            this.powerupLabel.Size = new System.Drawing.Size(350, 72);
            this.powerupLabel.TabIndex = 0;
            this.powerupLabel.Text = "POWERUPS";
            this.powerupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstructionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperSnakeGame.Properties.Resources.fadeBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.powerupBox);
            this.Controls.Add(this.moveRightLabel);
            this.Controls.Add(this.moveLeftLabel);
            this.Controls.Add(this.bluePictureBox);
            this.Controls.Add(this.secondPlayerLabel);
            this.Controls.Add(this.onePlayerLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "InstructionScreen";
            this.Size = new System.Drawing.Size(800, 550);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.InstructionScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bluePictureBox)).EndInit();
            this.powerupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.greenPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label onePlayerLabel;
        private System.Windows.Forms.Label secondPlayerLabel;
        private System.Windows.Forms.PictureBox bluePictureBox;
        private System.Windows.Forms.Label moveLeftLabel;
        private System.Windows.Forms.Label moveRightLabel;
        private System.Windows.Forms.GroupBox powerupBox;
        private System.Windows.Forms.Label powerupLabel;
        private System.Windows.Forms.PictureBox greenPictureBox;
    }
}
