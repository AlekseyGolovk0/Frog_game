namespace FrogWinFormsApp
{
    public partial class MainForm : Form
    {
        private int _swapCount = 0;
        private string _victoryText;
        private const int _allPictureBoxCount = 9;
        private const int _rightPictureBoxCount = 4;
        private const int _leftPictureBoxCount = 4;
        private const int _emptyPictureBoxCount = 1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void emptyPictureBox_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);
        }

        private void Swap(PictureBox pictureBox)
        {
            var correctDistance = Math.Abs(pictureBox.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Width;
            if (correctDistance > 2)
            {
                MessageBox.Show("Неправильные лягушки");
            }
            else
            {
                _swapCount++;
                swapCountLabel.Text = _swapCount.ToString();

                var location = emptyPictureBox.Location;
                emptyPictureBox.Location = pictureBox.Location;
                pictureBox.Location = location;
                ChekEndGame();
            }
        }

        private void ChekEndGame()
        {
            if (ChekLeftPictureBox(leftPictureBox1) && ChekLeftPictureBox(leftPictureBox2)
                && ChekLeftPictureBox(leftPictureBox3) && ChekLeftPictureBox(leftPictureBox4)
                && ChekRightPictureBox(rightPictureBox1) && ChekRightPictureBox(rightPictureBox2)
                && ChekRightPictureBox(rightPictureBox3) && ChekRightPictureBox(rightPictureBox4))
            {
                if (_swapCount == 24)
                {
                    _victoryText = "Ура вы выиграли за минимальное число шагов : ";
                }
                else
                {
                    _victoryText = "Ура вы выиграли, но не за минимальное число шагов : ";
                }
                var finishGame = new FinishGame(_victoryText, _swapCount);
                finishGame.ShowDialog();
            }


        }

        private bool ChekLeftPictureBox(PictureBox pictureBox)
        {
            if (pictureBox.Location.X <= pictureBox.Width * _leftPictureBoxCount - pictureBox.Width * _emptyPictureBoxCount)
            {
                return true;
            }
            return false;
        }
        private bool ChekRightPictureBox(PictureBox pictureBox)
        {
            if (pictureBox.Location.X >= pictureBox.Width * _rightPictureBoxCount + pictureBox.Width * _emptyPictureBoxCount)
            {
                return true;
            }
            return false;
        }

    }
}
