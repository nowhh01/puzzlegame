using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace PuzzleGame.Puzzles
{
    enum eImageType
    {
        None,
        Wall,
        PinkDoor,
        GreenDoor,
        BlueDoor,
        PurpleDoor,
        PinkBox,
        GreenBox,
        BlueBox,
        PurpleBox
    }

    enum eDirection
    {
        None,
        Up,
        Down,
        Left,
        Right
    }

    class Puzzle : PictureBox
    {
        public static readonly int CellWidth = 45;
        public static readonly int CellHeight = 45;
        public static readonly char Delimiter = ',';

        private readonly int mGridX;
        private readonly int mGridY;

        private readonly SaveFileDialog mSaveFileDialog;
        private readonly OpenFileDialog mOpenFileDialog;

        public ImageList Images { get; private set; }
        public Form CurrentForm { get; private set; }
        public PictureBox NewPictureBox { get; protected set; }
        public PictureBox SelectedPictureBox { get; protected set; }
        public PictureBox Preview { get; protected set; }
        
        public int Row { get; private set; }
        public int Column { get; private set; }
        public int PreviewX { get; protected set; }
        public int PreviewY { get; protected set; }
        public int[,] Map { get; protected set; }
        public int SelectedImageIndex { get; set; }
        public bool IsImageChanged { get; set; }

        public Puzzle(in PuzzleParameters puzzleParameters)
        {
            Row = puzzleParameters.Row;
            Column = puzzleParameters.Column;
            mGridX = puzzleParameters.GridX;
            mGridY = puzzleParameters.GridY;

            CurrentForm = puzzleParameters.CurrentForm;
            Images = puzzleParameters.Images;
            mSaveFileDialog = puzzleParameters.SaveDialog;
            mOpenFileDialog = puzzleParameters.OpenDialog;
        }

        public virtual void AddPictureBox(int rowIndex, int columnIndex)
        {
            int pointX = columnIndex * CellWidth;
            int pointY = rowIndex * CellHeight;

            NewPictureBox = new PictureBox
            {
                Name = "pictureBox" + rowIndex + "x" + columnIndex,
                Size = new Size(44, 44),
                Location = new Point(pointX, pointY)
            };

            NewPictureBox.Image = Images.Images[SelectedImageIndex];
            Map[rowIndex, columnIndex] = SelectedImageIndex;

            this.Controls.Add(NewPictureBox);
        }

        public virtual void DrawGrid()
        {
            SelectedImageIndex = -1;
            Map = new int[Row, Column];

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    Map[i, j] = 0;
                }
            }

            for (int i = 0; i < Images.Images.Count; i++)
            {
                Images.Images[i] = GetImageConverted(Images.Images[i]);
            }

            IsImageChanged = false;
            this.Location = new Point(mGridX, mGridY);
            this.Size = new Size(CellWidth * Column, CellHeight * Row);

            CurrentForm.Controls.Add(this);
        }

        public Image GetImageConverted(in Image originalImage)
        {
            Bitmap convertedImage = new Bitmap(this.Width, this.Height);

            using (Graphics graphics = Graphics.FromImage(convertedImage))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(originalImage, 0, 0, 45, 45);
            }

            return convertedImage;
        }

        public void AlterTransparency(in Image originalImage)
        {
            Bitmap Original = new Bitmap(originalImage);
            Bitmap TransparentImage = new Bitmap(Preview.Width, Preview.Height);

            Color c = Color.Black;
            Color t = Color.Black;

            for (int x = 0; x < Preview.Width; x++)
            {
                for (int y = 0; y < Preview.Height; y++)
                {
                    c = Original.GetPixel(x, y);
                    t = Color.FromArgb(40, c.R, c.G, c.B);
                    TransparentImage.SetPixel(x, y, t);
                }
            }

            Preview.Image = TransparentImage;
        }

        public void OpenFile()
        {
            using (StreamReader streamReader = 
                File.OpenText(mOpenFileDialog.FileName))
            {
                string[] rowColumn = streamReader.ReadLine().Split('x');
                int fileRow = 0;

                Row = int.Parse(rowColumn[0]);
                Column = int.Parse(rowColumn[1]);

                DrawGrid();

                while (!streamReader.EndOfStream)
                {
                    string[] line = streamReader.ReadLine().Split(Delimiter);

                    for (int fileColumn = 0; fileColumn < line.Count(); fileColumn++)
                    {
                        SelectedImageIndex = int.Parse(line[fileColumn]);

                        if (SelectedImageIndex == 0)
                        {
                            continue;
                        }

                        AddPictureBox(fileRow, fileColumn);
                    }

                    fileRow++;
                }
            }

            SelectedImageIndex = -1;
        }

        public void SaveFile()
        {
            mSaveFileDialog.Title = "Save";
            mSaveFileDialog.Filter = "Notepad (*.txt)|*.txt";
            mSaveFileDialog.ShowDialog();

            if (mSaveFileDialog.FileName != "")
            {
                using (StreamWriter sw = File.CreateText(mSaveFileDialog.FileName))
                {
                    sw.WriteLine(Row + "x" + Column);

                    for (int i = 0; i < Row; i++)
                    {
                        for (int j = 0; j < Column; j++)
                        {
                            sw.Write(Map[i, j].ToString());

                            if (Map.GetUpperBound(1) != j)
                            {
                                sw.Write(",");
                            }
                        }
                        sw.WriteLine();
                    }
                }
                CurrentForm.Text = mSaveFileDialog.FileName;
                MessageBox.Show("Saved successfully");
            }
        }
    }
}
