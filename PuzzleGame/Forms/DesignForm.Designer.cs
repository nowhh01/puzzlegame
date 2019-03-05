namespace PuzzleGame.Forms
{
    partial class DesignForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxRows = new System.Windows.Forms.TextBox();
            this.textBoxColumns = new System.Windows.Forms.TextBox();
            this.labelRows = new System.Windows.Forms.Label();
            this.labelColumns = new System.Windows.Forms.Label();
            this.buttonWall = new System.Windows.Forms.Button();
            this.buttonPinkDoor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGreenDoor = new System.Windows.Forms.Button();
            this.buttonBlueDoor = new System.Windows.Forms.Button();
            this.buttonPurpleDoor = new System.Windows.Forms.Button();
            this.buttonPinkBox = new System.Windows.Forms.Button();
            this.buttonGreenBox = new System.Windows.Forms.Button();
            this.buttonBlueBox = new System.Windows.Forms.Button();
            this.buttonPurpleBox = new System.Windows.Forms.Button();
            this.buttonNone = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(916, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "None.png");
            this.imageList1.Images.SetKeyName(1, "Wall.png");
            this.imageList1.Images.SetKeyName(2, "PinkDoor.png");
            this.imageList1.Images.SetKeyName(3, "GreenDoor.png");
            this.imageList1.Images.SetKeyName(4, "BlueDoor.png");
            this.imageList1.Images.SetKeyName(5, "PurpleDoor.png");
            this.imageList1.Images.SetKeyName(6, "PinkBox.png");
            this.imageList1.Images.SetKeyName(7, "GreenBox.png");
            this.imageList1.Images.SetKeyName(8, "BlueBox.png");
            this.imageList1.Images.SetKeyName(9, "PurpleBox.png");
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonGenerate.Location = new System.Drawing.Point(452, 14);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(111, 23);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxRows
            // 
            this.textBoxRows.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxRows.Location = new System.Drawing.Point(63, 16);
            this.textBoxRows.Name = "textBoxRows";
            this.textBoxRows.Size = new System.Drawing.Size(107, 22);
            this.textBoxRows.TabIndex = 0;
            this.textBoxRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxColumns
            // 
            this.textBoxColumns.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxColumns.Location = new System.Drawing.Point(296, 16);
            this.textBoxColumns.Name = "textBoxColumns";
            this.textBoxColumns.Size = new System.Drawing.Size(111, 22);
            this.textBoxColumns.TabIndex = 1;
            this.textBoxColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelRows.Location = new System.Drawing.Point(15, 22);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(42, 13);
            this.labelRows.TabIndex = 3;
            this.labelRows.Text = "Rows";
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelColumns.Location = new System.Drawing.Point(228, 19);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(62, 13);
            this.labelColumns.TabIndex = 3;
            this.labelColumns.Text = "Columns";
            // 
            // buttonWall
            // 
            this.buttonWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWall.ImageIndex = 1;
            this.buttonWall.ImageList = this.imageList1;
            this.buttonWall.Location = new System.Drawing.Point(12, 174);
            this.buttonWall.Name = "buttonWall";
            this.buttonWall.Size = new System.Drawing.Size(130, 52);
            this.buttonWall.TabIndex = 4;
            this.buttonWall.Text = "Wall";
            this.buttonWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonWall.UseVisualStyleBackColor = true;
            this.buttonWall.Click += new System.EventHandler(this.imageButtons_Click);
            // 
            // buttonPinkDoor
            // 
            this.buttonPinkDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPinkDoor.ImageIndex = 2;
            this.buttonPinkDoor.ImageList = this.imageList1;
            this.buttonPinkDoor.Location = new System.Drawing.Point(12, 230);
            this.buttonPinkDoor.Name = "buttonPinkDoor";
            this.buttonPinkDoor.Size = new System.Drawing.Size(130, 52);
            this.buttonPinkDoor.TabIndex = 5;
            this.buttonPinkDoor.Text = "Pink Door";
            this.buttonPinkDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPinkDoor.UseVisualStyleBackColor = true;
            this.buttonPinkDoor.Click += new System.EventHandler(this.imageButtons_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelColumns);
            this.panel1.Controls.Add(this.labelRows);
            this.panel1.Controls.Add(this.textBoxColumns);
            this.panel1.Controls.Add(this.textBoxRows);
            this.panel1.Controls.Add(this.buttonGenerate);
            this.panel1.Location = new System.Drawing.Point(1, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 52);
            this.panel1.TabIndex = 5;
            // 
            // buttonGreenDoor
            // 
            this.buttonGreenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGreenDoor.ImageIndex = 3;
            this.buttonGreenDoor.ImageList = this.imageList1;
            this.buttonGreenDoor.Location = new System.Drawing.Point(12, 286);
            this.buttonGreenDoor.Name = "buttonGreenDoor";
            this.buttonGreenDoor.Size = new System.Drawing.Size(130, 52);
            this.buttonGreenDoor.TabIndex = 6;
            this.buttonGreenDoor.Text = "Green Door";
            this.buttonGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGreenDoor.UseVisualStyleBackColor = true;
            this.buttonGreenDoor.Click += new System.EventHandler(this.imageButtons_Click);
            // 
            // buttonBlueDoor
            // 
            this.buttonBlueDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBlueDoor.ImageIndex = 4;
            this.buttonBlueDoor.ImageList = this.imageList1;
            this.buttonBlueDoor.Location = new System.Drawing.Point(12, 342);
            this.buttonBlueDoor.Name = "buttonBlueDoor";
            this.buttonBlueDoor.Size = new System.Drawing.Size(130, 52);
            this.buttonBlueDoor.TabIndex = 7;
            this.buttonBlueDoor.Text = "Blue Door";
            this.buttonBlueDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBlueDoor.UseVisualStyleBackColor = true;
            this.buttonBlueDoor.Click += new System.EventHandler(this.imageButtons_Click);
            // 
            // buttonPurpleDoor
            // 
            this.buttonPurpleDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPurpleDoor.ImageIndex = 5;
            this.buttonPurpleDoor.ImageList = this.imageList1;
            this.buttonPurpleDoor.Location = new System.Drawing.Point(12, 398);
            this.buttonPurpleDoor.Name = "buttonPurpleDoor";
            this.buttonPurpleDoor.Size = new System.Drawing.Size(130, 52);
            this.buttonPurpleDoor.TabIndex = 8;
            this.buttonPurpleDoor.Text = "Purple Door";
            this.buttonPurpleDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPurpleDoor.UseVisualStyleBackColor = true;
            this.buttonPurpleDoor.Click += new System.EventHandler(this.imageButtons_Click);
            // 
            // buttonPinkBox
            // 
            this.buttonPinkBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPinkBox.ImageIndex = 6;
            this.buttonPinkBox.ImageList = this.imageList1;
            this.buttonPinkBox.Location = new System.Drawing.Point(12, 454);
            this.buttonPinkBox.Name = "buttonPinkBox";
            this.buttonPinkBox.Size = new System.Drawing.Size(130, 52);
            this.buttonPinkBox.TabIndex = 9;
            this.buttonPinkBox.Text = "Pink Box";
            this.buttonPinkBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPinkBox.UseVisualStyleBackColor = true;
            this.buttonPinkBox.Click += new System.EventHandler(this.imageButtons_Click);
            // 
            // buttonGreenBox
            // 
            this.buttonGreenBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGreenBox.ImageIndex = 7;
            this.buttonGreenBox.ImageList = this.imageList1;
            this.buttonGreenBox.Location = new System.Drawing.Point(12, 510);
            this.buttonGreenBox.Name = "buttonGreenBox";
            this.buttonGreenBox.Size = new System.Drawing.Size(130, 52);
            this.buttonGreenBox.TabIndex = 10;
            this.buttonGreenBox.Text = "Green Box";
            this.buttonGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGreenBox.UseVisualStyleBackColor = true;
            this.buttonGreenBox.Click += new System.EventHandler(this.imageButtons_Click);
            // 
            // buttonBlueBox
            // 
            this.buttonBlueBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBlueBox.ImageIndex = 8;
            this.buttonBlueBox.ImageList = this.imageList1;
            this.buttonBlueBox.Location = new System.Drawing.Point(12, 566);
            this.buttonBlueBox.Name = "buttonBlueBox";
            this.buttonBlueBox.Size = new System.Drawing.Size(130, 52);
            this.buttonBlueBox.TabIndex = 11;
            this.buttonBlueBox.Text = "Blue Box";
            this.buttonBlueBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBlueBox.UseVisualStyleBackColor = true;
            this.buttonBlueBox.Click += new System.EventHandler(this.imageButtons_Click);
            // 
            // buttonPurpleBox
            // 
            this.buttonPurpleBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPurpleBox.ImageIndex = 9;
            this.buttonPurpleBox.ImageList = this.imageList1;
            this.buttonPurpleBox.Location = new System.Drawing.Point(12, 624);
            this.buttonPurpleBox.Name = "buttonPurpleBox";
            this.buttonPurpleBox.Size = new System.Drawing.Size(130, 52);
            this.buttonPurpleBox.TabIndex = 12;
            this.buttonPurpleBox.Text = "Purple Box";
            this.buttonPurpleBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPurpleBox.UseVisualStyleBackColor = true;
            this.buttonPurpleBox.Click += new System.EventHandler(this.imageButtons_Click);
            // 
            // buttonNone
            // 
            this.buttonNone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNone.ImageIndex = 0;
            this.buttonNone.ImageList = this.imageList1;
            this.buttonNone.Location = new System.Drawing.Point(12, 116);
            this.buttonNone.Name = "buttonNone";
            this.buttonNone.Size = new System.Drawing.Size(130, 52);
            this.buttonNone.TabIndex = 3;
            this.buttonNone.Text = "None";
            this.buttonNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNone.UseVisualStyleBackColor = true;
            this.buttonNone.Click += new System.EventHandler(this.imageButtons_Click);
            // 
            // PuzzleDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(916, 731);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonPurpleBox);
            this.Controls.Add(this.buttonBlueBox);
            this.Controls.Add(this.buttonGreenBox);
            this.Controls.Add(this.buttonPurpleDoor);
            this.Controls.Add(this.buttonBlueDoor);
            this.Controls.Add(this.buttonPinkBox);
            this.Controls.Add(this.buttonPinkDoor);
            this.Controls.Add(this.buttonGreenDoor);
            this.Controls.Add(this.buttonWall);
            this.Controls.Add(this.buttonNone);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PuzzleDesignForm";
            this.Text = "Puzzle Design";
            this.Load += new System.EventHandler(this.mazeDesignerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxRows;
        private System.Windows.Forms.TextBox textBoxColumns;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.Button buttonNone;
        private System.Windows.Forms.Button buttonWall;
        private System.Windows.Forms.Button buttonPinkDoor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGreenDoor;
        private System.Windows.Forms.Button buttonBlueDoor;
        private System.Windows.Forms.Button buttonPurpleDoor;
        private System.Windows.Forms.Button buttonPinkBox;
        private System.Windows.Forms.Button buttonGreenBox;
        private System.Windows.Forms.Button buttonBlueBox;
        private System.Windows.Forms.Button buttonPurpleBox;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}