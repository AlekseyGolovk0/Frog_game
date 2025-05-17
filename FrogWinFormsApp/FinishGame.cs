namespace FrogWinFormsApp
{
    public partial class FinishGame : Form
    {
        public FinishGame(string victoryText, int score)
        {
            InitializeComponent();

            victoryTextLabel.Text = victoryText;
            victoryTextLabel.Text += score.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
