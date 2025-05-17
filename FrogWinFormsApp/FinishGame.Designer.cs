namespace FrogWinFormsApp
{
    partial class FinishGame
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
            victoryTextLabel = new Label();
            exitButton = new Button();
            restartButton = new Button();
            winPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)winPictureBox).BeginInit();
            SuspendLayout();
            // 
            // victoryTextLabel
            // 
            victoryTextLabel.Font = new Font("Calibri", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            victoryTextLabel.Location = new Point(65, 395);
            victoryTextLabel.Name = "victoryTextLabel";
            victoryTextLabel.Size = new Size(302, 67);
            victoryTextLabel.TabIndex = 0;
            victoryTextLabel.Text = "Ура вы выйграли, но не за минимальное число шагов : ";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(12, 457);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(110, 48);
            exitButton.TabIndex = 1;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // restartButton
            // 
            restartButton.Location = new Point(306, 457);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(124, 48);
            restartButton.TabIndex = 2;
            restartButton.Text = "Рестарт";
            restartButton.UseVisualStyleBackColor = true;
            restartButton.Click += restartButton_Click;
            // 
            // winPictureBox
            // 
            winPictureBox.Image = Properties.Resources.Win;
            winPictureBox.Location = new Point(0, 0);
            winPictureBox.Name = "winPictureBox";
            winPictureBox.Size = new Size(441, 392);
            winPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            winPictureBox.TabIndex = 3;
            winPictureBox.TabStop = false;
            // 
            // FinishGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 517);
            Controls.Add(winPictureBox);
            Controls.Add(restartButton);
            Controls.Add(exitButton);
            Controls.Add(victoryTextLabel);
            Name = "FinishGame";
            Text = "RestartGame";
            ((System.ComponentModel.ISupportInitialize)winPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label victoryTextLabel;
        private Button exitButton;
        private Button restartButton;
        private PictureBox winPictureBox;
    }
}