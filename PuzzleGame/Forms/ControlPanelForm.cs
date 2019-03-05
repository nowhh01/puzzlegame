using System;
using System.Windows.Forms;

namespace PuzzleGame.Forms
{
    public partial class ControlPanelForm : Form
    {
        private DesignForm mDesignform;
        private PlayForm mPlayform;

        public ControlPanelForm()
        {
            InitializeComponent();
        }

        private void buttonDesigns_Click(object sender, EventArgs e)
        {
            mDesignform = new DesignForm();
            mDesignform.Show();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            mPlayform = new PlayForm();
            mPlayform.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();   
        }
    }
}
