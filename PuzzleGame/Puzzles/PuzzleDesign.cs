using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PuzzleGame.Puzzles
{
    class PuzzleDesign : Puzzle
    {
        private readonly Pen mPen = new Pen(Color.Black);

        public PuzzleDesign(in PuzzleParameters puzzleParameters)
            : base(puzzleParameters)
        {
        }

        public override void AddPictureBox(int rowIndex, int columnIndex)
        {
            base.AddPictureBox(rowIndex, columnIndex);

            NewPictureBox.MouseEnter += pictureBox_MouseEnter;
            NewPictureBox.Click += pictureBox_Click;
        }

        public override void DrawGrid()
        {
            base.DrawGrid();

            this.BorderStyle = BorderStyle.FixedSingle;
            this.Paint += puzzle_Paint;
            this.MouseMove += puzzleDesign_MouseMove;
        }

        private void puzzle_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 1; i < Row; i++)
            {
                Point[] points =
                {
                     new Point(0, CellHeight * i),
                     new Point(CellWidth * Column, CellHeight * i)
                };

                e.Graphics.DrawLines(mPen, points);
            }

            for (int i = 1; i < Column; i++)
            {
                Point[] points =
                {
                     new Point(CellWidth * i, 0),
                     new Point(CellWidth * i, CellHeight * Row)
                };

                e.Graphics.DrawLines(mPen, points);
            }
        }

        private void puzzleDesign_MouseMove(object sender, MouseEventArgs e)
        {
            if (SelectedImageIndex != -1)
            {
                if (!this.Contains(Preview))
                {
                    Preview = new PictureBox
                    {
                        Size = new Size(44, 44),
                        BackColor = Color.Transparent
                    };

                    Preview.Click += preview_Click;
                    CurrentForm.MouseEnter += currentForm_MouseEnter;
                    this.Controls.Add(Preview);
                }

                if (IsImageChanged)
                {
                    AlterTransparency(Images.Images[SelectedImageIndex]);
                    IsImageChanged = false;
                }

                PreviewX = (e.Location.X / CellWidth) * CellWidth;
                PreviewY = (e.Location.Y / CellHeight) * CellHeight;
                Preview.Location = new Point(PreviewX, PreviewY);
            }
        }

        private void preview_Click(object sender, EventArgs e)
        {
            if (SelectedImageIndex > 0)
            {
                int rowIndex = PreviewY / CellHeight;
                int columnIndex = PreviewX / CellWidth;

                AddPictureBox(rowIndex, columnIndex);
            }
            this.Controls.Remove(Preview);
            IsImageChanged = true;
        }

        private void currentForm_MouseEnter(object sender, EventArgs e)
        {
            this.Controls.Remove(Preview);
            IsImageChanged = true;
            CurrentForm.MouseEnter -= currentForm_MouseEnter;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            if (SelectedImageIndex != -1)
            {
                MatchCollection rowColumn = Regex.Matches(pictureBox.Name, @"\d+");
                int row = int.Parse(rowColumn[0].ToString());
                int column = int.Parse(rowColumn[1].ToString());

                if (SelectedImageIndex == 0)
                {
                    this.Controls.Remove(pictureBox);
                }
                else if (pictureBox.Image != Images.Images[SelectedImageIndex])
                {
                    pictureBox.Image = Images.Images[SelectedImageIndex];
                }

                Map[row, column] = SelectedImageIndex;
            }
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (this.Contains(Preview))
            {
                this.Controls.Remove(Preview);
                IsImageChanged = true;
            }
        }
    }
}
