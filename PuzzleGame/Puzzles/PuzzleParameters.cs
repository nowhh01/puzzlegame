using System.Windows.Forms;

namespace PuzzleGame.Puzzles
{
    struct PuzzleParameters
    {
        public ImageList Images { get; set; }
        public Form CurrentForm { get; set; }
        public SaveFileDialog SaveDialog { get; set; }
        public OpenFileDialog OpenDialog { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public int GridX { get; set; }
        public int GridY { get; set; }

    }
}
