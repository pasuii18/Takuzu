using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Media;

namespace Takuzu
{
    public delegate void SquareColor(int Index, Color Color, bool Lines); // event 
    public delegate void SquaresColorStatus(Color Color); // event 

    public partial class Form1 : Form
    {
        private readonly List<PictureBox> ListPictRows  = new List<PictureBox>(); // row info
        private readonly List<PictureBox> ListPictColumns = new List<PictureBox>(); // column info
        private List<ClassGameBox> ListOfMovesPlayed; // number of moves played
        private int SourceIndex, Size, OldSize, PrevField;

        public class ClassGameBox
        {
            public string SquareInfo { get; set; }
            public int IndexCase { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            playSimpleSound(); //music
            timer1.Start();
            Size = 8;
            OldSize = 8;
            InitializeGrid();
            // Solution.Visible = false;
            ListBoxNumber.Visible = false;
            GridUnchecked();

            // events in the class
            Takuzu.Square += SquaresColor;
            Takuzu.Squares += SquaresColorStatus;
        }
        private void InitializeGrid()
        {
            ClassGameField GameBox;
            PictureBox PictRow, PictColonne;
            int PositionLeft, PositionTop;
            int Index = 0;
            ListBoxNumber.Visible = false;
            GameField.Controls.Clear();
            GameField.Width = (40 * Size) + 10;
            GameField.Height = (40 * Size) + 10;
            GameField.Left = Convert.ToInt32(((Width - Selection.Width) / 2) - (GameField.Width / 2)) - 100;
            GameField.Top = Convert.ToInt32(((Height - 50) / 2) - (GameField.Height / 2));
            Takuzu.ListGameBoxes.Clear();
            PositionTop = 4;
            for (int i = 0; i <= Size - 1; i++)
            {
                PositionLeft = 4;
                for (int j = 0; j <= Size - 1; j++)
                {
                    GameBox = new ClassGameField(Index, PositionLeft, PositionTop);
                    GameBox.Click += new EventHandler(GameBoxClick);
                    Takuzu.ListGameBoxes.Add(GameBox);
                    GameField.Controls.Add(GameBox);
                    PositionLeft += 40;
                    Index += 1;
                }
                PositionTop += 40;
            }
            GameField.Visible = true;
            PositionLeft = GameField.Left + 15;
            PositionTop = GameField.Top + GameField.Width + 20;
            for (int i = 0; i <= Size - 1; i++)
            {
                PictColonne = new PictureBox
                {
                    Name = "PictColonne" + i.ToString(),
                    BackColor = Color.Lime,
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(20, 20),
                    Location = new Point(PositionLeft, PositionTop),
                    Enabled = false
                };
                Controls.Add(PictColonne);
                ListPictColumns.Add(PictColonne);
                PositionLeft += 40;
            }
            PositionLeft = GameField.Left + GameField.Width + 20;
            PositionTop = GameField.Top + 15;
            for (int i = 0; i <= Size - 1; i++)
            {
                PictRow = new PictureBox
                {
                    Name = "PictRow" + i.ToString(),
                    BackColor = Color.Lime,
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(20, 20),
                    Location = new Point(PositionLeft, PositionTop),
                    Enabled = false
                };
                Controls.Add(PictRow);
                ListPictRows.Add(PictRow);
                PositionTop += 40;
            }
            PrevField = -1;
        }
        private void GameBoxClick(object sender, EventArgs e)
        {
            if (PrevField != -1 && PrevField == SourceIndex)
                Takuzu.ListGameBoxes[PrevField].BackColor = Color.MediumPurple;
            Label CaseClick = (Label)sender;
            SourceIndex = Convert.ToInt32(CaseClick.Name.Substring(4));
            if (Takuzu.ListGameBoxes[SourceIndex].BackColor == Color.MediumPurple)
            {
                ListPictRows[SourceIndex / Size].BackColor = Color.Aqua; // incomplete line
                ListPictColumns[SourceIndex % Size].BackColor = Color.Aqua; // incomplete column
                // position the selection 0 or 1 for the box
                ListBoxNumber.Top = GameField.Top + CaseClick.Top + 40;
                ListBoxNumber.Left = GameField.Left + CaseClick.Left + 20;
                ListBoxNumber.Visible = true;
                ListBoxNumber.ClearSelected();
                CaseClick.BackColor = Color.MediumOrchid; // color after click on box
                PrevField = SourceIndex;
            }
            else
                ListBoxNumber.Visible = false;
        }
        private void Grid4_Click(object sender, EventArgs e)
        {
            GridUnchecked();
            CheckBox SelectionSize = (CheckBox)sender;
            Size = Convert.ToInt32(SelectionSize.Name.Substring(4));
            SelectionSize.Checked = true;
            NewGrid();
        }
        private void GridUnchecked()
        {
            foreach (CheckBox Ctrl in Selection.Controls)
            {
                if (Ctrl.Checked == true)
                {
                    Ctrl.Checked = false;
                }
            }
        }
        private void NewGrid()
        {
            DoubleBuffered = true;
            Cursor = Cursors.WaitCursor;
            // Solution.Visible = false;
            GameField.Controls.Clear();
            for (int i = 0; i <= OldSize - 1; i++)
            {
                Controls.Remove(ListPictRows[i]);
                Controls.Remove(ListPictColumns[i]);
            }
            ListPictRows.Clear();
            ListPictColumns.Clear();
            OldSize = Size;
            Selection.Visible = false;
            InitializeGrid();
            BackGround.RunWorkerAsync();
        }
        private void BackGround_DoWork(object sender, DoWorkEventArgs e)
        {
            Takuzu.BuildGrid(Size);
        }
        private void BackGround_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int Index = 0;
            // create the squares for the game
            for (int i = 0; i <= Size - 1; i++)
                for (int j = 0; j <= Size - 1; j++)
                {
                    Takuzu.ListGameBoxes[Index].Text = Takuzu.ListRowsPoses[i].Substring(j, 1);
                    Takuzu.ListGameBoxes[Index].Solution = Takuzu.ListGameBoxes[Index].Text;
                    Takuzu.ListGameBoxes[Index].BackColor = Color.BlueViolet; // color of fixed squares
                    Index += 1;
                }
            Takuzu.HideBoxes();
            Takuzu.TestGridCorrect();
            Cursor = Cursors.Default;
            // Solution.Visible = true;
            Selection.Visible = true;
            ListOfMovesPlayed = new List<ClassGameBox>();
        }
        private void SquaresColor(int Index, Color Color, bool Lines) 
        {
            if (Lines == true)
            {
                ListPictRows[Index].BackColor = Color;
            }
            else
            {
                ListPictColumns[Index].BackColor = Color;
            }
        }
        private void ListBoxNumber_Click(object sender, EventArgs e)
        {
            ListBoxNumber.Visible = false;
            string Number = ListBoxNumber.Items[ListBoxNumber.SelectedIndices[0]].ToString();
            ListOfMovesPlayed.Add(new ClassGameBox
            {
                SquareInfo = Takuzu.ListGameBoxes[SourceIndex].Text,
                IndexCase = SourceIndex
            });
            if (ListOfMovesPlayed.Count > 0)
            {
                StepBack.Visible = true;
            }
            Takuzu.ListGameBoxes[SourceIndex].Text = Number;
            Takuzu.ListGameBoxes[SourceIndex].BackColor = Color.MediumOrchid; // color of square after click on it
            Takuzu.ListGameBoxes[SourceIndex].Refresh();
            // test if the grid is correct
            if (Takuzu.TestGridCorrect() == true)
            {
                // test if all the boxes are filled
                if (Takuzu.ListGameBoxes.Where(n => n.Text == " ").Count() == 0)
                {
                    MessageBox.Show("You did it!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StepBack.Visible = false;
                }
            }
        }
        private void SquaresColorStatus(Color Color)  
        {
            for (int i = 0; i <= Size - 1; i++)
            {
                ListPictRows[i].BackColor = Color;
                ListPictColumns[i].BackColor = Color;
            }
        }

        private void Solution_Click(object sender, EventArgs e)
        {
            GridUnchecked();
            ListBoxNumber.Visible = false;
            if (PrevField != -1)
            {
                Takuzu.ListGameBoxes[PrevField].BackColor = Color.MediumPurple;
            }

            for (int i = 0; i <= Convert.ToInt32(Math.Pow(Size, 2)) - 1; i++)
            {
                Takuzu.ListGameBoxes[i].Text = Takuzu.ListGameBoxes[i].Solution;
            }

            SquaresColorStatus(Color.Lime);
            StepBack.Visible = false;
        }

        private void StepBack_Click(object sender, EventArgs e)
        {
            ClassGameBox StepBackSquare = ListOfMovesPlayed.Last();
            ListOfMovesPlayed.RemoveAt(ListOfMovesPlayed.Count - 1);
            Takuzu.ListGameBoxes[StepBackSquare.IndexCase].Text = StepBackSquare.SquareInfo;
            if (ListOfMovesPlayed.Count == 0)
            {
                StepBack.Visible = false;
            }
            Takuzu.TestGridCorrect();
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\SimpleSound.wav");
            simpleSound.Play();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            playSimpleSound(); //music
        }
    }
}
