using System;
using System.Windows.Forms;
using PuzzleGame.Puzzles;

namespace PuzzleGame.Forms
{
    public partial class DesignForm : Form
    {
        private static readonly int msGridX = 250;
        private static readonly int msGridY = 115;

        private PuzzleDesign mPuzzleDesign;
        private PuzzleParameters mPuzzleParameters;

        private int mRow = 0;
        private int mColumn = 0;

        public DesignForm()
        {
            InitializeComponent();
        }

        private void mazeDesignerForm_Load(object sender, EventArgs e)
        {
            textBoxRows.Select();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Contains(mPuzzleDesign))
            {
                mPuzzleDesign.SaveFile();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open";
            openFileDialog1.Filter = "Puzzle File (*.txt)|*.txt";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    if (this.Contains(mPuzzleDesign))
                    {
                        this.Controls.Remove(mPuzzleDesign);
                    }

                    instantiatePuzzle();
                    mPuzzleDesign.OpenFile();
                }
                catch
                {
                    MessageBox.Show("Please open a right file", "Wrong File", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (this.Controls.Contains(mPuzzleDesign))
            {
                this.Controls.Remove(mPuzzleDesign);
            }

            try
            {
                mRow = int.Parse(textBoxRows.Text);
                mColumn = int.Parse(textBoxColumns.Text);

                instantiatePuzzle();
                mPuzzleDesign.DrawGrid();
            }
            catch
            {
                MessageBox.Show("Please provide valid data for rows and columns!\n" +
                    "(It must be integers)", "Maze Form", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void imageButtons_Click(object sender, EventArgs e)
        {
            if (this.Contains(mPuzzleDesign))
            {
                mPuzzleDesign.SelectedImageIndex = ((Button)sender).ImageIndex;
                mPuzzleDesign.IsImageChanged = true;
            }   
        }

        private void instantiatePuzzle()
        {
            mPuzzleParameters.Row = mRow;
            mPuzzleParameters.Column = mColumn;
            mPuzzleParameters.GridX = msGridX;
            mPuzzleParameters.GridY = msGridY;
            mPuzzleParameters.CurrentForm = this;
            mPuzzleParameters.Images = imageList1;
            mPuzzleParameters.SaveDialog = saveFileDialog1;
            mPuzzleParameters.OpenDialog = openFileDialog1;

            mPuzzleDesign = new PuzzleDesign(mPuzzleParameters);
        }
    }
}
