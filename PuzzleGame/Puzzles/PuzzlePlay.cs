using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PuzzleGame.Puzzles
{
    class PuzzlePlay : Puzzle
    {
        private EventHandler mAnimateBoxEventHandler;
        private EventHandler mCheckMouseLocationEventHandler;

        private Timer mTimer;
        private TextBox mTextBoxMoves;
        private CheckBox mCheckBoxAnimation;

        private eDirection mBoxDirection;

        private int mLeftBoxes = 0;
        private int mNumberOfMove = 0;
        private int mCurrentMouseX = 0;
        private int mCurrentMouseY = 0;
        private bool mbMouseUp = true;
        private bool mbDragging = false;

        public PuzzlePlay(in PuzzleParameters puzzleParameters, in Timer timer, 
            in TextBox textBoxMoves, in CheckBox checkBoxAnimation) 
            : base(puzzleParameters)
        {
            mTimer = timer;
            mTextBoxMoves = textBoxMoves;
            mCheckBoxAnimation = checkBoxAnimation;
        }
        
        public override void AddPictureBox(int rowIndex, int columnIndex)
        {
            base.AddPictureBox(rowIndex, columnIndex);

            if (((eImageType)SelectedImageIndex).ToString().Contains("Box"))
            {
                mLeftBoxes++;
                NewPictureBox.MouseDown += pictureBox_MouseDown;
                NewPictureBox.MouseUp += pictureBox_MouseUp;
            }

            NewPictureBox = default;
        }

        public override void DrawGrid()
        {
            base.DrawGrid();

            mTimer.Start();
            ChangeControlsState(true);
        }

        public void ChangeControlsState(in bool isEnabled)
        {
            foreach (Button btn in CurrentForm.Controls.OfType<Button>())
            {
                btn.Enabled = isEnabled;
            }

            mCheckBoxAnimation.Enabled = isEnabled;
        }

        public void DisplayPreview(in int mouseX, in int mouseY)
        {
            eDirection direction;
            double angle = Math.Atan2(mouseY - (CellHeight / 2), 
                mouseX - (CellWidth / 2)) * (180 / Math.PI);

            if (angle <= -45 && angle >= -135)
                direction = eDirection.Up;
            else if (angle >= 45 && angle <= 135)
                direction = eDirection.Down;
            else if (Math.Abs(angle) > 135)
                direction = eDirection.Left;
            else
                direction = eDirection.Right;

            if (mBoxDirection != direction)
            {
                if (!this.Contains(Preview))
                {
                    Preview = new PictureBox
                    {
                        Size = new Size(44, 44),
                        BackColor = Color.Transparent,
                        Location = SelectedPictureBox.Location
                    };

                    AlterTransparency(Images.Images[SelectedImageIndex]);
                    this.Controls.Add(Preview);
                }

                Preview.Location = SelectedPictureBox.Location;
                mBoxDirection = direction;
                MoveBox(Preview, direction);
            }
        }

        public void MoveBox(PictureBox pictureBox, eDirection direction)
        {
            int imgOfCell = 0;
            int currentRow = pictureBox.Location.Y / CellHeight;
            int currentColumn = pictureBox.Location.X / CellWidth;
            int moveToRow = 0;
            int moveToColumn = 0;
            int moveToX = 0;
            int moveToY = 0;
            int differenceOfRow = 0;
            int differenceOfColumn = 0;

            string pictureBoxImg = 
                ((eImageType)Map[currentRow, currentColumn]).ToString();
            string boxImgColor = 
                Regex.Match(pictureBoxImg, @"(\D+)Box").Groups[1].Value;

            switch (direction)
            {
                case eDirection.Up:
                    for (int i = currentRow - 1; i >= 0; i--)
                    {
                        imgOfCell = Map[i, currentColumn];

                        if (imgOfCell != 0)
                        {
                            moveToRow = i + 1;
                            moveToColumn = currentColumn;
                            break;
                        }
                    }
                    break;
                case eDirection.Down:
                    for (int i = currentRow + 1; i < Row; i++)
                    {
                        imgOfCell = Map[i, currentColumn];

                        if (imgOfCell != 0)
                        {
                            moveToRow = i - 1;
                            moveToColumn = currentColumn;
                            break;
                        }
                    }
                    break;
                case eDirection.Left:
                    for (int i = currentColumn - 1; i >= 0; i--)
                    {
                        imgOfCell = Map[currentRow, i];

                        if (imgOfCell != 0)
                        {
                            moveToRow = currentRow;
                            moveToColumn = i + 1;
                            break;
                        }
                    }
                    break;
                case eDirection.Right:
                    for (int i = currentColumn + 1; i < Column; i++)
                    {
                        imgOfCell = Map[currentRow, i];

                        if (imgOfCell != 0)
                        {
                            moveToRow = currentRow;
                            moveToColumn = i - 1;
                            break;
                        }
                    }
                    break;
                default:
                    break;
            }

            moveToX = moveToColumn * CellWidth;
            moveToY = moveToRow * CellHeight;
            differenceOfRow = moveToRow - currentRow;
            differenceOfColumn = moveToColumn - currentColumn;

            if (mCheckBoxAnimation.Checked && pictureBox != Preview)
            {
                mAnimateBoxEventHandler
                    = new EventHandler(delegate (object sender, EventArgs e)
                    {
                        if (differenceOfColumn != 0)
                        {
                            int way = (int)(differenceOfColumn / Math.Abs(differenceOfColumn));
                            pictureBox.Left += CellWidth * way;
                            differenceOfColumn -= way;
                        }

                        if (differenceOfRow != 0)
                        {
                            int way = (int)(differenceOfRow / Math.Abs(differenceOfRow));
                            pictureBox.Top += CellHeight * way;
                            differenceOfRow -= way;
                        }

                        if (differenceOfRow == 0 && differenceOfColumn == 0)
                        {
                            if (((eImageType)imgOfCell).ToString() == boxImgColor + "Door")
                            {
                                this.Controls.Remove(pictureBox);
                            }

                            mTimer.Tick -= mAnimateBoxEventHandler;
                        }
                    });

                mTimer.Tick += mAnimateBoxEventHandler;
            }
            else
            {
                pictureBox.Location = new Point(moveToX, moveToY);
            }

            if (((eImageType)imgOfCell).ToString() == boxImgColor + "Door")
            {
                if (!mCheckBoxAnimation.Checked)
                {
                    this.Controls.Remove(pictureBox);
                }

                if (pictureBox != Preview)
                {
                    mLeftBoxes--;
                    mNumberOfMove++;
                    Map[currentRow, currentColumn] = 0;
                }
            }
            else
            {
                if (pictureBox != Preview)
                {
                    if (currentRow != moveToRow || currentColumn != moveToColumn)
                    {
                        mNumberOfMove++;
                    }

                    Map[currentRow, currentColumn] = 0;
                    Map[moveToRow, moveToColumn] = SelectedImageIndex;
                }
            }

            mTextBoxMoves.Text = mNumberOfMove.ToString();

            if (mLeftBoxes == 0)
            {
                MessageBox.Show($"Congratulation! You've finished it with moving boxes " +
                    $"{mNumberOfMove} times!", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                mTextBoxMoves.Text = null;
                CurrentForm.Controls.Remove(this);
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            int rowInx = pb.Location.Y / CellHeight;
            int columnIndex = pb.Location.X / CellWidth;

            SelectedImageIndex = Map[rowInx, columnIndex];
            SelectedPictureBox = pb;
            mbMouseUp = false;

            if (e.Button == MouseButtons.Left)
            {
                SelectedPictureBox.MouseMove += pictureBox_MouseMove;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mbMouseUp)
            {
                mTimer.Tick += mCheckMouseLocationEventHandler;
            }

            mCheckMouseLocationEventHandler
                = new EventHandler(delegate (object s, EventArgs eA)
                {
                    if (!mbMouseUp)
                    {
                        mCurrentMouseX = e.X;
                        mCurrentMouseY = e.Y;

                        if ((mCurrentMouseX < 0 || mCurrentMouseX > 44) ||
                        (mCurrentMouseY < 0 || mCurrentMouseY > 44))
                        {
                            mbDragging = true;
                            DisplayPreview(mCurrentMouseX, mCurrentMouseY);
                        }
                        else
                        {
                            mbDragging = false;
                            mBoxDirection = eDirection.None;

                            if (this.Contains(Preview))
                            {
                                this.Controls.Remove(Preview);
                            }
                        }

                        mTimer.Tick -= mCheckMouseLocationEventHandler;
                    }
                });
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            mbMouseUp = true;
            SelectedPictureBox.MouseMove -= pictureBox_MouseMove;

            if (mbDragging)
            {
                this.Controls.Remove(Preview);
                MoveBox(SelectedPictureBox, mBoxDirection);
                mbDragging = false;
            }
        }
    }
}
