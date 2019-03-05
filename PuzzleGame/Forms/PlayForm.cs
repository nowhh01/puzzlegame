using System;
using System.Windows.Forms;
using PuzzleGame.Puzzles;

namespace PuzzleGame.Forms
{
    public partial class PlayForm : Form
    {
        private static readonly int msGridX = 100;
        private static readonly int msGridY = 100;

        private PuzzlePlay mPuzzlePlay;
        private PuzzleParameters mPuzzleParameters;

        private int mRow = 0;
        private int mColumn = 0;

        public PlayForm()
        {
            InitializeComponent();
        }

        private void fileLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open";
            openFileDialog1.Filter = "Puzzle File (*.txt)|*.txt";
            DialogResult result = openFileDialog1.ShowDialog();
            
            if(result == DialogResult.OK)
            { 
                try
                {
                    if (this.Contains(mPuzzlePlay))
                    {
                        this.Controls.Remove(mPuzzlePlay);
                        textBoxMoves.Text = null;
                    }

                    mPuzzleParameters.Row = mRow;
                    mPuzzleParameters.Column = mColumn;
                    mPuzzleParameters.GridX = msGridX;
                    mPuzzleParameters.GridY = msGridY;
                    mPuzzleParameters.CurrentForm = this;
                    mPuzzleParameters.Images = imageList1;
                    mPuzzleParameters.SaveDialog = saveFileDialog1;
                    mPuzzleParameters.OpenDialog = openFileDialog1;

                    mPuzzlePlay = new PuzzlePlay(mPuzzleParameters, timer1, 
                        textBoxMoves, checkBoxAnimation);
                    mPuzzlePlay.OpenFile();
                }
                catch
                {
                    MessageBox.Show("Please open a right file", "Wrong File", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            mPuzzlePlay.MoveBox(mPuzzlePlay.SelectedPictureBox, eDirection.Up);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            mPuzzlePlay.MoveBox(mPuzzlePlay.SelectedPictureBox, eDirection.Down);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            mPuzzlePlay.MoveBox(mPuzzlePlay.SelectedPictureBox, eDirection.Left);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            mPuzzlePlay.MoveBox(mPuzzlePlay.SelectedPictureBox, eDirection.Right);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
