using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Takuzu
{
    public class ClassGameField : Label
    {
        public string Solution { get; set; }

        // constructure 
        public ClassGameField(int Index, int PositionLeft, int PositionTop)
        {
            BackColor = Color.Pink;
            ForeColor = Color.Plum;
            Name = "Case" + Index.ToString();
            Size = new Size(40, 40);
            Location = new Point(PositionLeft, PositionTop);
            BorderStyle = BorderStyle.FixedSingle;
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("lazer84", 21);
            Solution = string.Empty;
            Text = " ";
        }

        // initial starting field
        public static void EmptyBoxes(int IndexCase, List<ClassGameField> GameField) 
        {
            GameField[IndexCase].Text = " ";
            GameField[IndexCase].BackColor = Color.MediumPurple;
        }
    }
}