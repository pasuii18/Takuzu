using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Takuzu
{
    public class Takuzu
    {
        public static event SquareColor Square; //event signaling the state of a line or a column of the game
        public static event SquaresColorStatus Squares; // event putting in green all the Lines and columns status

        public static readonly List<ClassGameField> ListGameBoxes = new List<ClassGameField>(); // the game squares

        public static List<string> ListRowsPoses = new List<string>(); // the rows placed
        public static List<string> ListColumnsPoses = new List<string>(); // the columns placed
        public static List<string> ListRowsCombinations = new List<string>(); // the possible row combinations
        private static int IndexRowCombination; // index of the random row combination
        private static int GridSize; // grid size
        private static int MaxNumberOfNumbers; // maximum number of 0 or 1 ( = size divided by 2 )
        // private static int Seed; // seed of the map
        public Takuzu()
        { 
        }

        public static bool TestGridCorrect()
        {
            string Column, Row;
            Squares(Color.Aqua);

            // rows and the columns to test
            List<string> ListRowsCompleted = new List<string>();
            List<string> ListColumnsCompleted = new List<string>();
            List<int> TestRowNumbers = new List<int>();
            List<int> TestColumnsNumbers = new List<int>();
            for (int i = 0; i <= GridSize - 1; i++)
            {
                Column = string.Empty;
                Row = string.Empty;
                for (int j = 0; j <= GridSize - 1; j++)
                {
                    Row += ListGameBoxes[(i * GridSize) + j].Text;
                    Column += ListGameBoxes[i + (j * GridSize)].Text;
                }

                // Test if the rows or the columns are compliant (no "000" or "111" and number of 0 equals number of 1 in the row or column)
                if (Row.Contains(" ") == false)
                {
                    if (ErrorsFound(Row, i, true) == false) // for rows
                    {
                        return false;
                    }
                    ListRowsCompleted.Add(Row);
                    TestRowNumbers.Add(i);
                }
                else
                {
                    if (TestRowColumn(Row, i, true) == false)
                    {
                        return false;
                    }
                }

                if (Column.Contains(" ") == false)
                {
                    if (ErrorsFound(Column, i, false) == false) // for columns
                        return false;
                    ListColumnsCompleted.Add(Column);
                    TestColumnsNumbers.Add(i);
                }
                else
                {

                    if (TestRowColumn(Column, i, false) == false)
                    {
                        return false;
                    }
                }
            }

            // test if 2 identical rows and 2 identical columns (only on complete Lines (True) or Columns (False))
            return (Identical(ListRowsCompleted, TestRowNumbers, true) || Identical(ListColumnsCompleted, TestColumnsNumbers, false));
        }
               
        private static bool Identical(List<string> ListOfIdenticalStrings, List<int> ListOfIdentical, bool BoolRow)
        {
            if (ListOfIdenticalStrings.Count > 1)
            {
                for (int i = 0; i <= ListOfIdenticalStrings.Count - 2; i++)
                {
                    for (int j = i + 1; j <= ListOfIdenticalStrings.Count - 1; j++)
                    {
                        if (ListOfIdenticalStrings[i] == ListOfIdenticalStrings[j])
                        {
                            // 2 rows or columns are identical
                            Square(ListOfIdentical[i], Color.Violet, BoolRow);
                            Square(ListOfIdentical[j], Color.Violet, BoolRow);
                            return false;
                        }
                    }
                }
            }   
            return true;
        }

        private static bool ErrorsFound( string RowColumnString, int NumberOfSquare, bool BoolRow)
        {
            // we assume correct Row or Column (Lime)
            Square(NumberOfSquare, Color.Lime, BoolRow);

            // test on rows or columns if there is "000" and "111"
            return TestRowColumn(RowColumnString, NumberOfSquare, BoolRow);
        }

        private static bool TestRowColumn(string RowColumnString, int NumberOfSquare, bool BoolRow)
        {
            if (RowColumnString.Contains("000") == true || RowColumnString.Contains("111") == true)
            {
                Square(NumberOfSquare, Color.Orange, BoolRow);
                return false;
            }
            if (CountOfNumbers("0", RowColumnString) > MaxNumberOfNumbers || CountOfNumbers("1", RowColumnString) > MaxNumberOfNumbers)
            {
                Square(NumberOfSquare, Color.BlueViolet, BoolRow);
                return false;
            }
            return true;
        }

        private static int CountOfNumbers(string Number, string Combination)
        {
            return Combination.ToList().Where(n => n == Convert.ToChar(Number)).Count();
        }

        public static void BuildGrid(int Tail) 
        {
            List<string> ListRowsIncorrect = new List<string>();

            Random Randomizer = new Random(DateTime.Now.Millisecond);
            //Random Randomizer = new Random(5);
            bool LoopRestart;
            GridSize = Tail;
            MaxNumberOfNumbers = GridSize / 2;

            InitializeCombinations();
            do
            {
                LoopRestart = false;

                ListRowsPoses.Clear();
                ListColumnsPoses.Clear();
                ListRowsIncorrect.Clear();

                for (int i = 0; i <= GridSize - 1; i++)
                {
                    ListColumnsPoses.Add(string.Empty);
                }

                // first 2 rows
                for (int i = 0; i <= 1; i++)
                {
                    IndexRowCombination = Randomizer.Next(0, ListRowsCombinations.Count - 1);
                    AddLinesPosees(i);
                }

                // next rows
                for (int i = 2; i <= GridSize - 1; i++)
                {
                    if (ListRowsIncorrect.Count > 0)
                    {
                        // incorrect rows are returning to the Combinations
                        ListRowsCombinations.AddRange(ListRowsIncorrect);
                        ListRowsIncorrect.Clear();
                    }
                    do
                    {
                        IndexRowCombination = Randomizer.Next(0, ListRowsCombinations.Count - 1);

                        // test if the columns are correct
                        if (TestColumnsCorrect(ListRowsCombinations[IndexRowCombination]) == true)
                        {
                            AddLinesPosees(i);
                            break;
                        }
                        else
                        {
                            ListRowsIncorrect.Add(ListRowsCombinations[IndexRowCombination]);
                            ListRowsCombinations.RemoveAt(IndexRowCombination);
                            if (ListRowsCombinations.Count == 0)
                                break;
                        }
                    }while (true);

                    if (ListRowsCombinations.Count == 0)
                    {
                        LoopRestart = true;
                        break;
                    }
                }

                // test the columns possibly in duplicate
                // Grid is false - restart the loop
                if (LoopRestart == false)
                {
                    // test if there are duplicate columns
                    if (ListColumnsPoses.Distinct().ToList().Count == ListColumnsPoses.Count)
                    {
                        break;
                    }
                }
                // rows placed in the possible combinations
                ListRowsCombinations.AddRange(ListRowsPoses);

                // the wrong rows if there are any
                if (ListRowsIncorrect.Count > 0)
                {
                    ListRowsCombinations.AddRange(ListRowsIncorrect);
                }
            }while (true); 
        }
        // fix
        public static void HideBoxes()
        {
            // randomly hide the squares
            Random Randomizer = new Random(DateTime.Now.Millisecond);
            //Random Randomizer = new Random(5);

            for (int i = 0; i <= Convert.ToInt32(((Math.Pow(GridSize, 2)) / 2) - 1); i++)
            {
                ClassGameField.EmptyBoxes(Randomizer.Next(0, ListGameBoxes.Count - 1), ListGameBoxes);
            }
        }

        private static bool TestColumnsCorrect(string Row)
        {
            string Column;
            for (int i = 0; i <= GridSize - 1; i++)
            {
                Column = ListColumnsPoses[i] + Row.Substring(i, 1); // add to the column already set the Number of the row passed in parameter
                if (Column.Contains("000") == true || Column.Contains("111") == true || CountOfNumbers("0", Column) > MaxNumberOfNumbers || CountOfNumbers("1", Column) > MaxNumberOfNumbers)
                {
                    return false;
                }
            }
        return true;
        }

        private static void InitializeCombinations()
        {
            string RowColumnString;
            ListRowsCombinations.Clear();
            int CombinationsCount = Convert.ToInt32(Math.Pow(2, GridSize));
            for (int i = 0; i <= CombinationsCount - 1; i++)
            {
                RowColumnString = Convert.ToString(i, 2); // convert to binary string
                RowColumnString = new string('0',GridSize - RowColumnString.Length) + RowColumnString;
                if (CountOfNumbers("0", RowColumnString) == MaxNumberOfNumbers && RowColumnString.Contains("000") == false && RowColumnString.Contains("111") == false)
                    ListRowsCombinations.Add(RowColumnString);
            }
        }

        private static void AddLinesPosees(int NumeroRow)
        {
            ListRowsPoses.Add(ListRowsCombinations[IndexRowCombination]);
            ListRowsCombinations.RemoveAt(IndexRowCombination);

            // add a number to each column
            for (int j = 0; j <= GridSize - 1; j++)
            {
                ListColumnsPoses[j] = ListColumnsPoses[j] + ListRowsPoses[NumeroRow].Substring(j, 1);
            }
        }
    }
}
